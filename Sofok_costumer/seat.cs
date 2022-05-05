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
        public String Seat_availability;
    
        public seat()
        {
            InitializeComponent();

        }
     
       

      

        private void dine_in_Click(object sender, EventArgs e)
        {
            Sofok_costumer.merchant_list fr = new Sofok_costumer.merchant_list();
            fr.Show();
            this.Hide();
           
            Seat_availability = "Dine In";
            
 
        }

        private void dine_out_Click(object sender, EventArgs e)
        {
            Sofok_costumer.merchant_list fr = new Sofok_costumer.merchant_list();
            fr.Show();
            this.Hide();
           
         
            Seat_availability = "Dine Out";
         
        }
    }
}
