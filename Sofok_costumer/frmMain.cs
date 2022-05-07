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
using static SOFOK_System.components.widget;

namespace SOFOK_System
{
    public partial class frmMain : Form
    { string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        //MySqlCommand cm;
        String prod_name;
        private static bool Enable;
        public static int costumer_id;
     
        public frmMain()
        {
        
            InitializeComponent();
            All.BackColor = Color.PeachPuff;
            CalculateTotal();
            lbl_tot.Text.Equals("₱ 0.00");
           




    }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1;
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }
      
        
        
        public  void AddItem(String name, double cost, categories category , String icon, String store, int id) {
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
            pn1.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
                var wgd = (widget)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wgd.lbl_Title.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wgd.lbl_Price.Text.Replace("₱", ""))).ToString("C2");
                        item.Cells[3].Value = store;
                        item.Cells[4].Value = id;
                        CalculateTotal();
                        return;
                    }
                    
                }
               
                grid.Rows.Add(new object[] { wgd.lbl_Title.Text, 1, wgd.lbl_Price.Text,store,id });
                
                CalculateTotal();



            };


        }










        void CalculateTotal() {

            double tot = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("₱", ""));

                lbl_tot.Text = tot.ToString("C2");

            }
        }
        public void displayProductsAll()
        {
            try
            {

        
            string query2 = "SELECT tbl_products.prod_id,tbl_products.prod_name,tbl_products.product_category,tbl_products.prod_price,tbl_products.product_icon,tbl_merchant.merchant_store FROM tbl_products INNER JOIN tbl_merchant ON tbl_products.merchant_id = tbl_merchant.merchant_id WHERE tbl_products.merchant_id='"+merchant_list.merchantDisplay.merch_id+"'";
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

                    AddItem(prod_name, price_prod, categories.meal, icon, store_name, prod_id);
                }
                else if (cat.Equals("Drink"))
                {
                    AddItem(prod_name, price_prod, categories.drink, icon, store_name, prod_id);

                }
                else if (cat.Equals("Burger"))
                {
                    AddItem(prod_name, price_prod, categories.burger, icon, store_name, prod_id);
                }








            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

            displayProductsAll();
          
            
        }
        private void txt_srch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in pn1.Controls) {

                var wgd = (widget)item;
                wgd.Visible = wgd.lbl_Title.Text.ToLower().Contains(txt_srch.Text.Trim().ToLower());
            
            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            All.BackColor = Color.PeachPuff;
            btn_meal.BackColor = Color.Transparent;
            btn_drinks.BackColor = Color.Transparent;
            btn_burger.BackColor = Color.Transparent;


            foreach (var item in pn1.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.Category.Equals(categories.burger) || wgd.Category.Equals(categories.drink)|| wgd.Category.Equals(categories.meal) || wgd.Category.Equals(categories.drink);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            All.BackColor = Color.Transparent;
            btn_meal.BackColor = Color.PeachPuff;
            btn_drinks.BackColor = Color.Transparent;
            btn_burger.BackColor = Color.Transparent;
            foreach (var item in pn1.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible =  wgd.Category.Equals(categories.meal) ;



            }
        }

        private void btn_drinks_Click(object sender, EventArgs e)

        {
            All.BackColor = Color.Transparent;
            btn_meal.BackColor = Color.Transparent;
            btn_drinks.BackColor = Color.PeachPuff;
            btn_burger.BackColor = Color.Transparent;
            foreach (var item in pn1.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.Category.Equals(categories.drink);



            }
        }

        private void btn_burger_click(object sender, EventArgs e)
        {
            All.BackColor = Color.Transparent;
            btn_meal.BackColor = Color.Transparent;
            btn_drinks.BackColor = Color.Transparent;
            btn_burger.BackColor = Color.PeachPuff;
            foreach (var item in pn1.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.Category.Equals(categories.burger);



            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            widget w = new widget();

            /*

            foreach (DataGridViewRow item in grid.Rows)
            {
                item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) - 1;




            }
            */
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                int selectedrowindex = grid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[2].Value);
                double a = double.Parse(cellValue.Replace("₱", "").ToString())/ int.Parse(row.Cells[1].Value.ToString());
                double b = double.Parse(cellValue.Replace("₱", "").ToString()) - a;
              




           

                grid.Rows[e.RowIndex].Cells[1].Value= int.Parse(row.Cells[1].Value.ToString()) - 1;
                grid.Rows[e.RowIndex].Cells[2].Value = "₱" + b;
                CalculateTotal();
             
                if (int.Parse(grid.Rows[e.RowIndex].Cells[1].Value.ToString()) <= 0)
                {
                    grid.Rows.RemoveAt(row.Index);
               
                    MessageBox.Show("Item Remove", "Order List");
                
                }

            }









        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            
            grid.Rows.Clear();
            lbl_tot.Text = "₱0.00";
        
            }

        private void btn_back_Click(object sender, EventArgs e)
        {
            merchant_list ml = new merchant_list();

           ml.Show();
            this.Hide();
        }
      
        public void save_data() {

            //grid
            try
            {
                
                   
                for (int i = 0; i <=grid.RowCount-1; i++)
                {
                    String item = grid.Rows[i].Cells[0].Value.ToString();
                    int qty = (int)grid.Rows[i].Cells[1].Value;
                    String cost = grid.Rows[i].Cells[2].Value.ToString();
                    String store = grid.Rows[i].Cells[3].Value.ToString();
                    int prod_id = (int)grid.Rows[i].Cells[4].Value;

                    double final_cost = Double.Parse(cost.Remove(0, 1));


                

                    string query = "INSERT INTO `tbl_orders`(`order_id`, `item`, `qty`, `cost`, `store`, `prod_id`,`order_action`,`payment`,`status`,`costumer_id`) VALUES ('','" + item + "','" + 2 + "','" + final_cost+ "','" + store + "','" + prod_id + "','"+seat.seatDisplay.Seat_availability+"','"+choosepayment.MOD_payment.mod_payment+"','pending','"+costumer_id+"')";
                
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);



                    MySqlDataReader myreader1;

                    conn.Open();

                    myreader1 = mycommand.ExecuteReader();
                    conn.Close();



                  
                   
                }

               
                 lbl_tot.Text=("₱0.00");
                grid.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void get_costumerID() {

            string query2 = "SELECT * FROM `tbl_costumer`  ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                costumer_id = myreaderfetch.GetInt32("costumer_id");



            }

            save_data();


        }
        public void buy() {
        
            try
            {



                string query = "INSERT INTO `tbl_costumer`(`costumer_id`, `date`) VALUES ('',CURRENT_DATE)";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();

                get_costumerID();
             
              
                choosepayment cp = new choosepayment();
                cp.Hide();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        private void pay_btn_Click(object sender, EventArgs e)
        {


           

                        if (lbl_tot.Text.Equals("₱0.00")|| (lbl_tot.Text.Equals("")))
                        {
                            MessageBox.Show("Select Item First", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else {
                           buy();
               
              

                        }


                       


           



        }
        public void enableB() {
          
            this.Opacity = 1;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txt_srch.Visible = false;
        }
    }



        }
    

