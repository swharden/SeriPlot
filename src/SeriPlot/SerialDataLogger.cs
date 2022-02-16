using ScottPlot;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SeriPlot
{
    public class SerialDataLogger : IDisposable
    {
        private readonly List<DateTime> Timestamps = new List<DateTime>();
        private readonly List<double>[] Data;
        private readonly SerialPort SP;
        private readonly string LineEnding;
        public int ChannelCount { get => Data.Length; }
        public int DataPointCount { get => Timestamps.Count; }
        private readonly string Port;

        public double[] GetValues(int channelIndex = 0) => Data[channelIndex].ToArray();

        public double[] GetOADates() => Timestamps.Select(x => x.ToOADate()).ToArray();
        public DateTime LastUpdate => Timestamps.Last();

        public SerialDataLogger(string port, int channelCount, int sampleRate = 115200, string lineEnding = "\r\n\r\n")
        {
            Port = port;
            LineEnding = lineEnding;

            Data = Enumerable.Range(0, channelCount).Select(x => new List<double>()).ToArray();
            SP = new SerialPort(port, sampleRate);
            SP.Open();
            Debug.WriteLine($"Connected to {Port}");
            SP.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string newData = sp.ReadExisting() + sp.ReadTo(LineEnding);
            ProcessNewData(newData);
        }

        // TODO: allow this to be injected somehow
        private void ProcessNewData(string newData)
        {
            string[] lines = newData.Split('\n')
                                    .Select(x => x.Trim())
                                    .Where(x => x.StartsWith("CH"))
                                    .ToArray();

            if (lines.Count() != ChannelCount)
            {
                Debug.WriteLine($"invalid packet");
                return;
            }

            double[] values = lines.Select(x => x.Split('\t')[0])
                                   .Select(x => x.Split(':')[1])
                                   .Select(x => Math.Round(double.Parse(x) * 3.3 / 4096, 3))
                                   .ToArray();

            string valuesText = string.Join("\t", values.Select(x => x.ToString()));
            Debug.WriteLine($"logged: {valuesText}");

            Timestamps.Add(DateTime.Now);
            for (int i = 0; i < ChannelCount; i++)
                Data[i].Add(values[i]);
        }

        public void Dispose()
        {
            SP.Close();
            Debug.WriteLine($"Disconnected from {Port}");
        }

        public void Clear()
        {
            for (int i = 0; i < ChannelCount; i++)
                Data[i].Clear();
            Timestamps.Clear();
        }

        public double GetLatestValue(int channel = 0) => (DataPointCount == 0) ? double.NaN : Data[channel].Last();
    }
}
