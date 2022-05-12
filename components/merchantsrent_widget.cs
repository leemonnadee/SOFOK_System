using MySql.Data.MySqlClient;
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
    public partial class merchantsrent_widget : UserControl
    {
        double total;
       public static double finaltot;
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        private double _cost;
        private double _id;
        public merchantsrent_widget()
        {
            InitializeComponent();
        }

        public String StoreName { get => lbl_storename.Text; set => lbl_storename.Text = value; }
        public String Merchant_Name { get => lbl_merchantname.Text; set => lbl_merchantname.Text = value; }
        // public String Available_prod { get => lbl.Text; set => lbl_prod_Number.Text = value; }
    
        public Image Icon { 
           get => img.Image; set => img.Image = value;
          
        
        }
        public double ID { get => _id; set { _cost = value; lbl_id.Text = _cost.ToString(); } }

        // INSERT INTO `tbl_rent`(`rent_id`, `merchant_id`, `monthy_rent`, `rent_recieve`, `status`, `total_amount`, `month`) VALUES('','[value-2]','[value-3]', CURRENT_DATE(),'[value-5]','[value-6]', MONTHNAME(CURRENT_DATE))


        //pending items
        //

        public void rent_next() {
            try
            {

                string query2 = "SELECT date((DATE_ADD(rent_recieve, INTERVAL 30 DAY))) FROM tbl_rent GROUP BY merchant_id";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();
                while (myreaderfetch.Read()) {

                    rent_lbl.Text = myreaderfetch.GetDateTime("date((DATE_ADD(rent_recieve, INTERVAL 30 DAY)))").ToString("MMM dd,yyyy");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        public void test() {
            try
            {

                string query2 = "SELECT *  FROM `tbl_rent` WHERE CURRENT_DATE()=DATE_ADD(rent_recieve, INTERVAL 30 DAY) ";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();
                if (myreaderfetch.Read())
                {
                    insert_rent();
               

                }
                else {

                    MessageBox.Show("Rent Already Paid", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        

    }

        public void sum()
        {
            try
            {

                string query2 = "SELECT SUM(monthy_rent) FROM `tbl_rent` INNER JOIN tbl_merchant on tbl_rent.merchant_id=tbl_merchant.merchant_id  WHERE tbl_rent.merchant_id='" + lbl_id.Text + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();

               
                    while (myreaderfetch.Read())
                {
                    
                         total = myreaderfetch.GetDouble("SUM(monthy_rent)");
                   
                        total_merch.Text = (total.ToString());

                    finaltot=total = +total;

                }

               
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


        }


        public void insert_rent()
        {
            

            string query2 = "INSERT INTO `tbl_rent`(`rent_id`, `merchant_id`, `monthy_rent`, `rent_recieve`, `status`, `month`,`year`) VALUES('','" + lbl_id.Text+ "','3500', CURRENT_DATE(),'paid', MONTHNAME(CURRENT_DATE),year(CURRENT_DATE))";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();

            MessageBox.Show("Rent Paid successfully", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);


            conn.Close();



        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            test();
            //check_month();


        }

        private void merchantsrent_widget_Load(object sender, EventArgs e)
        {
            
            sum();
            //test();
            rent_next();
        

        }
    }

}
