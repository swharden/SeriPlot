namespace SeriPlot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PortsCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ScanButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AutoAxisCheckbox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.adcControl1 = new SeriPlot.AdcControl();
            this.adcControl2 = new SeriPlot.AdcControl();
            this.adcControl3 = new SeriPlot.AdcControl();
            this.adcControl4 = new SeriPlot.AdcControl();
            this.adcControl5 = new SeriPlot.AdcControl();
            this.adcControl6 = new SeriPlot.AdcControl();
            this.adcControl7 = new SeriPlot.AdcControl();
            this.adcControl8 = new SeriPlot.AdcControl();
            this.adcControl9 = new SeriPlot.AdcControl();
            this.adcControl10 = new SeriPlot.AdcControl();
            this.groupBox1.SuspendLayout();
            this.label3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortsCombo
            // 
            this.PortsCombo.FormattingEnabled = true;
            this.PortsCombo.Location = new System.Drawing.Point(6, 22);
            this.PortsCombo.Name = "PortsCombo";
            this.PortsCombo.Size = new System.Drawing.Size(141, 23);
            this.PortsCombo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.ScanButton);
            this.groupBox1.Controls.Add(this.PortsCombo);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(73, 51);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(74, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(6, 51);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(61, 23);
            this.ScanButton.TabIndex = 1;
            this.ScanButton.Text = "Rescan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 22);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(45, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.Location = new System.Drawing.Point(173, 12);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(717, 521);
            this.formsPlot1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Controls.Add(this.label2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ch0: 1.234 V";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ch0: 1.234 V";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AutoAxisCheckbox);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port";
            // 
            // AutoAxisCheckbox
            // 
            this.AutoAxisCheckbox.AutoSize = true;
            this.AutoAxisCheckbox.Checked = true;
            this.AutoAxisCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoAxisCheckbox.Location = new System.Drawing.Point(6, 51);
            this.AutoAxisCheckbox.Name = "AutoAxisCheckbox";
            this.AutoAxisCheckbox.Size = new System.Drawing.Size(79, 19);
            this.AutoAxisCheckbox.TabIndex = 2;
            this.AutoAxisCheckbox.Text = "Auto-Axis";
            this.AutoAxisCheckbox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adcControl1
            // 
            this.adcControl1.IsVisible = false;
            this.adcControl1.Location = new System.Drawing.Point(12, 99);
            this.adcControl1.Name = "adcControl1";
            this.adcControl1.Size = new System.Drawing.Size(142, 29);
            this.adcControl1.TabIndex = 3;
            // 
            // adcControl2
            // 
            this.adcControl2.IsVisible = false;
            this.adcControl2.Location = new System.Drawing.Point(12, 134);
            this.adcControl2.Name = "adcControl2";
            this.adcControl2.Size = new System.Drawing.Size(142, 29);
            this.adcControl2.TabIndex = 3;
            // 
            // adcControl3
            // 
            this.adcControl3.IsVisible = false;
            this.adcControl3.Location = new System.Drawing.Point(12, 169);
            this.adcControl3.Name = "adcControl3";
            this.adcControl3.Size = new System.Drawing.Size(142, 29);
            this.adcControl3.TabIndex = 3;
            // 
            // adcControl4
            // 
            this.adcControl4.IsVisible = false;
            this.adcControl4.Location = new System.Drawing.Point(12, 204);
            this.adcControl4.Name = "adcControl4";
            this.adcControl4.Size = new System.Drawing.Size(142, 29);
            this.adcControl4.TabIndex = 3;
            // 
            // adcControl5
            // 
            this.adcControl5.IsVisible = false;
            this.adcControl5.Location = new System.Drawing.Point(13, 239);
            this.adcControl5.Name = "adcControl5";
            this.adcControl5.Size = new System.Drawing.Size(142, 29);
            this.adcControl5.TabIndex = 3;
            // 
            // adcControl6
            // 
            this.adcControl6.IsVisible = false;
            this.adcControl6.Location = new System.Drawing.Point(12, 274);
            this.adcControl6.Name = "adcControl6";
            this.adcControl6.Size = new System.Drawing.Size(142, 29);
            this.adcControl6.TabIndex = 3;
            // 
            // adcControl7
            // 
            this.adcControl7.IsVisible = false;
            this.adcControl7.Location = new System.Drawing.Point(12, 309);
            this.adcControl7.Name = "adcControl7";
            this.adcControl7.Size = new System.Drawing.Size(142, 29);
            this.adcControl7.TabIndex = 3;
            // 
            // adcControl8
            // 
            this.adcControl8.IsVisible = false;
            this.adcControl8.Location = new System.Drawing.Point(12, 344);
            this.adcControl8.Name = "adcControl8";
            this.adcControl8.Size = new System.Drawing.Size(142, 29);
            this.adcControl8.TabIndex = 3;
            // 
            // adcControl9
            // 
            this.adcControl9.IsVisible = false;
            this.adcControl9.Location = new System.Drawing.Point(12, 379);
            this.adcControl9.Name = "adcControl9";
            this.adcControl9.Size = new System.Drawing.Size(142, 29);
            this.adcControl9.TabIndex = 3;
            // 
            // adcControl10
            // 
            this.adcControl10.IsVisible = false;
            this.adcControl10.Location = new System.Drawing.Point(12, 414);
            this.adcControl10.Name = "adcControl10";
            this.adcControl10.Size = new System.Drawing.Size(142, 29);
            this.adcControl10.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 545);
            this.Controls.Add(this.adcControl10);
            this.Controls.Add(this.adcControl9);
            this.Controls.Add(this.adcControl8);
            this.Controls.Add(this.adcControl7);
            this.Controls.Add(this.adcControl6);
            this.Controls.Add(this.adcControl5);
            this.Controls.Add(this.adcControl4);
            this.Controls.Add(this.adcControl3);
            this.Controls.Add(this.adcControl2);
            this.Controls.Add(this.adcControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SeriPlot";
            this.groupBox1.ResumeLayout(false);
            this.label3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortsCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ScanButton;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox AutoAxisCheckbox;
        private AdcControl adcControl1;
        private AdcControl adcControl2;
        private AdcControl adcControl3;
        private AdcControl adcControl4;
        private AdcControl adcControl5;
        private AdcControl adcControl6;
        private AdcControl adcControl7;
        private AdcControl adcControl8;
        private AdcControl adcControl9;
        private AdcControl adcControl10;
    }
}

