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
    public partial class merchantmainfrm : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        public merchantmainfrm()
        {
            InitializeComponent();
        }
  
        private void ordersbtn_Click(object sender, EventArgs e)
        {
            //open form in panel
            container.Controls.Clear();
            merchantorders orders = new merchantorders();
            orders.TopLevel = false;
            container.Controls.Add(orders);
            orders.Show();
        }

        private void merchantprofilebtn_Click(object sender, EventArgs e)
        {
            //open form in panel
            container.Controls.Clear();
            merchantprofile profile = new merchantprofile();
            profile.TopLevel = false;
            container.Controls.Add(profile);
            profile.Show();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            //open form in panel
            container.Controls.Clear();
            merchantproduct_main products = new merchantproduct_main();
            products.TopLevel = false;
            container.Controls.Add(products);
            products.Show();
        }

        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {

        }

        private void container_Click(object sender, EventArgs e)
        {

        }

        private void merchantsalesbtn_Click(object sender, EventArgs e)
        {
            //open form in panel
            container.Controls.Clear();
            merchantsales sales = new merchantsales();
            sales.TopLevel = false;
            container.Controls.Add(sales);
            sales.Show();
        }

        private void merchantmainfrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongDateString();
            timelbl.Text = DateTime.Now.ToLongTimeString();
        }

        public void login_Offline()
        {
            string query = "UPDATE `tbl_merchant` SET `login_status`=0 WHERE merchant_id='" + loginform.UserDisplay.MerchantID + "'";

            MySqlConnection conn = new MySqlConnection(mycon);
            MySqlCommand mycommand = new MySqlCommand(query, conn);

            MySqlDataReader myreader1;








            //opening connection
            conn.Open();
            //execute the query
            myreader1 = mycommand.ExecuteReader();
            conn.Close();


        }







        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to logout?", "logout", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                loginform lf = new loginform();
                lf.Show();
                this.Hide();
                login_Offline();
            }
        }

        private void bunifuPanel4_Click(object sender, EventArgs e)
        {

        }
    }
}
