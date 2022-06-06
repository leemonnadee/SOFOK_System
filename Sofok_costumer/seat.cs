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

        decimal b = 0;

        public seat()
        {
            InitializeComponent();
            serialPort1.Open();

        }
        public void detect()
        {

            try
            {                
                //BUTTON READS DATE, INSERTS IN STRING ARRAY strarr, DATA SEPERATED WITH "-"
                string indata = serialPort1.ReadExisting();
                var str = indata;
                char[] seperator = { '-' };
                string[] strarr = null;
                strarr = str.Split(seperator);

                int a = 0;
                //changes color indicators
                //SENSOR 1
                int sensordata = Int32.Parse(strarr[0]);
                if (sensordata < 35)
                {
                    bunifuPanel2.BackgroundColor = Color.LightCoral;
                    a++;

                }
                else
                {
                    bunifuPanel2.BackgroundColor = Color.LimeGreen;
                    a--;
                }

                //SENSOR 2
                sensordata = Int32.Parse(strarr[1]);
                if (sensordata < 30)
                {
                    bunifuPanel3.BackgroundColor = Color.LightCoral;
                    a++;
                    //await Task.Delay(5000);
                    //Thread.Sleep(5000);
                }
                if (sensordata > 30)
                {
                    bunifuPanel3.BackgroundColor = Color.LimeGreen;
                    a--;
                }

                //SENSOR 3
                sensordata = Int32.Parse(strarr[2]);
                if (sensordata < 35)
                {
                    bunifuPanel4.BackgroundColor = Color.LightCoral;
                    a++;
                }
                else
                {
                    bunifuPanel4.BackgroundColor = Color.LimeGreen;
                    a--;
                }


                //SENSOR 4
                sensordata = Int32.Parse(strarr[3]);
                if (sensordata < 30)
                {
                    bunifuPanel5.BackgroundColor = Color.LightCoral;
                    a++;
                }
                else
                {
                    bunifuPanel5.BackgroundColor = Color.LimeGreen;
                    a--;
                }



                //Dine in dissabler
                if (a == 4)
                {

                    dine_in.Enabled = false;

                }
                else
                {

                    dine_in.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                
            }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == 0)
            {
                b = 1;
                detect();
                
            }
            else if (b == 1)
            {
                b = 0;
                detect();
                

            }
            else if (b == 2)
            {
                b = 0;
                detect();
                

            }

        }
    }
}
