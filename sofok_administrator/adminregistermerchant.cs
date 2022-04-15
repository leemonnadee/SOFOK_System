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
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        public adminregistermerchant()
        {
            InitializeComponent();
   
        }

       
        public void clear() {
            txt_merchant.Text = "";
            txt_storename.Text= "";
            lbl_id.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";


        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //close form in panel
            this.Hide();
        }
        public void add_merchant_account()
        {
            try
            {


                string query = "INSERT INTO `tbl_merchant`(`merchant_id`, `name`, `merchant_store`, `acc_id`) VALUES ('','" + txt_merchant.Text + "','" + txt_storename.Text + "','" + lbl_id.Text + "')";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;

                conn.Open();
                myreader1 = mycommand.ExecuteReader();
                conn.Close();
                MessageBox.Show("Successfully added");

            }
            catch (Exception ex)
            {
            }
        }

        public void create_acc() {
            try
            {
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
          
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
                myreader1 = mycommand.ExecuteReader();
                
                conn.Close();

                conn.Open();

                myreader2 = mycommand2.ExecuteReader();

                while (myreader2.Read())
                {

                    string s = lbl_id.Text = myreader2.GetString("acc_id");
                }

                add_merchant_account();
                
                clear();

                conn.Close();
            







            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            



        }

      
        private void save_btn_Click(object sender, EventArgs e)
        {
            create_acc();
        }
    }
}
