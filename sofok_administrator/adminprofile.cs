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
    public partial class adminprofile : Form
    {


        //set connection
        string mycon = "datasource=192.168.100.201;username=root;password=123456;database=sofok_db";
        public adminprofile()
        {
           
            InitializeComponent();
            combo_log.SelectedIndex = 0;
        }
        
       

        // insert function
        public void insert_admin_info()
        {
            try {

                dateformatreturn();
                var gender = combo_log.SelectedItem.ToString();
                string query = "INSERT INTO `tbl_admin`( `name`, `birthdate`, `address`, `gender`, `contact`,`acc_id`) VALUES ('" + txt_name.Text+"','"+dateTimePicker1.Text+"','"+txt_address.Text+"','"+ gender + "','"+txt_mobile.Text+"','"+ lbl_id.Text+ "')";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



                MySqlDataReader myreader1;

                conn.Open();
                // insert Merchant Data
                myreader1 = mycommand.ExecuteReader();
                conn.Close();
                MessageBox.Show("Successfully Added", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
        
        
        }




        //clear inputs function
        public void clear() {
            txt_email.Text = ("");
            txt_password.Text = ("");
            txt_address.Text = ("");
            txt_mobile.Text = ("");
            txt_name.Text = ("");
            lbl_id.Text="";
            dateTimePicker1.Value= DateTime.Now;

        }

        //create admin acc function
        public void create_acc()
        {
            if (txt_email.Text.Equals("") ||
                txt_password.Text.Equals("") ||
                txt_address.Text.Equals("") ||
                 txt_mobile.Text.Equals("") ||
                  txt_name.Text.Equals(""))
            {


       
                    MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
           

            }
            else { 
                try
                {
                    //encryption key
                    var key = "b14ca5898a4e4133bbce2ea2315a1916";


                    // set encryption key on password field
                    var str = txt_password.Text;
                    var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);




                    string query = "INSERT INTO `tbl_account`(`acc_id`, `username`, `password`, `log_as`) VALUES ('','" + txt_email.Text + "','" + encryptPassword + "','Administrator')";
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

                 

                    conn.Close();



                    insert_admin_info();
                    dateformat();
                    clear();
                    showalldata();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Email is Already taken", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }






















        // date format to wed,date-month-year
        public void dateformat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
           

        }
        //date format to 21-12-30
        public void dateformatreturn()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "yy-MM-dd";
          


        }



        //show data in tables
        public void showalldata()
        {

            try
            {

                string query = " SELECT admin_id, name, birthdate, address, gender, contact,tbl_account.username, tbl_account.acc_id FROM `tbl_admin` INNER JOIN tbl_account ON tbl_admin.acc_id=tbl_account.acc_id where tbl_account.log_as='Administrator'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);

                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                AdminTable.DataSource = dtable;
                myadapter.Fill(dtable);






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //delete function
        public void deleteAccount()
        {

            try
            {


                string query = "DELETE tbl_admin,tbl_account FROM tbl_admin INNER JOIN  tbl_account ON tbl_admin.acc_id = tbl_account.acc_id WHERE admin_id= '" + txt_id.Text + "'; ";
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


        //update function
        public void update_accounts()
        {

            //encryption key
            var key = "b14ca5898a4e4133bbce2ea2315a1916";


            // set encryption key on password field
            var str = txt_password.Text;
            var encryptPassword = EncryptDecryptPassword.EncryptString(key, str);


            try
            {
                var gender = combo_log.SelectedItem.ToString();
                dateformatreturn();
                string query = "UPDATE `tbl_account` SET `username`='" + txt_email.Text + "',`password`='" + encryptPassword + "' WHERE acc_id='" + lbl_id.Text + "'";
                string query2 = "UPDATE `tbl_admin` SET `name`='"+txt_name.Text+"',`birthdate`='"+dateTimePicker1.Text+"',`address`='"+txt_address.Text+"',`gender`='"+gender+"',`contact`='"+txt_mobile.Text+"' WHERE `admin_id`='"+txt_id.Text+"'";
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
                dateformat();
                MessageBox.Show("Update successfully", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Email is already taken", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







































        //update button
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Equals("") ||
             txt_address.Text.Equals("") ||
             txt_mobile.Text.Equals("") ||
             txt_password.Text.Equals("") ||
             txt_name.Text.Equals(""))
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


        //save button
        private void save_btn_Click(object sender, EventArgs e)
        {
            create_acc();
        
        }

        private void adminprofile_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:m tt");
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            timer1.Start();
            lbl_id.Visible = false;
            txt_id.Visible = false;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            save_btn.Enabled = true;
            dateformat();
            showalldata();
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker1.Value;
            int years = DateTime.Now.Year - dateTimePicker1.Value.Year;

            if (dateTimePicker1.Value.AddYears(years) > DateTime.Now) years--;
            lbl_age.Text = years.ToString();
        }

        private void AdminTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AdminTable.Rows[e.RowIndex];
                txt_id.Text = row.Cells["admin_id"].Value.ToString();
                txt_name.Text = row.Cells["name"].Value.ToString();
                dateTimePicker1.Text = row.Cells["birthdate"].Value.ToString();
                combo_log.Text= row.Cells["gender"].Value.ToString();
                txt_address.Text= row.Cells["address"].Value.ToString();
                txt_email.Text = row.Cells["username"].Value.ToString();
                txt_mobile.Text = row.Cells["contact"].Value.ToString();
                lbl_id.Text = row.Cells["acc_id"].Value.ToString();

            }
            save_btn.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
        }
        //delete button
        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this Account?", "Delete", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {


                if (txt_email.Text.Equals("") ||
                txt_address.Text.Equals("") ||
                txt_mobile.Text.Equals("") ||
                txt_name.Text.Equals(""))
                {



                    MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else { 





                deleteAccount();
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                save_btn.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            time.Text = DateTime.Now.ToString("hh:m:s tt");
            timer1.Start();
        }

        private void time_Click(object sender, EventArgs e)
        {

        }
    }
    }


