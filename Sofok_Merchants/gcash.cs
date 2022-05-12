using MySql.Data.MySqlClient;
using SOFOK_System.Sofok_costumer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFOK_System.Sofok_Merchants
{

    public partial class gcash : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        String imgprof;
        public gcash()
        {
            InitializeComponent();
            frm_transparent();
         
        }
        public void frm_transparent()
        {
            this.BackColor = Color.LightSalmon;
            this.TransparencyKey = Color.LightSalmon;


        }
        public void btn_done_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 285);
            printPreviewDialog1.ShowDialog();
            //this.Hide();
        }

        private void gcash_Shown(object sender, EventArgs e)
        {
            String s = frmMain.tot.total_amount;
            lbl_total_amount.Text = s;
            img_display();
        }


        public void img_display()
        {
            try
            {
                string query2 = "SELECT * FROM `tbl_merchant` WHERE merchant_id='"+ merchant_list.merchantDisplay.merch_id + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommandfetch = new MySqlCommand(query2, conn);

                MySqlDataReader myreaderfetch;

                conn.Open();
                myreaderfetch = mycommandfetch.ExecuteReader();
                while (myreaderfetch.Read())
                {

                    imgprof = myreaderfetch.GetString("gcash_img");

                }
                if (imgprof == ("none"))
                {

                }
                else
                {
                    System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("icons");
                    String imgPath = DI.FullName;

                    QR_img.Image = Image.FromFile(imgPath + @"\" + imgprof);
                }
                //string filePath = System.IO.Path.GetFullPath("");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString("sofok", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));

            int receptno = 42;
            Graphics graphics = e.Graphics;
            Font font7 = new Font("Courier New", 7);
            Font font10 = new Font("Courier New", 10);
            Font font12 = new Font("Courier New", 12);
            Font font14 = new Font("Courier New", 14);
            Font font25 = new Font("Courier New", 25);

            float leading = 4;
            float lineheight10 = font10.GetHeight() + leading;
            float lineheight12 = font12.GetHeight() + leading;
            float lineheight14 = font14.GetHeight() + leading;

            float startX = 0;
            float startY = leading;
            float Offset = 0;

            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft);
            StringFormat formatRight = new StringFormat(formatLeft);

            formatCenter.Alignment = StringAlignment.Center;
            formatRight.Alignment = StringAlignment.Far;
            formatLeft.Alignment = StringAlignment.Near;

            SizeF layoutSize = new SizeF(285 - Offset * 2, lineheight14);
            RectangleF layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            Brush brush = Brushes.Black;
            //title
            graphics.DrawString("Welcome to SOFOK", font14, brush, layout, formatCenter);
            Offset = Offset + lineheight14;

            //recipt no.
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            graphics.DrawString("Recept No :" + merchant_list.merchantDisplay.merch_id + 2022192, font7, brush, layout, formatLeft);
            Offset = Offset + lineheight14;

            //date
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            graphics.DrawString("Date :" + DateTime.Today, font7, brush, layout, formatLeft);
            Offset = Offset + lineheight12;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);


            graphics.DrawString("Store name:"+merchant_list.merchantDisplay.merch_store, font7, brush, layout, formatLeft);
            Offset = Offset + lineheight14;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            graphics.DrawString("Merchan name:"+merchant_list.merchantDisplay.merch_name, font7, brush, layout, formatLeft);
            Offset = Offset + lineheight14;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);







            //line
            graphics.DrawString("".PadRight(46, '_'), font7, brush, layout, formatLeft);
            Offset = Offset + lineheight10;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            //order num
            graphics.DrawString("25", font25, brush, layout, formatCenter);
            Offset = Offset + lineheight14;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);
            graphics.DrawString("", font7, brush, layout, formatLeft);
            Offset = Offset + lineheight10;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            //order text
            graphics.DrawString("Order Number", font12, brush, layout, formatCenter);
            Offset = Offset + lineheight14;
            layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

       font10.Dispose(); font12.Dispose(); font14.Dispose(); font7.Dispose(); font25.Dispose();

          ;

        }
    }
    }

