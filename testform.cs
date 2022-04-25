using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOFOK_System
{
    public partial class testform : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=12345;database=sofok_db");
        MySqlCommand command;
        MySqlDataAdapter da;
       
        public testform()
        {
            InitializeComponent();
            show();
        }

        public void show()

        {


        }
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testform_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM sofok_db.tbl_products ";
            command = new MySqlCommand(selectQuery, connection);
            da = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            txt_ID.Text = table.Rows[0][5].ToString();
           byte[] img = (byte[])table.Rows[0][5];
            MemoryStream ms = new MemoryStream(img);
            picbox.Image = Image.FromStream(ms);

            da.Dispose();
        }
    }
}
