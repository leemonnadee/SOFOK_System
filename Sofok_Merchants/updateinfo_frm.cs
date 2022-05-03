using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public updateinfo_frm()
        {
            InitializeComponent();
            profie = this;
        }
        public class UserDisplay
        {
            public static string MerchantID;
            public static string StoreName;
            public static string merchantName;

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void updateinfo_frm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
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

        private void updateinfo_btn_Click(object sender, EventArgs e)
        {
            string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
            string query = "update sofok_db.tbl_merchant set name='" + this.nameupdate_txt.Text + "', address='" + this.addressupdate_txt.Text + "', birthdate= '" + this.birthdate_picker.Text + "',gender= '" + gender + "',contact_no= '" + this.cellphoneupdate_txt.Text + "', marital_status= '" +maritalstatus+"' where merchant_id= '"+ loginform.UserDisplay.MerchantID +"';";
            MySqlConnection conDataBase = new MySqlConnection(mycon);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            if (nameupdate_txt.Text.Equals("") ||
                addressupdate_txt.Text.Equals("") ||
                birthdate_picker.Text.Equals("") ||
                gender.Equals("") ||
                cellphoneupdate_txt.Text.Equals(""))
            {
                MessageBox.Show("Please Fill all form", "SoFOK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Updated");
                    
                    while (myReader.Read())
                    {

                    }                   
                    merchantprofile.profile.merchantname_lbl.Text = nameupdate_txt.Text;
                    merchantprofile.profile.marital_lbl.Text = maritalstatus;
                    merchantprofile.profile.gender_lbl.Text = gender;
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

        }
        string gender;
        string maritalstatus;
        private void female_radio_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            gender = "Female";
        }

        private void male_radio_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            gender = "Male";
        }

        private void female_radio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void male_radio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void married_cbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            maritalstatus = "Married";
        }

        private void single_cbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            maritalstatus = "Single";

        }

        private void divorced_cbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            maritalstatus = "Divorced";

        }

        private void widowed_cbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            maritalstatus = "Widowed";

        }

        private void separated_cbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            maritalstatus = "Separated";

        }
    }
}
