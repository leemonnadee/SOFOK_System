using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SOFOK_System
{
    public partial class merchantprofile : Form
    {
        string mycon = "datasource='" + connection.ipconnection + "';username=root;password=123456;database=sofok_db";
        String pathIMG;
        public String imgprof;
        public static merchantprofile profile;
        public static String gender_update;
        String audit_info;
        public merchantprofile()
        {
            InitializeComponent();
            profile = this;
            
        }


        public void show_data() {

            merchant_id.Text = loginform.UserDisplay.MerchantID;
            storename_lbl.Text = loginform.UserDisplay.StoreName;
            merchantname_lbl.Text = loginform.UserDisplay.merchantName;
            email_lbl.Text = loginform.UserDisplay.email;
            txtemail.Text = loginform.UserDisplay.email;
            marital_lbl.Text = loginform.UserDisplay.maritalStatus;
            gender_lbl.Text = loginform.UserDisplay.gender;
            contact_lbl.Text = loginform.UserDisplay.contact;
            String birthdate = loginform.UserDisplay.birthdate;
            String.Format("{0:ddd, MMM d, yyyy}", birthdate);
            birthdate_lbl.Text = birthdate;
            address_lbl.Text = loginform.UserDisplay.address;
            save_img.Enabled = false;

        }
        private void merchantprofile_Load(object sender, EventArgs e)
        {
            show_data();
            img_display();

        }
        public void img_display()
        {
            try
            {
                string query2 = "SELECT * FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE  tbl_merchant.acc_id='" + loginform.UserDisplay.Acc_id + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();
                while (myreaderfetch.Read())
                {

                     imgprof = myreaderfetch.GetString("profile_img");
                    
                }
                if (imgprof == ("none"))
                {
                    
                }
                else {
                    System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
                    String imgPath = DI.FullName;

                    merchantpic.Image = Image.FromFile(imgPath + @"\" + imgprof);
                }
                //string filePath = System.IO.Path.GetFullPath("");
             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            updateinfo_frm updateinfo = new updateinfo_frm();
            updateinfo.Show();
           


        }

        public void update_Data() {

            try
            {


                var key = "b14ca5898a4e4133bbce2ea2315a1916";

                var str = txt_password.Text;
                var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);
                string query = "UPDATE `tbl_account` SET `username`='" + txtemail.Text + "',`password`='" + encryptPassword + "' WHERE acc_id='" + loginform.UserDisplay.Acc_id + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;


                conn.Open();
                myreader1 = mycommand.ExecuteReader();
                conn.Close();


                acc_update_audit_merch();
                MessageBox.Show("Update successfully", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email is already used");
            } 
        }
        private void updateusername_btn_Click(object sender, EventArgs e)
        {
            if (txtemail.Equals("") || txt_password.Equals(""))
            {


                MessageBox.Show("Invalid Email or Password", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                update_Data();
                txt_password.Text = "";        }
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Photo";
            open.Filter = "Image Files(*.png; *.jpeg; *.JPG;)|*.png;*.jpeg;*.JPG;";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathIMG = open.FileName;
                merchantpic.Image = new Bitmap(open.FileName);
                
            }
            save_img.Enabled = true;

        }

        public void addImage()
        {
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;

            System.IO.File.Copy(pathIMG, Path.Combine(imgPath, Path.GetFileName(pathIMG)), true);

        }

        public void upadte_Image()
        {

            try
            {
                var ImgFile = Path.GetFileName(pathIMG);

                string query = "UPDATE `tbl_merchant` SET `profile_img`='" + ImgFile + "' WHERE tbl_merchant.acc_id='" + loginform.UserDisplay.Acc_id + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;


                conn.Open();
                myreader1 = mycommand.ExecuteReader();
              
                addImage();
                conn.Close();



                MessageBox.Show("Update successfully", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                img_display();
                profile_audit_merch();
                save_img.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    private void save_img_Click(object sender, EventArgs e)
        {
            upadte_Image();

            //var ImgFile = Path.GetFileName(pathIMG);
           // MessageBox.Show(ImgFile);
        }





        public void profile_audit_merch()
        {

            try
            {
                var ImgFile = Path.GetFileName(pathIMG);

                if (ImgFile == null)
                {

                    audit_info = (" " + merchantname_lbl.Text + " " + storename_lbl.Text + " " + ImgFile + " ");
                }
                else
                {
                    audit_info = (" "+ merchantname_lbl .Text+ " "+ storename_lbl.Text+ " ");
                    // audit_info = ("" + lbl_merchantname.Text + " " + productnametxt.Text + " " + combo_category.Text + " " + prodpricetxt.Text + " ");
                }








                string query = " INSERT INTO `tbl_audittrail`(`id`, `user`, `transaction_summary`, `module`)" +
                        " VALUES ('','" + loginform.UserDisplay.email + "','UPDATE PROFILE " + audit_info + "','Merchant Module')";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                conn.Close();








            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }











        public void acc_update_audit_merch()
        {

            try
            {
                var ImgFile = Path.GetFileName(pathIMG);

             

                    audit_info = (" " + merchantname_lbl.Text + " " + storename_lbl.Text + "  ");
         







                string query = " INSERT INTO `tbl_audittrail`(`id`, `user`, `transaction_summary`, `module`)" +
                        " VALUES ('','" + loginform.UserDisplay.email + "','UPDATE ACCOUNT " + audit_info + "','Merchant Module')";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                conn.Close();








            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }















    }
}
