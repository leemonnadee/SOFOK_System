﻿using MySql.Data.MySqlClient;
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
    public partial class loginform : Form
    {

        // setup connection  username , password and database
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        public loginform()
        {
            InitializeComponent();
            combo_log.SelectedIndex = 0;
        }

        public class UserDisplay
        {
            public static string MerchantID;
            public static string StoreName;
            public static string merchantName;
            public static string maritalStatus;
            public static string address;
            public static string gender;
            public static string birthdate;
            public static string email;
            public static string contact;  

        }

            private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           if (combo_log.Text.Equals("Costumer"))
            {
                Mainpage MainCostumer = new Mainpage();
                MainCostumer.Show();
                this.Hide();
             
            }
            else { 
            loginAuth();
            }
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
            }
        }

        public void getStoreName()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_merchant.merchant_store FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.StoreName = myreaderfetch.GetString("merchant_store");
            }
        }

        public void getMerchantsName()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_merchant.name FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.merchantName = myreaderfetch.GetString("name");
            }
        }

        public void getMaritalStatus()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_merchant.marital_status FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.maritalStatus = myreaderfetch.GetString("marital_status");
            }
        }

        public void getGender()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_merchant.gender FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.gender = myreaderfetch.GetString("gender");
            }
        }
        public void getContact()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_merchant.contact_no FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.contact = myreaderfetch.GetString("contact_no");
            }
        }
        public void getAddress()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_merchant.address FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.address = myreaderfetch.GetString("address");
            }
        }
        public void getBirthdate()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_merchant.birthdate FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.birthdate = myreaderfetch.GetString("birthdate");
            }
        }
        public void getEmail()
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            var str = passwordtxt.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);

            string query2 = "SELECT tbl_account.username FROM tbl_account WHERE username = '" + usernametxt.Text + "' and password ='" + encryptPassword + "'; ";
            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

            MySqlDataReader myreaderfetch;

            conn.Open();
            myreaderfetch = mycommandfetch.ExecuteReader();
            while (myreaderfetch.Read())
            {
                UserDisplay.email = myreaderfetch.GetString("username");
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
                      
                        else
                        {
                        
                            merchantmainfrm mf = new merchantmainfrm();
                            mf.Show();
                            getMerchantID();
                            getStoreName();
                            getMerchantsName();
                            getMaritalStatus();
                            getGender();
                            getContact();
                            getBirthdate();
                            getAddress();
                            getEmail();
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

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}




