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
    public partial class merchantsrents : Form
    {
        string mycon = "datasource=192.168.100.201;username=root;password=123456;database=sofok_db";
        public merchantsrents()
        {
            InitializeComponent();
        }

        public void total_rent() {
            try
            {

                string query = "SELECT count(*) FROM `tbl_merchant`";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);




                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String total_product = myreader1.GetString("count(*)");
                    lbl_merchant_no.Text = total_product;


                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void merchant_number() {
            try
            {

                string query = "SELECT count(*) FROM `tbl_merchant`";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);




                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String total_product = myreader1.GetString("count(*)");
                    lbl_merchant_no.Text = total_product;


                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }


        public void merchant_list(String storename, String merchant,String icon, double id)
        {

            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;


            var w = new merchantsrent_widget()
            {

                StoreName = storename,
                Merchant_Name = merchant,
                Icon = Image.FromFile(imgPath + @"\" + icon),




                ID = id
            };
            rent_flow.Controls.Add(w);

     






        }
        public void merchant_list_no_img(String storename, String merchant, double id)
        {

            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;


            var w = new merchantsrent_widget()
            {

                StoreName = storename,
                Merchant_Name = merchant,
            




                ID = id
            };
            rent_flow.Controls.Add(w);








        }
        public void display_merchants()
        {
            try
            {


                string query2 = "SELECT * FROM `tbl_merchant`";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();
                while (myreaderfetch.Read())
                {

                    String merchant_name = myreaderfetch.GetString("name");
                    String icon = myreaderfetch.GetString("profile_img");
                    String store_name = myreaderfetch.GetString("merchant_store");
                    int id = myreaderfetch.GetInt32("merchant_id");
                    if (icon.Equals("none"))
                    {
                        merchant_list_no_img(store_name, merchant_name, id);
                    }
                    else { 
                    merchant_list(store_name, merchant_name, icon, id);
                    }

                }








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
            private void merchantsrents_Shown(object sender, EventArgs e)
        {
            merchant_number();
            display_merchants();

            
          


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            this.Opacity = 1;
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            time.Text = DateTime.Now.ToString("hh:m:s tt");
            timer1.Start();
        }

        private void merchantsrents_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:m tt");
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            timer1.Start();

            //string month_name = DateTime.Now.ToString("MMMM");
            //MessageBox.Show(month_name);

        }

      
    }
}
