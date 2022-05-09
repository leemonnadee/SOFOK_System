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
        
        //to add image in /sofok/bin/debug/icons
        public void addImage()
        {
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;

            System.IO.File.Copy(pathIMG, Path.Combine(imgPath, Path.GetFileName(pathIMG)), true);
       
        }

        //Add Product
        public void addproduct()
        {

            if (productnametxt.Text == "" || prodpricetxt.Text == "")
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
                            "('','" + productnametxt.Text + "','" + combo_category.Text + "','" + prodpricetxt.Text + "','" + loginform.UserDisplay.MerchantID + "','" + ImgFile + "')";
                        MySqlConnection conn = new MySqlConnection(mycon);
                        MySqlCommand mycommand = new MySqlCommand(query, conn);
                        MySqlDataReader myreader1;



                        conn.Open();
                        //cm = new MySqlCommand("insert into tbl_products(`prod_id`, `prod_name`, `product_category`, `prod_price`, `merchant_id`,product_icon)value('','" + productnametxt.Text + "','" + prodcategtxt.Text + "','" + prodpricetxt.Text + "','" + 1 + "',@product_icon)");

                        myreader1 = mycommand.ExecuteReader();
                        addImage();

                        clear();
                        productflowlayout.Controls.Clear();
                        displayProductsAll();
                        MessageBox.Show("Successfully Added", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);







                        conn.Close();

                        //conn.Close();

                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
            }
        }



        //For upload Image
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


        //Load Screen
        private void merchantproducts_Load(object sender, EventArgs e)
        {
          
            lbl_merchantname.Text = loginform.UserDisplay.merchantName;

            displayProductsAll();
            combo_category.SelectedIndex = 0;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            /*
            //string filePath = System.IO.Path.GetFullPath("");
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            MessageBox.Show(imgPath);
            var a=test.Text = imgPath;
            var s = "coke.png";
            productpic.Image = Image.FromFile(imgPath+@"\"+s);
        

            */

        }
        public void clear() {

            productpic.Image = Properties.Resources.tableware_100px;
            productflowlayout.Controls.Clear();
            productnametxt.Clear();
            prodpricetxt.Clear();
        }
        //Insert Btn
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            var ImgFile = Path.GetFileName(pathIMG);
            if (ImgFile == null)
            {
                MessageBox.Show("Please Select Icon", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else {
                checkImg();



            }

            //checkImg();

        }
        public void checkImg()
        {
            try
            {
                var ImgFile = Path.GetFileName(pathIMG);

               
                   
                    string query = "SELECT * FROM `tbl_products` WHERE `merchant_id`='"+loginform.UserDisplay.MerchantID+"' and `product_icon`='"+ ImgFile + "'";

                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataReader myreader1;
                conn.Open();
                //execute the query
                myreader1 = mycommand.ExecuteReader();
                if (myreader1.Read())
                {


                    MessageBox.Show("Icon Already Exist , \n Try Again!", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    displayProductsAll();

                }
                else {

                    addproduct();

                }
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        
        }


        /*
        public void prod_data()
        {

            try
            {

                string query = "SELECT tbl_products.prod_id,tbl_products.prod_name,tbl_products.product_category,tbl_products.prod_price,tbl_products.product_icon,tbl_merchant.merchant_store FROM tbl_products INNER JOIN tbl_merchant ON tbl_products.merchant_id = tbl_merchant.merchant_id  WHERE tbl_products.merchant_id = '" + loginform.UserDisplay.MerchantID + "' ";

                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                prod_table.DataSource = dtable;
                myadapter.Fill(dtable);






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */






        private void merchantproduct_main_Shown(object sender, EventArgs e)
        {




        }

        //Remove Btn 
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
                String imgPath = DI.FullName;

                System.IO.File.Copy(pathIMG, Path.Combine(imgPath, Path.GetFileName(pathIMG)), true);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void prodpricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }




        public void addproduct(String name, double cost, categories category, String icon, String store, int id)
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
            productflowlayout.Controls.Add(w);
           

            w.OnSelect += (ss, ee) =>
            {
                uploadbtn.Visible = false;
                var wgd = (widget)ss;
                prodpricetxt.Text=wgd.lbl_Price.Text.Remove(0, 1);
                productnametxt.Text=wgd.lbl_Title.Text;
                prod_ID.Text = wgd.lbl_ID.Text;
                lbl_merchantname.Text = wgd.lbl_store.Text;
                combo_category.Text=wgd.Category.ToString();
                System.IO.DirectoryInfo s = new System.IO.DirectoryInfo("icons");
                String imgPath2 = s.FullName;


                productpic.Image = wgd.img.Image;

                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                save_btn.Enabled = false;



            };





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
                String merchant_store = myreaderfetch.GetString("merchant_store");
                String store_name = myreaderfetch.GetString("merchant_store");
                double price_prod = myreaderfetch.GetDouble("prod_price");
                int prod_id = myreaderfetch.GetInt32("prod_id");
                String icon = myreaderfetch.GetString("product_icon");

                if (cat.Equals("Meal"))
                {

                    addproduct(prod_name, price_prod, categories.meal, icon, store_name, prod_id);
                }
                else if (cat.Equals("Drink"))
                {
                    addproduct(prod_name, price_prod, categories.drink, icon, store_name, prod_id);

                }
                else if (cat.Equals("Burger"))
                {
                    addproduct(prod_name, price_prod, categories.burger, icon, store_name, prod_id);
                }



            }

        }

        private void btn_meals_Click(object sender, EventArgs e)
        {
            foreach (var item in productflowlayout.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.Category.Equals(categories.meal);



            }
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            foreach (var item in productflowlayout.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.Category.Equals(categories.drink);



            }
        }

        private void btn_burgers_Click(object sender, EventArgs e)
        {
            foreach (var item in productflowlayout.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.Category.Equals(categories.burger);



            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Opacity = 1;
            docker.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        private void allproductsbtn_Click(object sender, EventArgs e)
        {

            foreach (var item in productflowlayout.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.Category.Equals(categories.burger) || wgd.Category.Equals(categories.drink) || wgd.Category.Equals(categories.meal) || wgd.Category.Equals(categories.drink);
            }
        }

        private void txt_srch_TextChange(object sender, EventArgs e)
        {
            foreach (var item in productflowlayout.Controls)
            {

                var wgd = (widget)item;
                wgd.Visible = wgd.lbl_Title.Text.ToLower().Contains(txt_srch.Text.Trim().ToLower());

            }
        }

        public void deleteProduct() {

            try
            {


                string query = "DELETE FROM `tbl_products` WHERE `prod_id`='" + prod_ID.Text + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                conn.Close();

              

                productflowlayout.Controls.Clear();
                displayProductsAll();
                MessageBox.Show("Delete Complete", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void btn_delete_Click(object sender, EventArgs e)
        {



            //DELETE FROM `tbl_products` WHERE `prod_id`=
            if (prodpricetxt.Text.Equals("") ||
                productnametxt.Text.Equals(""))
              

            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Account?", "Delete", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    clear();
                    deleteProduct();
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    save_btn.Enabled = true;
                    uploadbtn.Visible = true;
                }
            }

        }


        public void update_prod() {

            // 

            try
            {
               

       
                double price = Double.Parse(prodpricetxt.Text);
                


                string query = "UPDATE `tbl_products` SET `prod_name`= '"+ productnametxt.Text+"',`product_category`= '"+combo_category.Text+"',`prod_price`= '"+price+"',`merchant_id`= '"+loginform.UserDisplay.MerchantID+"' WHERE prod_id='"+prod_ID.Text+"'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);


              
                MySqlDataReader myreader1;

                conn.Open();
                clear();

                myreader1 = mycommand.ExecuteReader();
                conn.Close();
                uploadbtn.Enabled = true;



                productflowlayout.Controls.Clear();
                displayProductsAll();
                MessageBox.Show("Update Complete Complete", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (prodpricetxt.Text.Equals("") ||
                   productnametxt.Text.Equals(""))


            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 



            update_prod();
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                uploadbtn.Visible = true;
                save_btn.Enabled = true;
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
