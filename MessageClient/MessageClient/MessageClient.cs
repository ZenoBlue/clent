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
        //private void MessageClient_FormClose(object sender, FormClosedEventArgs e)//kill process
        //{
        //    Process current = Process.GetCurrentProcess();
        //    Process[] processes = Process.GetProcessesByName(current.ProcessName);
        //    foreach (Process process in processes)
        //    {
        //        if (process.Id == current.Id)
        //        {
        //            process.Kill();
        //        }
        //    }
        //}
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
            showwindow.Show();
        }
        public void getusr_id(string id)
        {
            this.lbl_usr.Text = id;
        }
    }
}
