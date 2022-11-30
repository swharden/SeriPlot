using ScottPlot.Plottable;
using System.IO.Ports;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeriPlot.Gui;

public partial class Form1 : Form
{
    SerialPort? Ser = null;
    static string LastLine = string.Empty;
    static readonly double[] Data = new double[2_000];
    readonly ScottPlot.Plottable.VLine VLine;
    static int NextDataIndex = 0;

    public Form1()
    {
        InitializeComponent();

        cbBaud.Items.Add(115200);
        cbBaud.SelectedIndex = 0;

        formsPlot1.Plot.AddSignal(Data);
        VLine = formsPlot1.Plot.AddVerticalLine(0, Color.Red, width: 2);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ReScan();
    }

    private void ReScan()
    {
        cbPort.Items.Clear();
        cbPort.Items.AddRange(SerialPort.GetPortNames());

        if (cbPort.Items.Count > 0)
            cbPort.SelectedIndex = cbPort.Items.Count - 1;
    }

    private void CloseSerialPort()
    {
        if (Ser is not null)
        {
            Ser.Close();
            Ser.Dispose();
            LastLine = "Disconnected";
        }
    }

    private void OpenSerialPort()
    {
        LastLine = "Connecting...";
        Application.DoEvents();
        Ser = new SerialPort(cbPort.Text, int.Parse(cbBaud.Text));
        Ser.Open();
        Ser.ReadLine();
        Ser.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
    }

    private void cbOpen_CheckedChanged(object sender, EventArgs e)
    {
        if (cbOpen.Checked)
            OpenSerialPort();
        else
            CloseSerialPort();
    }

    private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
    {
        SerialPort sp = (SerialPort)sender;
        string lastLine = sp.ReadLine().Trim();
        LastLine = lastLine;
        string[] parts = lastLine.Split(",");
        try
        {
            Data[NextDataIndex % Data.Length] = double.Parse(parts[0]);
            NextDataIndex += 1;
        }
        catch
        {
            System.Diagnostics.Debug.WriteLine($"PARSING ERROR: {LastLine}");
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        lblLastLine.Text = LastLine;
        VLine.X = NextDataIndex % Data.Length;
        formsPlot1.Refresh();
    }
}
