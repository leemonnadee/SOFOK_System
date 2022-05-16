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
using MySql.Data.MySqlClient;

namespace SOFOK_System
{
    public partial class updateinfo_frm : Form
    {
        public static updateinfo_frm profie;
        string mycon = "datasource='" + connection.ipconnection + "';username=root;password=123456;database=sofok_db";
        String update_query;
        String pathIMG;
        public string imgprof;
        String audit_info;
        public updateinfo_frm()
        {
            InitializeComponent();
            profie = this;
            frm_transparent();
     
        }
        public void frm_transparent()
        {
            this.BackColor = Color.DarkOrange;
            this.TransparencyKey = Color.DarkOrange;


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

                    imgprof = myreaderfetch.GetString("gcash_img");

                }
                if (imgprof == ("none"))
                {

                }
                else
                {
                    System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
                    String imgPath = DI.FullName;

                    QR_img.Image = Image.FromFile(imgPath + @"\" + imgprof);
                }
                //string filePath = System.IO.Path.GetFullPath("");


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel update?", "Cancel Update", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                
                this.Hide();

            }
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
        //update merchant information
        public void update_info() {

            if (nameupdate_txt.Text.Equals("") ||
                addressupdate_txt.Text.Equals("") ||
               checkedListBox1.Text.Equals("") ||
               combo_gender.Text.Equals ("")||
                cellphoneupdate_txt.Text.Equals(""))
            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var ImgFile = Path.GetFileName(pathIMG);

                    if (ImgFile == null)
                    {
                         update_query = "update sofok_db.tbl_merchant set name='" + this.nameupdate_txt.Text + "', address='" + this.addressupdate_txt.Text + "', birthdate= '" + this.birthdate_picker.Text + "',gender= '" + combo_gender.Text + "',contact_no= '" + Double.Parse(this.cellphoneupdate_txt.Text) + "', marital_status= '" + checkedListBox1.Text + "' where merchant_id= '" + loginform.UserDisplay.MerchantID + "';";


                    }
                    else {
                        update_query = "update sofok_db.tbl_merchant set name='" + this.nameupdate_txt.Text + "', address='" + this.addressupdate_txt.Text + "', birthdate= '" + this.birthdate_picker.Text + "',gender= '" + combo_gender.Text + "',contact_no= '" + Double.Parse(this.cellphoneupdate_txt.Text) + "', marital_status= '" + checkedListBox1.Text + "',`gcash_img`='" + ImgFile + "' where merchant_id= '" + loginform.UserDisplay.MerchantID + "';";
                        addImage();
             

                    }
                    MySqlConnection conDataBase = new MySqlConnection(mycon);
                    MySqlCommand cmdDataBase = new MySqlCommand(update_query, conDataBase);
                    MySqlDataReader myReader;
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Profile updated", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    update_profile_audit_merch();

                    while (myReader.Read())
                    {

                    }
                    merchantprofile.profile.merchantname_lbl.Text = nameupdate_txt.Text;
                    merchantprofile.profile.marital_lbl.Text = checkedListBox1.Text;
                    merchantprofile.profile.gender_lbl.Text = combo_gender.Text;
                    merchantprofile.profile.contact_lbl.Text = cellphoneupdate_txt.Text;
                    merchantprofile.profile.birthdate_lbl.Text = birthdate_picker.Text;
                    merchantprofile.profile.address_lbl.Text = addressupdate_txt.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
            } 
        }//end update
        public void addImage()
        {
            System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
            String imgPath = DI.FullName;

            System.IO.File.Copy(pathIMG, Path.Combine(imgPath, Path.GetFileName(pathIMG)), true);

        }

        public void checkImg()
        {
            try
            {
                var ImgFile = Path.GetFileName(pathIMG);


               
                    string query = "SELECT * FROM `tbl_merchant` WHERE merchant_id='" + loginform.UserDisplay.MerchantID + "'and gcash_img='" + ImgFile + "'";
              
               
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
                    update_info();
                  


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void updateinfo_btn_Click(object sender, EventArgs e)
        {
          
          
                checkImg();
          

        }
      

    

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Photo";
            open.Filter = "Image Files(*.png; *.jpeg; *.JPG;)|*.png;*.jpeg;*.JPG;";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathIMG = open.FileName;
                QR_img.Image = new Bitmap(open.FileName);
            }
        }
        /*
        public void show_data() {
            nameupdate_txt.Text = loginform.UserDisplay.merchantName;
            addressupdate_txt.Text=loginform.UserDisplay.address;
            birthdate_picker.Text =loginform.UserDisplay.birthdate;
            cellphoneupdate_txt.Text = loginform.UserDisplay.contact;
            merchantprofile mp = new merchantprofile();
         combo_gender.Text= mp.gender_lbl.Text;


        }
        */
        private void updateinfo_frm_Load(object sender, EventArgs e)
        {
            //show_data();
            img_display();
           
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }

        private void cellphoneupdate_txt_KeyPress(object sender, KeyPressEventArgs e)
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








        //audit trails report

        public void update_profile_audit_merch()
        {

            try
            {
                var ImgFile = Path.GetFileName(pathIMG);

                if (ImgFile == null)
                {

                    audit_info = ("" + loginform.UserDisplay.MerchantID + " " + loginform.UserDisplay.StoreName + " " + nameupdate_txt.Text+ " " + addressupdate_txt.Text + " "
                        + birthdate_picker.Text + " " + combo_gender.Text + " " + cellphoneupdate_txt.Text + " " + checkedListBox1.Text + " " + QR_img.Text + " ");
                }
                else
                {
                    audit_info = ("" + loginform.UserDisplay.MerchantID + " " + loginform.UserDisplay.StoreName + " " + nameupdate_txt.Text + " " + addressupdate_txt.Text + " "
                      + birthdate_picker.Text + " " + combo_gender.Text + " " + cellphoneupdate_txt.Text + " " + checkedListBox1.Text + " " + QR_img.Text + " " + ImgFile + " ");
                }








                string query = " INSERT INTO `tbl_audittrail`(`id`, `user`, `transaction_summary`, `module`)" +
                        " VALUES ('','" + loginform.UserDisplay.email + "','PROFILE UPDATE " + audit_info + "','Merchant Module')";
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
