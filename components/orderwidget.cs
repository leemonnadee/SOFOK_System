using MySql.Data.MySqlClient;
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
using static SOFOK_System.components.widget;

namespace SOFOK_System.components
{
    public partial class orderwidget : UserControl
    {

        string mycon = connection.ipconnection;
        //MySqlCommand cm;
        private int _id;
        String prod_name;
        private double _cost;
        public orderwidget()
        {
            InitializeComponent();
        }

        private void servebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Serve order?", "SERVE", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                serve();
            }
        }
        public void serve() {
            try
            {

                string query2 = "UPDATE `tbl_orders` SET `status`='accepted' WHERE tbl_orders.costumer_id='" + lbl_oder_num.Text + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                //merchant_list.merchantDisplay.merch_id;
                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();

                MessageBox.Show("Order Served Complete ! \n Thank you ");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void serve_decline()
        {
            try
            {

                string query2 = "UPDATE `tbl_orders` SET `status`='decline' WHERE tbl_orders.costumer_id='" + lbl_oder_num.Text + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                //merchant_list.merchantDisplay.merch_id;
                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();

                MessageBox.Show("Decline Complete");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void orderwidget_Load(object sender, EventArgs e)
        {
            displayProductsAll();
        }




        public void AddOrder(String name, double cost, categories category, String icon, String store, int id)
        {
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;

            var w = new widget()
            {

                Title = name,
                Cost = cost,
                Category = category,


                Icon = Image.FromFile(imgPath + @"\" + icon),
                Store = store,
                ID = id
            };
            ordersPanel.Controls.Add(w);

        }
            public void displayProductsAll()
        {
            try
            {


                string query2 = "SELECT tbl_products.prod_id,tbl_products.prod_name,tbl_products.product_category,tbl_products.prod_price,tbl_products.product_icon,tbl_merchant.merchant_store  FROM tbl_orders INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id INNER JOIN tbl_merchant ON tbl_merchant.merchant_id=tbl_products.merchant_id WHERE tbl_orders.costumer_id='"+merchantorders.orderDisply.costumer_id+"'";
                    MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();
                while (myreaderfetch.Read())
                {
                    prod_name = myreaderfetch.GetString("prod_name");
                    String cat = myreaderfetch.GetString("product_category");
                    String icon = myreaderfetch.GetString("product_icon");
                    String store_name = myreaderfetch.GetString("merchant_store");
                    double price_prod = myreaderfetch.GetDouble("prod_price");
                    int prod_id = myreaderfetch.GetInt32("prod_id");


                    if (cat.Equals("Meal"))
                    {

                        AddOrder(prod_name, price_prod, categories.meal, icon, store_name, prod_id);
                    }
                    else if (cat.Equals("Drink"))
                    {
                        AddOrder(prod_name, price_prod, categories.drink, icon, store_name, prod_id);

                    }
                    else if (cat.Equals("Burger"))
                    {
                        AddOrder(prod_name, price_prod, categories.burger, icon, store_name, prod_id);
                    }







                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }








        public String Seat { get => lbl_seat.Text; set => lbl_seat.Text = value; }
        public double Cost { get => _cost; set { _cost = value; lbl_Price.Text = _cost.ToString("C2"); } }
        public String Mod_payment { get => lbl_mod_payment.Text; set => lbl_mod_payment.Text = value; }

        public int ID { get => _id; set { _cost = value; lbl_oder_num.Text = _cost.ToString(); } }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to decline this order?", "Decline Order", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                serve_decline();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
    }
