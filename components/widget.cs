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

    public partial class widget : UserControl
    {
        private categories _category;
        private double _cost;
        private int _id;

        public event EventHandler OnSelect = null;
        public widget()
        {
            InitializeComponent();
            lbl_ID.Visible = false;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
        public enum categories { food,drink,meal,burger};
        public categories Category { get => _category; set => _category=value; }
        public String Title{ get => lbl_Title.Text; set => lbl_Title.Text = value; }
        public double Cost { get => _cost; set { _cost = value; lbl_Price.Text = _cost.ToString("C2"); } }
        public String Store { get => lbl_store.Text; set => lbl_store.Text = value; }
        public Image Icon { get => img.Image; set => img.Image = value; }
        public int ID { get =>_id; set{ _cost = value; lbl_ID.Text = _cost.ToString(); } }

        
    }
}
