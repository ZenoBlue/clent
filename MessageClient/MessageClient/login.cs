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
        private void login_btn_Click(object sender, EventArgs e)
        {
            string constr = "server=localhost;User Id=root;password=;Database=info";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand("select * from login_schema where usr_Name='"+this.login_name.Text+"'", mycon);
            MySqlDataReader reader = null;
            reader =mycmd.ExecuteReader();
            if (reader.HasRows) 
            {
                MessageBox.Show("有数据");
                while (reader.Read())
                {
                    this.label3.Text = reader[0].ToString()+reader[1].ToString();
                }
                // this.Hide();   //隐藏窗口
                //MessageClient messageclient = new MessageClient();//跳转窗体
                //  messageclient.Show();
             
            }
          //  this.label3.Text = db.getmysqlread("select * from login_schema where usr_Name like" + login_name.Text).ToString();
          
        }

}
}
