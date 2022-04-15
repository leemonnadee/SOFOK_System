using MySql.Data.MySqlClient;
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
    public partial class adminregistermerchant : Form
    {
        //set connection
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        public adminregistermerchant()
        {
            InitializeComponent();
   
        }


        //show ALl data in table
        public void showalldata()
        {

            try
            {

                string query = "SELECT `merchant_id`, `name`,`merchant_store`,tbl_account.username, tbl_account.acc_id FROM `tbl_merchant` INNER JOIN tbl_account ON tbl_merchant.acc_id = tbl_account.acc_id; ";

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


                    string query = "INSERT INTO `tbl_merchant`(`merchant_id`, `name`, `merchant_store`, `acc_id`) VALUES ('','" + txt_merchant.Text + "','" + txt_storename.Text + "','" + lbl_id.Text + "')";
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);



                    MySqlDataReader myreader1;

                    conn.Open();
                    // insert Merchant Data
                    myreader1 = mycommand.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Successfully Added", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

                        string s = lbl_id.Text = myreader2.GetString("acc_id");
                    }

                    add_merchant_account();
                    showalldata();

                    clear();

                    conn.Close();








                }
            catch (Exception ex) {
                    MessageBox.Show("Email is Already taken", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                    string query = "DELETE tbl_merchant,tbl_account FROM `tbl_merchant` INNER JOIN  tbl_account ON tbl_merchant.acc_id = tbl_account.acc_id WHERE merchant_id = '"+txt_id.Text+"'; ";
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
        }

        //save button
        private void save_btn_Click_1(object sender, EventArgs e)
        {
            
            create_acc();
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


                try
                {
                    string query = "UPDATE `tbl_account` SET `username`='" + txt_email.Text + "',`password`='" + encryptPassword + "' WHERE acc_id='" + lbl_id.Text + "'";
                    string query2 = "UPDATE `tbl_merchant` SET `name`='" + txt_merchant.Text + "',`merchant_store`='" + txt_storename.Text + "' WHERE merchant_id='" + txt_id.Text + "'";
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);
                    MySqlCommand mycommand2 = new MySqlCommand(query2, conn);


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
                }
           
        }



        //update btn
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Equals ("") ||
          txt_merchant.Text .Equals("") ||
          txt_storename.Text.Equals(""))
            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                update_accounts();
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                save_btn.Enabled = true;
            }



            }










    }
}
