using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFOK_System
{
    public partial class adminregistermerchant : Form
    {
        //set connection
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        String pathIMG;
        int merchant_id;
        public String gcash_image;
        String checkPath;
        public double rownum;
        string update_imgchech;

        public adminregistermerchant()
        {
            InitializeComponent();

        }
        private void ValidateEmail()
        {
            string email = txt_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                create_acc();

            }
            else
                MessageBox.Show(email + " Invalid email format", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void get_merch_id(){

      string id = "SELECT merchant_id FROM `tbl_merchant` ORDER BY acc_id DESC LIMIT 1";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(id, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read()) {

                merchant_id = myreaderfetch.GetInt32("merchant_id");
            }
            insert_rent();
            conn.Close();

        }
        public void insert_rent()
        {

            string query2 = "INSERT INTO `tbl_rent`(`rent_id`, `merchant_id`, `monthy_rent`,status) VALUES('','" + merchant_id + "','3500','paid')";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            //MessageBox.Show("paid Complete");
            conn.Close();



        }
       

        public void count_acc() {
            try
            {
                string query = "SELECT count(*) FROM tbl_merchant";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader2;

                conn.Open();
                // insert Merchant Data
                myreader2 = mycommand.ExecuteReader();
                while (myreader2.Read())
                {

                    rownum = myreader2.GetDouble("count(*)");
                    
                }

               lbl_Acc_num.Text = "0"+rownum.ToString();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        //show ALl data in table
        public void showalldata()
        {

            try
            {

                string query = "SELECT `merchant_id`, `name`,`merchant_store`,tbl_account.username, tbl_account.acc_id FROM `tbl_merchant` INNER JOIN tbl_account ON tbl_merchant.acc_id=tbl_account.acc_id where tbl_account.log_as='Merchant'";

                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                registerTable.DataSource = dtable;
                myadapter.Fill(dtable);






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        //clear data
            public void clear() {
            txt_merchant.Text = "";
            txt_storename.Text= "";
           
            txt_email.Text = "";
            txt_password.Text = "";
            txt_id.Text = "";
            lbl_id.Text = "";
            QR_img.Image = Properties.Resources.Qr_Code_PNG_Photo;
        


        }


        // Adding merchant 
        public void add_merchant_account()
        {
            if (txt_email.Text != ("") ||
               txt_password.Text != ("") ||
               txt_merchant.Text != ("") ||
               txt_storename.Text != ("")

               )
            {
                try
                {
                    var ImgFile = Path.GetFileName(pathIMG);
                    
                    string query = "INSERT INTO `tbl_merchant`(`merchant_id`, `name` , `marital_status`, `gender`, `contact_no`, `address`, `merchant_store`, `profile_img`,`gcash_img`, `acc_id`) VALUES " +
                                                             "('','" + txt_merchant.Text + "','none','none','none','none','" + txt_storename.Text + "','none','"+ ImgFile + "','" + lbl_id.Text + "')";
                    
                    //string query = "INSERT INTO `tbl_merchant`(`merchant_id`, `name`, `merchant_store`, `acc_id`) VALUES ('','" + txt_merchant.Text + "','" + txt_storename.Text + "','" + lbl_id.Text + "')";
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);



                    MySqlDataReader myreader1;

                    conn.Open();
                    // insert Merchant Data
                    myreader1 = mycommand.ExecuteReader();
                    while (myreader1.Read()) {
                      
                    }
                
                    conn.Close();
                    MessageBox.Show("Successfully Added", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count_acc();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          

        }
        // Adding account
        public void create_acc() {
            if (txt_email.Text != ("")||
                txt_password.Text != ("")||
                txt_merchant.Text != ("")||
                txt_storename.Text != ("")

                )
            {
                try
            {
                    //encryption key
                var key = "b14ca5898a4e4133bbce2ea2315a1916";


                    // set encryption key on password field
                    var str = txt_password.Text;
                var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

             


                    string query = "INSERT INTO `tbl_account`(`acc_id`, `username`, `password`, `log_as`) VALUES ('','" + txt_email.Text + "','" + encryptPassword + "','Merchant')";
                    string id = "SELECT acc_id FROM `tbl_account` ORDER BY acc_id DESC LIMIT 1";

                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlCommand mycommand2 = new MySqlCommand(id, conn);


                    MySqlDataReader myreader1;
                    MySqlDataReader myreader2;


                    conn.Open();
                    //insert for account data
                    myreader1 = mycommand.ExecuteReader();

                    conn.Close();

                    conn.Open();
                    //get ID   
                    myreader2 = mycommand2.ExecuteReader();

                    while (myreader2.Read())
                    {

                         String s = lbl_id.Text = myreader2.GetString("acc_id");
                      
                    }

                    add_merchant_account();
                    get_merch_id();
                    showalldata();

                  
                    clear();

                    conn.Close();








                }
            catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
        }
        else{
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        // delete account

        public void deleteAccount() {
         
                try
                {


                    string query = "DELETE tbl_merchant,tbl_account FROM `tbl_merchant` INNER JOIN  tbl_account ON tbl_merchant.acc_id = tbl_account.acc_id WHERE merchant_id = '" + txt_id.Text+ "';";
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);



                    MySqlDataReader myreader1;

                    conn.Open();

                    myreader1 = mycommand.ExecuteReader();
                    conn.Close();
                  
                    showalldata();
                    save_btn.Enabled = true;
                    clear();
                    MessageBox.Show("Delete Complete", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count_acc();

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                save_btn.Enabled = true;
                clear();
            }
            

        }
        //Load form 
   
        private void adminregistermerchant_Load(object sender, EventArgs e)
        {
            lbl_id.Visible = false;
            txt_id.Visible = false;
            showalldata();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            count_acc();
        }

        //save button
        private void save_btn_Click_1(object sender, EventArgs e)
        {
            var ImgFile = Path.GetFileName(pathIMG);
            if (ImgFile == null)
            {
                MessageBox.Show("Please Select Icon", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                ValidateEmail();
                addImage();


            }



            
        



        }

        public void showImg() {
            try
            {
                string query = "SELECT * FROM `tbl_merchant` WHERE merchant_id='" + txt_id.Text + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    System.IO.DirectoryInfo s = new System.IO.DirectoryInfo("icons");
                    String imgPath2 = s.FullName;

                     gcash_image = myreader1.GetString("gcash_img");
                    checkPath = imgPath2 + @"\" + gcash_image;
                    QR_img.Image = Image.FromFile(checkPath);
                 
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //datagrid item clicked
        private void registerTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.registerTable.Rows[e.RowIndex];
                txt_id.Text = row.Cells["merchant_id"].Value.ToString();
                txt_merchant.Text = row.Cells["name"].Value.ToString();
                txt_storename.Text = row.Cells["merchant_store"].Value.ToString();
                txt_email.Text = row.Cells["username"].Value.ToString();
                lbl_id.Text= row.Cells["acc_id"].Value.ToString();
                showImg();


              

            }
            save_btn.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
        }


        //delete button
        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (txt_email.Text.Equals("") ||
               txt_merchant.Text.Equals("") ||
               txt_storename.Text.Equals(""))
             
            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
            DialogResult result = MessageBox.Show("Do you want to delete this Account?", "Delete", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                deleteAccount();
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    save_btn.Enabled = true;
                }
            }

        }

        public void update_accounts() {
         
                //encryption key
                var key = "b14ca5898a4e4133bbce2ea2315a1916";


                // set encryption key on password field
                var str = txt_password.Text;
                var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);
            var ImgFile = Path.GetFileName(pathIMG);


            try
                {
                    string query = "UPDATE `tbl_account` SET `username`='" + txt_email.Text + "',`password`='" + encryptPassword + "' WHERE acc_id='" + lbl_id.Text + "'";
                
                if (ImgFile == null)
                {
                     update_imgchech = "UPDATE `tbl_merchant` SET `name`='" + txt_merchant.Text + "',`merchant_store`='" + txt_storename.Text + "' WHERE merchant_id='" + txt_id.Text + "'";

                }
                else {
                    update_imgchech = "UPDATE `tbl_merchant` SET `name`='" + txt_merchant.Text + "',`merchant_store`='" + txt_storename.Text + "',`gcash_img`='" + ImgFile + "' WHERE merchant_id='" + txt_id.Text + "'";
                    addImage();

                }



                MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlCommand mycommand2 = new MySqlCommand(update_imgchech, conn);


                    MySqlDataReader myreader1;
                    MySqlDataReader myreader2;

                    conn.Open();
                    myreader2 = mycommand2.ExecuteReader();
                    conn.Close();
                    conn.Open();

                    myreader1 = mycommand.ExecuteReader();

                    conn.Close();
                    clear();
                    showalldata();

                    MessageBox.Show("Update successfully","SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
     
                    MessageBox.Show("Email is already taken", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                save_btn.Enabled = false;
                }
           
        }



        //update btn
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Equals("") ||
          txt_merchant.Text.Equals("") ||
          txt_storename.Text.Equals("") ||
             txt_password.Text.Equals(""))
            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string email = txt_email.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {


                    checkImg();






                }
                else
                    MessageBox.Show(email + " Invalid email format", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void checkImg()
        {
            try
            {
                var ImgFile = Path.GetFileName(pathIMG);



                string query = "SELECT * FROM `tbl_merchant` WHERE merchant_id='"+ txt_id.Text+ "'and gcash_img='"+ImgFile+"'";

                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataReader myreader1;
                conn.Open();
                //execute the query
                myreader1 = mycommand.ExecuteReader();
                if (myreader1.Read())
                {


                    MessageBox.Show("Icon Already Exist , \n Try Again!", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
               

                }
                else
                {

                    update_accounts();
                 
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                QR_img.Image = new Bitmap(open.FileName);
            }
           
        }


        public void addImage()
        {
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;

            System.IO.File.Copy(pathIMG, Path.Combine(imgPath, Path.GetFileName(pathIMG)), true);

        }














    }



            }

   
