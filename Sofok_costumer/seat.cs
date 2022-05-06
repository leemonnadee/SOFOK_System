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

      

        private void dine_in_Click(object sender, EventArgs e)
        {
        choosepayment cp=new choosepayment();
            cp.Show();
            this.Hide();

            seatDisplay.Seat_availability = "Dine In";

           
        }

        private void dine_out_Click(object sender, EventArgs e)
        {
            choosepayment cp = new choosepayment();
            cp.Show();
            this.Hide();


            seatDisplay.Seat_availability = "Dine Out";
         
        }
    }
}
