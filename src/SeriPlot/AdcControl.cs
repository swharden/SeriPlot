using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SeriPlot
{
    public partial class AdcControl : UserControl
    {
        public AdcControl()
        {
            InitializeComponent();
            label2.Text = "no data";
        }

        public bool IsVisible { get => checkBox1.Checked; set => checkBox1.Checked = value; }

        public void SetChannel(int channel, Color color)
        {
            checkBox1.Text = $"Ch{channel}";
            Color lightColor = Color.FromArgb(50, color);
            checkBox1.BackColor = SystemColors.Control;
            label2.BackColor = lightColor;
        }

        public void SetValue(double value)
        {
            label2.Text = $"{value:0.000} V";
        }
    }
}
