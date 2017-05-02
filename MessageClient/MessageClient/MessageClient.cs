using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MessageClient
{
    public partial class MessageClient : Form
    {
        Client client;    // 客户端实例
        public MessageClient()
        {
            InitializeComponent();
            Initchart();
        }

        // 连接服务器
        public bool flag = true;
                public void Initchart()
                {
                    //定义图表区域
                                this.chart1.ChartAreas.Clear();
                                ChartArea chartArea1 = new ChartArea("C1");
                                 this.chart1.ChartAreas.Add(chartArea1);
                                //定义存储和显示点的容器
                                 this.chart1.Series.Clear();
                                Series series1 = new Series("S1");
                                series1.ChartArea = "C1";
                                 this.chart1.Series.Add(series1);
                                //设置图表显示样式
                                 this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                                 this.chart1.ChartAreas[0].AxisY.Maximum = 100;
                                 this.chart1.ChartAreas[0].AxisX.Interval = 5;
                                 this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
                                 this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
                                //设置标题
                                this.chart1.Titles.Clear();
                                 this.chart1.Titles.Add("S01");
                                 this.chart1.Titles[0].Text = "压力显示";
                                 this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
                                 this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                                 //设置图表显示样式
                                this.chart1.Series[0].Color = Color.Red;
                                 this.chart1.Series[0].ChartType = SeriesChartType.Spline;      
                                 this.chart1.Series[0].Points.Clear();
                                    for (int i = 0; i < 100; i++)
                                    {
                                        this.chart1.Series[0].Points.AddXY(i, i+2);
                                    }


            }
        private void button_connect_Click(object sender, EventArgs e)
        {
            
           
            if (flag)
            {
                if (client == null)
                    client = new Client(ClientPrint, textBox_Ip.Text, textBox_Port.Text);
                if (!client.connected) client.start();
                if (client != null)
                    this.Text = "客户端 " + client.localIpPort;
                this.button_connect.Text = "关闭";
                flag = false;
            }
            else
            {
                this.button_connect.Text = "连接服务器";
                client.close();
                flag = true;
            }
        }

        // 客户端输出信息
        private void ClientPrint(string info)
        {
            if (textBox_showing.InvokeRequired)
            {
                Client.Print F = new Client.Print(ClientPrint);
                this.Invoke(F, new object[] { info });
            }
            else
            {
                if (info != null)
                {
                    textBox_showing.SelectionColor = Color.Red;
                    textBox_showing.AppendText(info);
                    textBox_showing.AppendText(Environment.NewLine);
                    textBox_showing.ScrollToCaret();
                   
                    //str = Convert.ToUInt16(info);
                    //this.chart1.DataSource = str;
                    //this.chart1.DataBind();
                }
            }
        }

        // 发送信息到服务器
        private void button_send_Click(object sender, EventArgs e)
        {
            if (client != null && client.connected)
            {
                string info = textBox_send.Text;
                client.Send(info);
            }
        }

        // 关闭界面停止服务运行
        private void MessageClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null && client.connected)
                client.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.close();
        }
    }
}
