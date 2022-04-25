﻿using MySql.Data.MySqlClient;
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
using static SOFOK_System.components.widget;

namespace SOFOK_System
{
    public partial class frmMain : Form
    { string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        //MySqlCommand cm;
        String prod_name;
        private static bool Enable;

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
      
        
        
        public  void AddItem(String name, double cost, categories category, String icon, String store, int id) {

            var w = new widget()
            {

                Title = name,
                Cost = cost,
                Category = category,


                Icon = Image.FromFile("icons/" + icon),
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

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            
            }
            string query2 = "SELECT * FROM tbl_products INNER JOIN tbl_merchant ON tbl_products.merchant_id = tbl_merchant.merchant_id  WHERE tbl_products.merchant_id = '" + loginform.UserDisplay.MerchantID + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                prod_name = myreaderfetch.GetString("prod_name");
                String cat = myreaderfetch.GetString("product_category");

                String store_name = myreaderfetch.GetString("merchant_store");
                double price_prod = myreaderfetch.GetDouble("prod_price");
                int prod_id = myreaderfetch.GetInt32("prod_id");





                AddItem(prod_name, price_prod, categories.burger, "coke.png", store_name, prod_id);
            }

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {


            AddItem("name",32, categories.burger, "coke.png", "store", 21);

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

        private void button1_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            lbl_tot.Text = "₱ 0.00";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            seat st = new seat();
            st.Show();
            this.Hide();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            if (lbl_tot.Text.Equals("₱ 0.00"))
            {

            }
            else {
                choosepayment cp = new choosepayment();
                cp.Show();

            }
            
            
           
          
        



        }
    public void enableB() {
          
            this.Opacity = 1;
        }
    }



        }
    

