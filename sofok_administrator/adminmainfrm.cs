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
    public partial class adminmainfrm : Form
    {
        public adminmainfrm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //open form in panel
            //container.Controls.Clear();
            adminmerchantsales adminmerchantsales = new adminmerchantsales();
            adminmerchantsales.TopLevel = false;
            container.Controls.Add(adminmerchantsales);
            adminmerchantsales.Show();
        }

        private void adminprofilebtn_Click(object sender, EventArgs e)
        {
            //open form in panel
            //container.Controls.Clear();
            adminprofile adminprofile = new adminprofile();
            adminprofile.TopLevel = false;
            container.Controls.Add(adminprofile);
            adminprofile.Show();
        }

  

        private void registermerchantbtn_Click(object sender, EventArgs e)
        {
            //open form in panel
            //container.Controls.Clear();
            adminregistermerchant register = new adminregistermerchant();
            register.TopLevel = false;
            container.Controls.Add(register);
            register.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to logout?", "logout", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                loginform lf = new loginform();
                lf.Show();
                this.Hide();
            }
        }
    }
}
