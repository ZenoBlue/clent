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
        }

        // 连接服务器
        public bool flag = true;
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
