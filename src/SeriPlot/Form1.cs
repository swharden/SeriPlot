using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriPlot
{
    public partial class Form1 : Form
    {
        private SerialDataLogger Logger;

        public Form1()
        {
            InitializeComponent();
            ScanSerialPorts();
        }

        private void ScanSerialPorts()
        {
            PortsCombo.Items.Clear();
            PortsCombo.Items.AddRange(SerialPort.GetPortNames());
            if (PortsCombo.Items.Count > 0)
                PortsCombo.SelectedIndex = 0;
        }

        private void ScanButton_Click(object sender, EventArgs e) => ScanSerialPorts();

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (Logger is null)
            {
                string portName = PortsCombo.SelectedItem.ToString();
                Logger = new SerialDataLogger(portName, channelCount: 10);
                ConnectButton.Text = "Disconnect";
            }
            else
            {
                Logger.Dispose();
                Logger = null;
                ConnectButton.Text = "Connect";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Logger.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Logger is null || Logger.DataPointCount == 0)
                return;

            formsPlot1.plt.Clear();
            double[] ys = Logger.GetValues(0);
            formsPlot1.plt.PlotSignal(ys);
            formsPlot1.Render();

            DataTextbox.Text = Logger.GetLatestValues();
        }
    }
}
