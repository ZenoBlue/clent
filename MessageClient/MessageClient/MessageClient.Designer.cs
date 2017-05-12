using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageClient));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lal_date = new System.Windows.Forms.Label();
            this.ID_10 = new RoundButton.RoundButton();
            this.ID_5 = new RoundButton.RoundButton();
            this.ID_9 = new RoundButton.RoundButton();
            this.ID_8 = new RoundButton.RoundButton();
            this.ID_4 = new RoundButton.RoundButton();
            this.ID_7 = new RoundButton.RoundButton();
            this.ID_3 = new RoundButton.RoundButton();
            this.ID_6 = new RoundButton.RoundButton();
            this.ID_2 = new RoundButton.RoundButton();
            this.ID_1 = new RoundButton.RoundButton();
            this.roundButton6 = new RoundButton.RoundButton();
            this.roundButton5 = new RoundButton.RoundButton();
            this.roundButton4 = new RoundButton.RoundButton();
            this.roundButton3 = new RoundButton.RoundButton();
            this.roundButton2 = new RoundButton.RoundButton();
            this.roundButton1 = new RoundButton.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(521, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "©copyright韩山师范学院";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(28, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 418);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(725, 57);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 55);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "USERNAME";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lal_date
            // 
            this.lal_date.AutoSize = true;
            this.lal_date.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lal_date.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lal_date.ForeColor = System.Drawing.Color.White;
            this.lal_date.Location = new System.Drawing.Point(567, 23);
            this.lal_date.Name = "lal_date";
            this.lal_date.Size = new System.Drawing.Size(58, 21);
            this.lal_date.TabIndex = 16;
            this.lal_date.Text = "时间戳";
            // 
            // ID_10
            // 
            this.ID_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_10.BackgroundImage")));
            this.ID_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_10.Diameter = 52;
            this.ID_10.FlatAppearance.BorderSize = 0;
            this.ID_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_10.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_10.ImageEnter")));
            this.ID_10.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_10.ImageNormal")));
            this.ID_10.Location = new System.Drawing.Point(633, 323);
            this.ID_10.Name = "ID_10";
            this.ID_10.Size = new System.Drawing.Size(52, 52);
            this.ID_10.TabIndex = 17;
            this.ID_10.UseVisualStyleBackColor = false;
            // 
            // ID_5
            // 
            this.ID_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_5.BackgroundImage")));
            this.ID_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_5.Diameter = 52;
            this.ID_5.FlatAppearance.BorderSize = 0;
            this.ID_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_5.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_5.ImageEnter")));
            this.ID_5.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_5.ImageNormal")));
            this.ID_5.Location = new System.Drawing.Point(25, 323);
            this.ID_5.Name = "ID_5";
            this.ID_5.Size = new System.Drawing.Size(52, 52);
            this.ID_5.TabIndex = 17;
            this.ID_5.UseVisualStyleBackColor = false;
            // 
            // ID_9
            // 
            this.ID_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_9.BackgroundImage")));
            this.ID_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_9.Diameter = 52;
            this.ID_9.FlatAppearance.BorderSize = 0;
            this.ID_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_9.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_9.ImageEnter")));
            this.ID_9.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_9.ImageNormal")));
            this.ID_9.Location = new System.Drawing.Point(634, 265);
            this.ID_9.Name = "ID_9";
            this.ID_9.Size = new System.Drawing.Size(52, 52);
            this.ID_9.TabIndex = 17;
            this.ID_9.UseVisualStyleBackColor = false;
            // 
            // ID_8
            // 
            this.ID_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_8.BackgroundImage")));
            this.ID_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_8.Diameter = 52;
            this.ID_8.FlatAppearance.BorderSize = 0;
            this.ID_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_8.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_8.ImageEnter")));
            this.ID_8.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_8.ImageNormal")));
            this.ID_8.Location = new System.Drawing.Point(634, 207);
            this.ID_8.Name = "ID_8";
            this.ID_8.Size = new System.Drawing.Size(52, 52);
            this.ID_8.TabIndex = 17;
            this.ID_8.UseVisualStyleBackColor = false;
            // 
            // ID_4
            // 
            this.ID_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_4.BackgroundImage")));
            this.ID_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_4.Diameter = 52;
            this.ID_4.FlatAppearance.BorderSize = 0;
            this.ID_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_4.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_4.ImageEnter")));
            this.ID_4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_4.ImageNormal")));
            this.ID_4.Location = new System.Drawing.Point(26, 265);
            this.ID_4.Name = "ID_4";
            this.ID_4.Size = new System.Drawing.Size(52, 52);
            this.ID_4.TabIndex = 17;
            this.ID_4.UseVisualStyleBackColor = false;
            // 
            // ID_7
            // 
            this.ID_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_7.BackgroundImage")));
            this.ID_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_7.Diameter = 52;
            this.ID_7.FlatAppearance.BorderSize = 0;
            this.ID_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_7.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_7.ImageEnter")));
            this.ID_7.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_7.ImageNormal")));
            this.ID_7.Location = new System.Drawing.Point(633, 144);
            this.ID_7.Name = "ID_7";
            this.ID_7.Size = new System.Drawing.Size(52, 52);
            this.ID_7.TabIndex = 17;
            this.ID_7.UseVisualStyleBackColor = false;
            // 
            // ID_3
            // 
            this.ID_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_3.BackgroundImage")));
            this.ID_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_3.Diameter = 52;
            this.ID_3.FlatAppearance.BorderSize = 0;
            this.ID_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_3.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_3.ImageEnter")));
            this.ID_3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_3.ImageNormal")));
            this.ID_3.Location = new System.Drawing.Point(26, 207);
            this.ID_3.Name = "ID_3";
            this.ID_3.Size = new System.Drawing.Size(52, 52);
            this.ID_3.TabIndex = 17;
            this.ID_3.UseVisualStyleBackColor = false;
            // 
            // ID_6
            // 
            this.ID_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_6.BackgroundImage")));
            this.ID_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_6.Diameter = 52;
            this.ID_6.FlatAppearance.BorderSize = 0;
            this.ID_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_6.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_6.ImageEnter")));
            this.ID_6.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_6.ImageNormal")));
            this.ID_6.Location = new System.Drawing.Point(633, 86);
            this.ID_6.Name = "ID_6";
            this.ID_6.Size = new System.Drawing.Size(52, 52);
            this.ID_6.TabIndex = 17;
            this.ID_6.UseVisualStyleBackColor = false;
            // 
            // ID_2
            // 
            this.ID_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_2.BackgroundImage")));
            this.ID_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_2.Diameter = 52;
            this.ID_2.FlatAppearance.BorderSize = 0;
            this.ID_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_2.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_2.ImageEnter")));
            this.ID_2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_2.ImageNormal")));
            this.ID_2.Location = new System.Drawing.Point(25, 144);
            this.ID_2.Name = "ID_2";
            this.ID_2.Size = new System.Drawing.Size(52, 52);
            this.ID_2.TabIndex = 17;
            this.ID_2.UseVisualStyleBackColor = false;
            // 
            // ID_1
            // 
            this.ID_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.ID_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID_1.BackgroundImage")));
            this.ID_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ID_1.Diameter = 52;
            this.ID_1.FlatAppearance.BorderSize = 0;
            this.ID_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_1.ImageEnter = ((System.Drawing.Image)(resources.GetObject("ID_1.ImageEnter")));
            this.ID_1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ID_1.ImageNormal")));
            this.ID_1.Location = new System.Drawing.Point(25, 86);
            this.ID_1.Name = "ID_1";
            this.ID_1.Size = new System.Drawing.Size(52, 52);
            this.ID_1.TabIndex = 17;
            this.ID_1.UseVisualStyleBackColor = false;
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.roundButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton6.BackgroundImage")));
            this.roundButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton6.Diameter = 219;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.ImageEnter = ((System.Drawing.Image)(resources.GetObject("roundButton6.ImageEnter")));
            this.roundButton6.ImageNormal = ((System.Drawing.Image)(resources.GetObject("roundButton6.ImageNormal")));
            this.roundButton6.Location = new System.Drawing.Point(243, 168);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(219, 219);
            this.roundButton6.TabIndex = 12;
            this.toolTip6.SetToolTip(this.roundButton6, "实时显示");
            this.roundButton6.UseVisualStyleBackColor = false;
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.roundButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton5.BackgroundImage")));
            this.roundButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton5.Diameter = 68;
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.ImageEnter = ((System.Drawing.Image)(resources.GetObject("roundButton5.ImageEnter")));
            this.roundButton5.ImageNormal = ((System.Drawing.Image)(resources.GetObject("roundButton5.ImageNormal")));
            this.roundButton5.Location = new System.Drawing.Point(435, 359);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(68, 68);
            this.roundButton5.TabIndex = 11;
            this.toolTip5.SetToolTip(this.roundButton5, "电流");
            this.roundButton5.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.roundButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton4.BackgroundImage")));
            this.roundButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton4.Diameter = 67;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.ImageEnter = ((System.Drawing.Image)(resources.GetObject("roundButton4.ImageEnter")));
            this.roundButton4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("roundButton4.ImageNormal")));
            this.roundButton4.Location = new System.Drawing.Point(234, 371);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(67, 67);
            this.roundButton4.TabIndex = 10;
            this.toolTip4.SetToolTip(this.roundButton4, "陀螺仪");
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.roundButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton3.BackgroundImage")));
            this.roundButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundButton3.Diameter = 68;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.ImageEnter = ((System.Drawing.Image)(resources.GetObject("roundButton3.ImageEnter")));
            this.roundButton3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("roundButton3.ImageNormal")));
            this.roundButton3.Location = new System.Drawing.Point(459, 192);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(68, 68);
            this.roundButton3.TabIndex = 9;
            this.toolTip2.SetToolTip(this.roundButton3, "湿度");
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.roundButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton2.BackgroundImage")));
            this.roundButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton2.Diameter = 64;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ImageEnter = ((System.Drawing.Image)(resources.GetObject("roundButton2.ImageEnter")));
            this.roundButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("roundButton2.ImageNormal")));
            this.roundButton2.Location = new System.Drawing.Point(175, 195);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(64, 64);
            this.roundButton2.TabIndex = 8;
            this.toolTip2.SetToolTip(this.roundButton2, "压力");
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.roundButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton1.BackgroundImage")));
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundButton1.Diameter = 69;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.roundButton1.ImageEnter = ((System.Drawing.Image)(resources.GetObject("roundButton1.ImageEnter")));
            this.roundButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("roundButton1.ImageNormal")));
            this.roundButton1.Location = new System.Drawing.Point(314, 96);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(69, 69);
            this.roundButton1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.roundButton1, "温度");
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // MessageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(721, 451);
            this.Controls.Add(this.ID_10);
            this.Controls.Add(this.ID_5);
            this.Controls.Add(this.ID_9);
            this.Controls.Add(this.ID_8);
            this.Controls.Add(this.ID_4);
            this.Controls.Add(this.ID_7);
            this.Controls.Add(this.ID_3);
            this.Controls.Add(this.ID_6);
            this.Controls.Add(this.ID_2);
            this.Controls.Add(this.ID_1);
            this.Controls.Add(this.lal_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MessageClient";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.MessageClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundButton.RoundButton roundButton1;
        private RoundButton.RoundButton roundButton2;
        private RoundButton.RoundButton roundButton3;
        private RoundButton.RoundButton roundButton4;
        private RoundButton.RoundButton roundButton5;
        private RoundButton.RoundButton roundButton6;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Timer timer1;
        private Label lal_date;
        private RoundButton.RoundButton ID_1;
        private RoundButton.RoundButton ID_2;
        private RoundButton.RoundButton ID_3;
        private RoundButton.RoundButton ID_4;
        private RoundButton.RoundButton ID_5;
        private RoundButton.RoundButton ID_6;
        private RoundButton.RoundButton ID_7;
        private RoundButton.RoundButton ID_8;
        private RoundButton.RoundButton ID_9;
        private RoundButton.RoundButton ID_10;
    }

}

