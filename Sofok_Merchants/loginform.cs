using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFOK_System
{
    public partial class loginform : Form
    {

        // setup connection  username , password and database
        string mycon = "datasource=192.168.100.201;username=root;password=123456;database=sofok_db";
        public loginform()
        {
            InitializeComponent();
            combo_log.SelectedIndex = 0;
        }

        public class UserDisplay
        {
            public static string MerchantID;
            public static string merchantName;
            public static string StoreName;
            public static string maritalStatus;
            public static string address;
            public static string gender;
            public static string birthdate;
            public static string email;
            public static string contact;
            public static int Acc_id;
            public static string Merchat_status;
    
        }

            private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        /*   private void ValidateEmail()
           {
               string email = usernametxt.Text;
               Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
               Match match = regex.Match(email);
               if (match.Success)
                   loginAuth();
               else
                   MessageBox.Show(email + " is Invalid Email Address");
           }
        */
        private void btn_login_Click(object sender, EventArgs e)
        {
           
            if (combo_log.Text.Equals("Costumer"))
            {
                Mainpage MainCostumer = new Mainpage();
                MainCostumer.Show();
                this.Hide();
             
            }
            else {
                loginAuth(); ;
            }
        }
        public void login_Online() {
            string query = "UPDATE `tbl_merchant` SET `login_status`=1 WHERE merchant_id='"+UserDisplay.MerchantID+"'";

            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommand = new MySqlCommand(query, conn);

            MySqlDataReader myreader1;






            //opening connection
            conn.Open();
            //execute the query
            myreader1 = mycommand.ExecuteReader();
            conn.Close();


        }


        public void getMerchantID() {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT * FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.MerchantID = myreaderfetch.GetString("merchant_ID");
                UserDisplay.merchantName = myreaderfetch.GetString("name");
               
                UserDisplay.StoreName = myreaderfetch.GetString("merchant_store");

                UserDisplay.maritalStatus = myreaderfetch.GetString("marital_status");
                UserDisplay.address = myreaderfetch.GetString("address");
                UserDisplay.gender = myreaderfetch.GetString("gender");
                UserDisplay.birthdate = myreaderfetch.GetString("birthdate");
                UserDisplay.contact = myreaderfetch.GetString("contact_no");
                

            }
         
            }

        public void getEmail()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_account.username,tbl_account.acc_id FROM tbl_account WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.email = myreaderfetch.GetString("username");
                UserDisplay.Acc_id = myreaderfetch.GetInt32("acc_id");
            }
        }




        public void loginAuth()
        {
            if (usernametxt.Text.Equals("") ||
                passwordtxt.Text.Equals(""))
            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    var key = "b14ca5898a4e4133bbce2ea2315a1916";

                    var str = passwordtxt.Text;
                    var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);


                    //connection query you can try on  workbench first 
                    string query = "Select * from tbl_account where username='" + usernametxt.Text + "' and password='" + encryptPassword + "'and log_as='" + combo_log.Text + "'";
                 
                    MySqlConnection conn = new MySqlConnection(mycon);
                    MySqlCommand mycommand = new MySqlCommand(query, conn);

                    MySqlDataReader myreader1;



         




                        //opening connection
                        conn.Open();
                        //execute the query
                        myreader1 = mycommand.ExecuteReader();


                        if (myreader1.Read())
                        {

                        if (combo_log.Text.Equals("Administrator"))
                        {
                            this.Hide();
                            adminmainfrm af = new adminmainfrm();
                            af.Show();
                            this.Hide();
                        }

                        else if (combo_log.Text.Equals("Merchant"))
                        {

                            merchantmainfrm mf = new merchantmainfrm();
                            mf.Show();
                            getMerchantID();
                            getEmail();
                            this.Hide();
                            login_Online();


                        }
                        else {
                            Mainpage mp = new Mainpage();
                            mp.Show();
                            this.Hide();
                        }
                   
                        
                        // always close

                        conn.Close();
                            usernametxt.Text = string.Empty;
                            passwordtxt.Text = string.Empty;

                        }
                        else
                        {
                            MessageBox.Show("Username And Password Not Match!", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }












                    }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }











        }

        private void loginform_Load(object sender, EventArgs e)
        {
     
        }
    }
}




