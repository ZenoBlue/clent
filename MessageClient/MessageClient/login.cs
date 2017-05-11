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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string constr = "server=localhost;User Id=root;password=;Database=info";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            if (!(this.login_name.Text != "") || !(this.login_pwd.Text != "")) //检查是为空的情况
            {
                MessageBox.Show("用户名和密码都不为空！");
            }
            else   //不为空的情况
            {
                MySqlCommand mycmd = new MySqlCommand("select * from login_schema where usr_Name='" + this.login_name.Text + "'", mycon);
                MySqlDataReader reader = mycmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!string.Equals(this.login_name.Text, reader[0].ToString()) || !string.Equals(this.login_pwd.Text, reader[1].ToString()))
                        {
                            MessageBox.Show("请核对您的用户名或密码！");
                        }
                        else
                        {
                            this.Hide();
                            MessageClient messageclient = new MessageClient();//跳转窗体
                            messageclient.Show();
                        }
                    }
                }
            }
        }
    }
}
