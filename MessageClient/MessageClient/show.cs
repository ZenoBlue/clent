﻿/// <summary>
/// 六轴机器人远程故障与监测系统v1.0
/// ©韩山师范学院
/// provide by 赵亮(Zeno)
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MessageClient
{
    public partial class show : Form
    {
        Client client;//实例化
        public show()
        {
            InitializeComponent();
            this.timer2.Start();
        }
        private string ID = "";
        private int res1, res2 ,res= 0;
        public void getusr_info(string id)
        {
            this.lbl_usr.Text = id;
        }
        private void ClientPrint(string info)
        {
            string str = info;
            if (client.connected)
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
                        textBox_showing.AppendText(info);
                        textBox_showing.AppendText(Environment.NewLine);
                        textBox_showing.ScrollToCaret();
                        if (check(info))                       //符合协议格式
                        {
                            string result = str.Substring(res1, res);
                            string[] resultArry = result.Split('&'); //取出协议数据
                            if (resultArry[0].Equals(ID))
                            {
                                showMessage(resultArry);
                            }

                        }
                    }
                }
            }
        }
        private void show_Load(object sender, EventArgs e)   //窗口加载连接tcp
        {
            if (client == null)
                client = new Client(ClientPrint, "111.230.139.167", "8899");
            if (!client.connected)
            {
                client.start();
                client.Send("@zeno@");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.lal_date.Text = System.DateTime.Now.ToString();
        }
        public void getmanipylator_ID(string str)
        {
            this.ID = str;
        }
        private void show_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.connected)
                this.textBox_showing.Dispose();
            client.stop();
           
            //System.Environment.Exit(0);
        }

        public bool check(string str)
        {
             res1 = str.IndexOf("$-") + 2;// 协议头
             res2 = str.IndexOf("-$");//协议尾
             res = res2 - res1;          //协议长
            if (res > 0)
                return true;
            else
                return false;
        }
        public void showMessage(string []reArry)
        {
            for (int i = 1; i < 8; i++)
            {
                reArry[i] = (Convert.ToInt32(reArry[i]) / 10).ToString() + "." + (Convert.ToInt32(reArry[i]) % 10).ToString();
            }
                lb_W.Text = reArry[1];
                lb_S.Text = reArry[2];
                lb_Y.Text = reArry[3];
                lb_D.Text = reArry[4];
                lbx.Text = reArry[5];
                lby.Text = reArry[6];
                lbz.Text = reArry[7];

        }
    }
}
