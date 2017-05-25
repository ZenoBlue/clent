/// <summary>
/// 六轴机器人远程故障与监测系统v1.0
/// ©韩山师范学院
/// provide by 赵亮(Zeno)
/// </summary>
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MessageClient
{
    public partial class MessageClient : Form
    {
        public MessageClient()
        {
            InitializeComponent();
        }
        private string ID = "";
        private string database = "";
        private string usr_info = "";
        private void MessageClient_Load(object sender, System.EventArgs e)
        {
            this.timer1.Start();
            string constr = "server=111.230.139.167;uid=zeno;PWD=zeno;Database=" + this.database;   //打开数据库
            MySqlConnection mycon = new MySql.Data.MySqlClient.MySqlConnection(constr);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand("select * from user where user_name='"+this.usr_info+"'", mycon);  //查询用户信息
            MySqlDataReader reader = mycmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.radioButton1.Text = reader[1].ToString();
                    this.radioButton2.Text = reader[2].ToString();
                    this.radioButton3.Text = reader[3].ToString();
                    this.radioButton4.Text = reader[4].ToString();
                    this.radioButton5.Text = reader[5].ToString();
                }
            }
            mycon.Close();
        }
        private void MessageClient_FormClosing (object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.lal_date.Text = System.DateTime.Now.ToString();
         }

        private void btn_show_Click(object sender, System.EventArgs e)
        {
            show showwindow = new show();
            showwindow.getusr_info(this.lbl_usr.Text);//传用户名
            showwindow.getmanipylator_ID(ID); //传id
            showwindow.Show();
        }
        public void getusr_id(string usr_info,string factory)
        {
            this.usr_info= this.lbl_usr.Text =usr_info;
            this.database = factory;

        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.ID = this.radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            this.ID = this.radioButton2.Text;
        }
    }
}
