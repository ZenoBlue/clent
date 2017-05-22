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
        public show()
        {
            InitializeComponent();
            this.timer1.Start();
            this.timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            show_text();
        }
        public void getusr_id(string id)
        {
            this.lbl_usr.Text = id;
        }
        private void show_text()
        {
            string constr = "server=123.207.28.55;uid=admin;PWD=admin;Database=factory_db";
            MySqlConnection mycon = new MySql.Data.MySqlClient.MySqlConnection(constr);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand("select W_info,S_info,Y_info,D_info,roll_info,pitch_info,yaw_info from manipulator_table where TIME=(select max(TIME) from manipulator_table)", mycon);
            MySqlDataReader reader = mycmd.ExecuteReader();

            while (reader.Read())
            {
                lb_W.Text =(Convert.ToInt32(reader[0])/10).ToString();
                lb_S.Text =(Convert.ToInt32(reader[1])/10).ToString();
                lb_Y.Text =(Convert.ToInt32(reader[2])/10).ToString();
                lb_D.Text =(Convert.ToInt32(reader[3])/10).ToString();
                lbx.Text = (Convert.ToInt32(reader[4]) /10).ToString()+"."+(Convert.ToInt32(reader[4])%10).ToString();
                lby.Text = (Convert.ToInt32(reader[5]) / 10).ToString()+"."+(Convert.ToInt32(reader[5]) % 10).ToString();
                lbz.Text = (Convert.ToInt32(reader[6]) / 10).ToString()+"."+(Convert.ToInt32(reader[6]) %10).ToString();
            }
            mycon.Close();
        }
        private void show_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.lal_date.Text = System.DateTime.Now.ToString();
        }

    }
}
