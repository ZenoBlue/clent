namespace MessageClient
{
    partial class MessageClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_showing = new System.Windows.Forms.RichTextBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(68, 74);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(83, 23);
            this.button_connect.TabIndex = 11;
            this.button_connect.Text = "连接服务器";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_send.Location = new System.Drawing.Point(6, 20);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_send.Size = new System.Drawing.Size(248, 72);
            this.textBox_send.TabIndex = 10;
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Location = new System.Drawing.Point(260, 20);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 9;
            this.button_send.Text = "发送信息";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Ip.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Ip.Location = new System.Drawing.Point(55, 20);
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(96, 21);
            this.textBox_Ip.TabIndex = 1;
            this.textBox_Ip.Text = "192.168.191.1";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Port.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Port.Location = new System.Drawing.Point(55, 47);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(49, 21);
            this.textBox_Port.TabIndex = 2;
            this.textBox_Port.Text = "8800";
            // 
            // textBox_showing
            // 
            this.textBox_showing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_showing.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_showing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_showing.Location = new System.Drawing.Point(9, 20);
            this.textBox_showing.Name = "textBox_showing";
            this.textBox_showing.Size = new System.Drawing.Size(284, 72);
            this.textBox_showing.TabIndex = 16;
            this.textBox_showing.Text = "";
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.button_connect);
            this.groupbox.Controls.Add(this.textBox_Ip);
            this.groupbox.Controls.Add(this.textBox_Port);
            this.groupbox.Location = new System.Drawing.Point(4, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(172, 107);
            this.groupbox.TabIndex = 17;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "连接";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "服务器";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(182, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 251);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "压力显示";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(351, 155);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aGauge2);
            this.groupBox2.Location = new System.Drawing.Point(6, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 130);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "温湿度显示";
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 500;
            this.aGauge2.BaseArcStart = 180;
            this.aGauge2.BaseArcSweep = 90;
            this.aGauge2.BaseArcWidth = 0;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(70, 70);
            this.aGauge2.Location = new System.Drawing.Point(72, 43);
            this.aGauge2.MaxValue = 60F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Blue;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.RoyalBlue;
            this.aGauge2.NeedleRadius = 50;
            this.aGauge2.NeedleType = 1;
            this.aGauge2.NeedleWidth = 3;
            this.aGauge2.Range_Idx = ((byte)(0));
            this.aGauge2.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge2.RangeEnabled = false;
            this.aGauge2.RangeEndValue = 300F;
            this.aGauge2.RangeInnerRadius = 70;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = -100F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.RosyBrown;
            this.aGauge2.ScaleLinesInterInnerRadius = 42;
            this.aGauge2.ScaleLinesInterOuterRadius = 55;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMajorInnerRadius = 40;
            this.aGauge2.ScaleLinesMajorOuterRadius = 55;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 43;
            this.aGauge2.ScaleLinesMinorNumOf = 1;
            this.aGauge2.ScaleLinesMinorOuterRadius = 50;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 62;
            this.aGauge2.ScaleNumbersRotation = 90;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 2;
            this.aGauge2.Size = new System.Drawing.Size(92, 85);
            this.aGauge2.TabIndex = 12;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 22F;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_showing);
            this.groupBox5.Location = new System.Drawing.Point(6, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 98);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据校验";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_send);
            this.groupBox6.Controls.Add(this.textBox_send);
            this.groupBox6.Location = new System.Drawing.Point(334, 349);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 98);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "发送数据";
            // 
            // MessageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(707, 474);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MessageClient";
            this.Text = "客户端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageClient_FormClosed);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.RichTextBox textBox_showing;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private AGaugeApp.AGauge aGauge1;
        private AGaugeApp.AGauge aGauge2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

