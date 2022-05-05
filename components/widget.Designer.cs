
namespace SOFOK_System.components
{
    partial class widget
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(widget));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_store = new System.Windows.Forms.Label();
            this.img = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbl_ID);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.lbl_Price);
            this.bunifuPanel1.Controls.Add(this.lbl_store);
            this.bunifuPanel1.Controls.Add(this.img);
            this.bunifuPanel1.Controls.Add(this.lbl_Title);
            this.bunifuPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel1.Location = new System.Drawing.Point(9, 10);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(333, 197);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(43)))), ((int)(((byte)(7)))));
            this.lbl_ID.Location = new System.Drawing.Point(205, 12);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(84, 20);
            this.lbl_ID.TabIndex = 10;
            this.lbl_ID.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(3, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Store :";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Price.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_Price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Price.Location = new System.Drawing.Point(17, 78);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(39, 29);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "12";
            this.lbl_Price.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_store.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(43)))), ((int)(((byte)(7)))));
            this.lbl_store.Location = new System.Drawing.Point(31, 162);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(91, 18);
            this.lbl_store.TabIndex = 8;
            this.lbl_store.Text = "Store Name";
            this.lbl_store.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // img
            // 
            this.img.AllowFocused = false;
            this.img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img.AutoSizeHeight = true;
            this.img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.img.BorderRadius = 0;
            this.img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img.Image = global::SOFOK_System.Properties.Resources.tableware_100px;
            this.img.IsCircle = true;
            this.img.Location = new System.Drawing.Point(191, 47);
            this.img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(127, 127);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 6;
            this.img.TabStop = false;
            this.img.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.img.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(43)))), ((int)(((byte)(7)))));
            this.lbl_Title.Location = new System.Drawing.Point(23, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(110, 20);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Product Name";
            this.lbl_Title.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "widget";
            this.Size = new System.Drawing.Size(343, 217);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.UI.WinForms.BunifuPictureBox img;
        public System.Windows.Forms.Label lbl_Price;
        public System.Windows.Forms.Label lbl_Title;
        public System.Windows.Forms.Label lbl_store;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_ID;
    }
}
