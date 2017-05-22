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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.login_name.KeyDown += new KeyEventHandler(login_KeyDown);
            this.login_pwd.KeyDown += new KeyEventHandler(login_KeyDown);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "server=123.207.28.55;uid=admin;PWD=admin;Database=factory_db";
            MySqlConnection mycon = new MySql.Data.MySqlClient.MySqlConnection(constr);
            mycon.Open();
            if (!(this.login_name.Text != "")) //检查是为空的情况
            {
                MessageBox.Show("用户名不允许为空！");
            }
            else if (!(this.login_pwd.Text != ""))
            {
                MessageBox.Show("请填写密码！");
            }
            else   //不为空的情况
            {
                MySqlCommand mycmd = new MySqlCommand("select * from alluser_info where User_name='" + this.login_name.Text + "'", mycon);
                MySqlDataReader reader = mycmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!string.Equals(this.login_name.Text, reader[1].ToString()) || !string.Equals(this.login_pwd.Text, reader[2].ToString()))
                        {
                            MessageBox.Show("请核对您的用户名或密码！");
                        }
                        else
                        {
                            this.Hide();
                            MessageClient messageclient = new MessageClient();//跳转窗体
                            messageclient.getusr_id(login_name.Text);
                            messageclient.Show();
                        }
                    }
                }
            }
            mycon.Close();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2_Click(button2, null);
            }
        }
    }
}
