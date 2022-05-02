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
        public merchantprofile()
        {
            InitializeComponent();
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
          
        }

     
    }
}
