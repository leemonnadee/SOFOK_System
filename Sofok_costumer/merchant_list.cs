using MySql.Data.MySqlClient;
using SOFOK_System.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFOK_System.Sofok_costumer
{
    public partial class merchant_list : Form
    {
        string mycon = "datasource='" + connection.ipconnection + "';username=root;password=123456;database=sofok_db";
        public merchant_list()
        {
            InitializeComponent();

        }
        public class merchantDisplay
        {

            public static double merch_id;
            public static string merch_name;
            public static string merch_store;
        }





        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1;
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }




        public void AddMerchant_List(String storename, String merchant, String prod, double id)
        {



            var w = new merchant_widget()
            {

                StoreName = storename,
                Merchant_Name = merchant,
                Available_prod = prod,



                ID = id
            };
            merchant_widget.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
              
                var merch = (merchant_widget)ss;
                merchant_list.merchantDisplay.merch_id = id;
                merchant_list.merchantDisplay.merch_store = merch.StoreName;
                merchant_list.merchantDisplay.merch_name = merch.Merchant_Name;


                frmMain fr = new frmMain();
                fr.Show();
                this.Hide();



            };







        }

     

    public void displayProductsAll()
        {
            try
            {

                String query2= "SELECT tbl_merchant.name,tbl_merchant.merchant_store,tbl_merchant.merchant_id,COUNT(*) FROM `tbl_products` INNER JOIN tbl_merchant ON tbl_products.merchant_id=tbl_merchant.merchant_id WHERE tbl_merchant.status='active' AND tbl_products.status='active' GROUP BY tbl_products.merchant_id";
               // string query2 = "SELECT tbl_merchant.name,tbl_merchant.merchant_store,tbl_merchant.merchant_id FROM `tbl_products` INNER JOIN tbl_merchant ON tbl_products.merchant_id=tbl_merchant.merchant_id;";
                MySqlConnection conn = new MySqlConnection(mycon);

                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();
                while (myreaderfetch.Read())
                {
                   
                    String name = myreaderfetch.GetString("name");

                    String items = myreaderfetch.GetString("COUNT(*)");
                    String store_name = myreaderfetch.GetString("merchant_store");
                    int id = myreaderfetch.GetInt32("merchant_id");

                    AddMerchant_List(store_name, name, items, id);
                  
                
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}


    private void merchant_list_Load(object sender, EventArgs e)
        {
              displayProductsAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seat st = new seat();
            st.Show();
            this.Hide();
            
        }
    }

}