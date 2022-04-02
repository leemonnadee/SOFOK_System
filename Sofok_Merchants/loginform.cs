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
        }

            private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
          
            loginAuth();
        }



        public void getMerchantID() {
            string query2 = "SELECT tbl_merchant.merchant_id FROM tbl_account INNER JOIN tbl_merchant ON tbl_account.acc_id = tbl_merchant.acc_id WHERE username = '" + usernametxt.Text + "' and password ='" + passwordtxt.Text + "'; ";
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

                    //connection query you can try on  workbench first 
                    string query = "Select * from tbl_account where username='" + usernametxt.Text + "' and password='" + passwordtxt.Text + "'and log_as='" + combo_log.Text + "'";
                 
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
                                MessageBox.Show("success");
                                merchantmainfrm mf = new merchantmainfrm();
                                mf.Show();
                                this.Hide();
                             

                            }

                        getMerchantID();

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




    }
}




