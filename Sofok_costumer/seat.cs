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
    public partial class seat : Form
    {
    
    
        public seat()
        {
            InitializeComponent();

        }

        public class seatDisplay { 
        
        public static String Seat_availability;
    }

        public void seat_close() { 
        this.Hide();
        }

        private void dine_in_Click(object sender, EventArgs e)
        {
            choosepayment cp = new choosepayment();
            cp.Show();
        
           
            seatDisplay.Seat_availability = "Dine In";

           
        }

        private void dine_out_Click(object sender, EventArgs e)
        {
            choosepayment cp = new choosepayment();
            cp.Show();


            seatDisplay.Seat_availability = "Dine Out";
         
        }

        public void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void seat_Load(object sender, EventArgs e)
        {
            if (choosepayment.MOD_payment.close == "close")
            {

                this.Hide();
            }
            else { 
            }
        }
    }
}
