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
    public partial class merchantprofile : Form
    {
        public static merchantprofile profile;
        public merchantprofile()
        {
            InitializeComponent();
            profile = this;
            
        }
        
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //upload photo

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Photo";
            ofd.Filter = "Photo(*.png; *.jpeg; *.JPG;)|*.png;*.jpeg;*.JPG;";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                merchantpic.Image = new Bitmap(ofd.FileName);
            }
        }

        private void merchantprofile_Load(object sender, EventArgs e)
        {
            merchant_id.Text = loginform.UserDisplay.MerchantID;
            storename_lbl.Text = loginform.UserDisplay.StoreName;
            merchantname_lbl.Text = loginform.UserDisplay.merchantName;
            email_lbl.Text = loginform.UserDisplay.email;
            marital_lbl.Text = loginform.UserDisplay.maritalStatus;
            gender_lbl.Text = loginform.UserDisplay.gender;
            contact_lbl.Text = loginform.UserDisplay.contact;
            birthdate_lbl.Text = loginform.UserDisplay.birthdate;
            address_lbl.Text = loginform.UserDisplay.address;

        }

        private void bunifuLabel16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            updateinfo_frm updateinfo = new updateinfo_frm();
            updateinfo.Show();


        }

        private void merchantname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
