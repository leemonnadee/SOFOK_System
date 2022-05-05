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
    public partial class merchant_widget : UserControl
    {
        private double _cost;
        private double _id;
        public event EventHandler OnSelect = null;
        public merchant_widget()
        {
            InitializeComponent();
        }


       
            public String StoreName { get => bl_Store_Name.Text; set => bl_Store_Name.Text = value; }
            public String Merchant_Name { get => lbl_merchant_Name.Text; set => lbl_merchant_Name.Text = value; }
            public String Available_prod { get => lbl_prod_Number.Text; set => lbl_prod_Number.Text = value; }
     
            public double ID { get => _id; set { _cost = value; lbl_id.Text = _cost.ToString(); } }
        //public int ID { get => lbl_Title.Text; set => lbl_Title.Text = value; }
        private void bunifuShadowPanel1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void merchant_widget_Load(object sender, EventArgs e)
        {
            lbl_id.Visible = false;
        }
    }
    }

       



