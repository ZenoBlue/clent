using System.Diagnostics;
using System.Windows.Forms;
namespace MessageClient
{
    public partial class MessageClient : Form
    {
        public MessageClient()
        {
            InitializeComponent();
        }
        private string ID = "";
        private void MessageClient_Load(object sender, System.EventArgs e)
        {
            this.timer1.Start();
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.lal_date.Text = System.DateTime.Now.ToString();
         }

        private void btn_show_Click(object sender, System.EventArgs e)
        {
            show showwindow = new show();
            showwindow.getusr_id(this.lbl_usr.Text);
            showwindow.getusr_id(ID); //传id
            showwindow.Show();
        }
        public void getusr_id(string id)
        {
            this.lbl_usr.Text = id;
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.ID = "1111";
        }


    }
}
