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
using static SOFOK_System.components.widget;
using System.IO;
using Magnum.FileSystem;

namespace SOFOK_System
{
    
    public partial class merchantproduct_main : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        //MySqlCommand cm;
        String prod_name;
         String pathIMG;
     
        public merchantproduct_main()
        {
            InitializeComponent();
            widget w = new widget();


        }
        public void addproduct()
        {

            if (productnametxt.Text == "" || prodpricetxt.Text == "" )
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                try
                {

                    var ImgFile = Path.GetFileName(pathIMG);
                    double price = double.Parse(prodpricetxt.Text);
             

                    String query = "INSERT INTO `tbl_products`" +
                        "(`prod_id`, `prod_name`, `product_category`, `prod_price`, `merchant_id`, `product_icon`) VALUES " +
                        "('','"+productnametxt.Text+"','"+c.Text+"','"+prodpricetxt.Text+"','"+lbl_merchant_id.Text+ "','"+ ImgFile + "')"; 
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlDataReader myreader1;



                    conn.Open();
                    //cm = new MySqlCommand("insert into tbl_products(`prod_id`, `prod_name`, `product_category`, `prod_price`, `merchant_id`,product_icon)value('','" + productnametxt.Text + "','" + prodcategtxt.Text + "','" + prodpricetxt.Text + "','" + 1 + "',@product_icon)");
               
                    myreader1 = mycommand.ExecuteReader();
                    productflowlayout.Controls.Clear();
                    displayProductsAll();

                 


                    conn.Close();

                    //conn.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


      

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            //upload photo

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Photo";
            open.Filter = "Image Files(*.png; *.jpeg; *.JPG;)|*.png;*.jpeg;*.JPG;";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 pathIMG = open.FileName;
                productpic.Image = new Bitmap(open.FileName);
            }
      

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void merchantproducts_Load(object sender, EventArgs e)
        {
            lbl_merchant_id.Text = loginform.UserDisplay.MerchantID;
            lbl_merchantname.Text = loginform.UserDisplay.merchantName;

            c.SelectedIndex = 0;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

         
           addproduct();
       
            productnametxt.Clear();
            prodpricetxt.Clear();
         
        }
        public void addproduct(String name, double cost, categories category, String icon, String store, int id)
        {
            var w = new widget()
            {

                Title = name,
                Cost = cost,
                Category = category,


                Icon = Image.FromFile("icons/" + icon),
                Store = store,
                ID = id
            };
            productflowlayout.Controls.Add(w);




        }


        public void displayProductsAll()
        {
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
                String Testicon = myreaderfetch.GetString("product_icon");

                MessageBox.Show(Testicon);
                addproduct(prod_name, price_prod, categories.burger, store_name, prod_id);

            }

        }
    

  





private void merchantproduct_main_Shown(object sender, EventArgs e)
        {


            displayProductsAll();

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Copy(pathIMG, Path.Combine(@"C:\Users\RL\Documents\GitHub\SOFOK_System\icons\", Path.GetFileName(pathIMG)), true);
                MessageBox.Show(pathIMG);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
         
            
        }

        private void txt_srch_TextChange(object sender, EventArgs e)
        {
            foreach (var id in productflowlayout.Controls)
            {

                var wgd = (widget)id;
                wgd.Visible = wgd.lbl_ID.Text.ToLower().Contains(txt_srch.Text.Trim().ToLower());

            }
        }
    }

}
