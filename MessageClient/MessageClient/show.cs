using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageClient
{
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lal_date.Text = System.DateTime.Now.ToString();
        }
        public void getusr_id(string id)
        {
            this.lbl_usr.Text = id;
        }
    }
}
