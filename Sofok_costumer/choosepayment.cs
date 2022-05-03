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
    public partial class choosepayment : Form
    {

        public String mod_payment;
     
        public choosepayment()
        {
            InitializeComponent();
            frm_transparent();


        }
        public void frm_transparent() {
           this.BackColor = Color.DarkOrange;
            this.TransparencyKey = Color.DarkOrange;
            

        }

        private void btn_gcash_Click(object sender, EventArgs e)
        {
            mod_payment = "gcash";
            frmMain fm = new frmMain();
            fm.Show();
            seat st = new seat();
            st.Hide();
            this.Hide();
         
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            mod_payment = "cashier";
            frmMain fm = new frmMain();
            fm.Show();
            seat st = new seat();
            st.Hide();
            this.Hide();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
