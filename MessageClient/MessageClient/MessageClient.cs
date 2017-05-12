using System.Windows.Forms;
namespace MessageClient
{
    public partial class MessageClient : Form
    {
        public MessageClient()
        {
            InitializeComponent();
        }

        private void MessageClient_Load(object sender, System.EventArgs e)
        {
            this.timer1.Start();
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.lal_date.Text = System.DateTime.Now.ToString();
         }
      }
}
