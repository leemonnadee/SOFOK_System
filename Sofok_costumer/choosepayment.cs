﻿using System;
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
    public partial class choosepayment : Form
    {
        public choosepayment()
        {
            InitializeComponent();
            frm_transparent();


        }
        public void frm_transparent() {
           this.BackColor = Color.DarkOrange;
            this.TransparencyKey = Color.DarkOrange;
            

        }
  

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            frmMain fr = new frmMain();
            this.Hide();
            fr.MaximizeBox = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
