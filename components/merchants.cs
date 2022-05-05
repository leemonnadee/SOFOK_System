using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFOK_System.components
{
    public partial class merchants : UserControl
    {
        public merchants()
        {
            InitializeComponent();
        }


        public String StoreName { get => bl_Store_Name.Text; set => bl_Store_Name.Text = value; }
        public String Merchant_Name { get =>lbl_merchant_Name.Text; set => lbl_merchant_Name.Text = value; }
        public String Available_prod { get => lbl_prod_Number.Text; set => lbl_prod_Number.Text = value; }
    }
}
