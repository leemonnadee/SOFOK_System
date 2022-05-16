using MySql.Data.MySqlClient;
using SOFOK_System.components;
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
    public partial class merchantorders : Form
    {
        string mycon = "datasource='" + connection.ipconnection + "';username=root;password=123456;database=sofok_db";

        public merchantorders()
        {
            InitializeComponent();
        }
        public class orderDisply
        {
            public static int costumer_id;
            public static string payment;
            public static string seat_ar;

        }

        public void Add_orderList(double cost, String mod, int id,string seat)
        {
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;


            var w = new orderwidget()
            {

                Mod_payment = mod,
                Cost = cost,
                Seat=seat,


                ID = id
            };
            flowlayout_orders.Controls.Add(w);

        }


        public void view_costumer_Order()
        {
            string query2 = "SELECT *,SUM(cost)FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_products.merchant_id='"+loginform.UserDisplay.MerchantID+ "' and tbl_orders.status='pending' GROUP BY tbl_orders.costumer_id";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            //merchant_list.merchantDisplay.merch_id;
            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                orderDisply.costumer_id = myreaderfetch.GetInt32("costumer_id");
                 orderDisply.payment = myreaderfetch.GetString("payment");
                orderDisply.seat_ar = myreaderfetch.GetString("order_action");

                double price_prod = myreaderfetch.GetDouble("SUM(cost)");

                Add_orderList(price_prod, orderDisply.payment, orderDisply.costumer_id, orderDisply.seat_ar);


            }
        }
            private void merchantorders_Load(object sender, EventArgs e)
        {
            view_costumer_Order();
   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1;
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }
    }
}
