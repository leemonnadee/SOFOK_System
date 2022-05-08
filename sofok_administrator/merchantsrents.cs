using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFOK_System
{
    public partial class merchantsrents : Form
    {
        public merchantsrents()
        {
            InitializeComponent();
        }

        

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            time.Text = DateTime.Now.ToString("hh:m:s tt");
            timer1.Start();
        }

        private void merchantsrents_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:m tt");
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            timer1.Start();
        }
    }
}
