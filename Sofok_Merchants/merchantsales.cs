using LiveCharts;
using LiveCharts.Wpf;
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


using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace SOFOK_System
{
    public partial class merchantsales : Form
    {
        string mycon = "datasource=localhost;username=root;password=;database=sofok_db";
        string show_data;
        public merchantsales()
        {

            InitializeComponent();
            combo_log.SelectedIndex = 0;

        }

        public void total_product()
        {

            try
            {

                string query = "SELECT COUNT(prod_id)FROM `tbl_products` WHERE tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);




                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String total_product = myreader1.GetString("COUNT(prod_id)");
                    lbl_tot_product.Text = total_product;


                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void gcash()
        {

            try
            {

                string query = "SELECT SUM(cost) FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_orders.status='accepted' and tbl_orders.payment='gcash' and tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);




                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String total_gcash = myreader1.GetString("SUM(cost)");
                    lbl_gcash.Text = total_gcash;


                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void cashier()
        {

            try
            {

                string query = "SELECT SUM(cost) FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_orders.status='accepted' and tbl_orders.payment='cashier' and tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);




                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String total_cashier = myreader1.GetString("SUM(cost)");
                    lbl_cashier.Text = total_cashier;


                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void get_monthly()
        {

            try
            {

                string query = "SELECT SUM(cost) FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id  INNER JOIN tbl_costumer ON tbl_orders.costumer_id=tbl_costumer.costumer_id WHERE tbl_orders.status = 'accepted' and tbl_products.merchant_id = '" + loginform.UserDisplay.MerchantID + "' and month(tbl_costumer.date)= month(CURRENT_DATE)";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);




                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String monthly_sales = myreader1.GetString("SUM(cost)");
                    lbl_monthly_sales.Text = monthly_sales;


                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void get_daily()
        {

            try
            {

                string query = "SELECT SUM(cost) FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id  INNER JOIN tbl_costumer ON tbl_orders.costumer_id=tbl_costumer.costumer_id WHERE tbl_orders.status = 'accepted' and tbl_products.merchant_id = '" + loginform.UserDisplay.MerchantID + "' and tbl_costumer.date=CURRENT_DATE";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);




                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String daily_sales = myreader1.GetString("SUM(cost)");
                    lbl_daily_sales.Text = daily_sales;


                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void show_total_sales()
        {
           
            try
            {

                string query = "SELECT count(DISTINCT(costumer_id)),SUM(cost) FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_orders.status='accepted' and tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "'";
                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(query, conn);



              
                MySqlDataReader myreader1;

                conn.Open();

                myreader1 = mycommand.ExecuteReader();
                while (myreader1.Read())
                {
                    String total_sales = myreader1.GetString("sum(cost)");
                    lbl_tot_sale.Text = total_sales;
                    String total_costumer = myreader1.GetString("count(DISTINCT(costumer_id))");
                    lbl_tot_costumer.Text = total_costumer;

                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }



        private void combo_log_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_log.Text == ("Accepted Orders"))
                {
                    show_data = "SELECT tbl_orders.status,tbl_orders.`costumer_id`,tbl_orders.`item`,tbl_orders.`qty`,tbl_orders.`cost`,tbl_orders.`store`,tbl_orders.`prod_id` FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "'and status='accepted'GROUP BY tbl_orders.costumer_id";

                }
                else if (combo_log.Text == ("Pending Orders"))
                {
                    show_data = "SELECT tbl_orders.status,tbl_orders.`costumer_id`,tbl_orders.`item`,tbl_orders.`qty`,tbl_orders.`cost`,tbl_orders.`store`,tbl_orders.`prod_id` FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "'and status='pending' GROUP BY tbl_orders.costumer_id";


                }
                else if (combo_log.Text == ("Orders"))
                {
                    show_data = "SELECT tbl_orders.status,tbl_orders.`costumer_id`,tbl_orders.`item`,tbl_orders.`qty`,tbl_orders.`cost`,tbl_orders.`store`,tbl_orders.`prod_id` FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "' GROUP BY tbl_orders.costumer_id";


                }


                else if (combo_log.Text == ("Declined Orders"))
                {
                    show_data = "SELECT tbl_orders.status,tbl_orders.`costumer_id`,tbl_orders.`item`,tbl_orders.`qty`,tbl_orders.`cost`,tbl_orders.`store`,tbl_orders.`prod_id` FROM `tbl_orders` INNER JOIN tbl_products ON tbl_orders.prod_id=tbl_products.prod_id WHERE tbl_products.merchant_id='" + loginform.UserDisplay.MerchantID + "'and status='decline' GROUP BY tbl_orders.costumer_id";


                }




                MySqlConnection conn = new MySqlConnection(mycon);
                MySqlCommand mycommand = new MySqlCommand(show_data, conn);

                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                DataTable dtable = new DataTable();
                grid_sales.DataSource = dtable;

                myadapter.Fill(dtable);






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









        }

        private void merchantsales_Shown(object sender, EventArgs e)
        {

            show_total_sales();
            total_product();
            gcash();
            cashier();
            get_monthly();
            get_daily();

        }

        private void copyAlltoClipboard()
        {
            grid_sales.SelectAll();
            DataObject dataObj = grid_sales.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }



        private void export_btn_Click(object sender, EventArgs e)
        {
            if (grid_sales.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grid_sales.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                          
                            foreach (DataGridViewColumn column in grid_sales.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in grid_sales.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }







    }
}
