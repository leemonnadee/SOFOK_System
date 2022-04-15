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
    public partial class seat : Form
    {
        public seat()
        {
            InitializeComponent();

        }

       

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            choosepayment fr = new choosepayment();
            fr.Show();
            this.Hide();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            choosepayment fr = new choosepayment();
            fr.Show();
            this.Hide();
        }
    }
}
