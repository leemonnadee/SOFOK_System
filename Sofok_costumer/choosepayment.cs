using SOFOK_System.Sofok_costumer;
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

        
     
        public choosepayment()
        {
            InitializeComponent();
            frm_transparent();


        }
        public void frm_transparent() {
           this.BackColor = Color.DarkOrange;
            this.TransparencyKey = Color.DarkOrange;
            

        }
        public class MOD_payment {

            public static String mod_payment;
            public static String close;

        }
    
        public void btn_gcash_Click(object sender, EventArgs e)
        {
            MOD_payment.mod_payment = "gcash";
            merchant_list ml = new merchant_list();
            MOD_payment.close = "close";
         ml.Show();


     
            this.Hide();
          
           
           
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            MOD_payment.mod_payment = "cashier";

            merchant_list ml = new merchant_list();
            MOD_payment.close = "close";
            ml.Show();
            this.Hide();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
