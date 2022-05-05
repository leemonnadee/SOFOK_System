namespace SOFOK_System.components
{
    partial class merchant_widget
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
            this.bl_Store_Name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_prod_Number = new System.Windows.Forms.Label();
            this.lbl_merchant_Name = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bl_Store_Name
            // 
            this.bl_Store_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bl_Store_Name.AutoSize = true;
            this.bl_Store_Name.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_Store_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bl_Store_Name.Location = new System.Drawing.Point(81, 249);
            this.bl_Store_Name.Name = "bl_Store_Name";
            this.bl_Store_Name.Size = new System.Drawing.Size(216, 40);
            this.bl_Store_Name.TabIndex = 1;
            this.bl_Store_Name.Text = "Store Name";
            this.bl_Store_Name.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(28, 44);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 16);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            this.lbl_id.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // lbl_prod_Number
            // 
            this.lbl_prod_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_prod_Number.AutoSize = true;
            this.lbl_prod_Number.Font = new System.Drawing.Font("Algerian", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod_Number.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_prod_Number.Location = new System.Drawing.Point(346, 104);
            this.lbl_prod_Number.Name = "lbl_prod_Number";
            this.lbl_prod_Number.Size = new System.Drawing.Size(134, 89);
            this.lbl_prod_Number.TabIndex = 3;
            this.lbl_prod_Number.Text = "00";
            this.lbl_prod_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_prod_Number.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // lbl_merchant_Name
            // 
            this.lbl_merchant_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_merchant_Name.AutoSize = true;
            this.lbl_merchant_Name.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_merchant_Name.Location = new System.Drawing.Point(83, 305);
            this.lbl_merchant_Name.Name = "lbl_merchant_Name";
            this.lbl_merchant_Name.Size = new System.Drawing.Size(173, 25);
            this.lbl_merchant_Name.TabIndex = 4;
            this.lbl_merchant_Name.Text = "merchant Name";
            this.lbl_merchant_Name.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 15;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuShapes2);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuShapes1);
            this.bunifuShadowPanel1.Controls.Add(this.label2);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuPictureBox2);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_prod_Number);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_merchant_Name);
            this.bunifuShadowPanel1.Controls.Add(this.bl_Store_Name);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_id);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(12, 17);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(599, 388);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 5;
            this.bunifuShadowPanel1.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(75, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 15;
            this.bunifuPictureBox1.Image = global::SOFOK_System.Properties.Resources.user_orange;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(44, 305);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(31, 31);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 6;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 22;
            this.bunifuPictureBox2.Image = global::SOFOK_System.Properties.Resources.stall_orange_100px;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(31, 249);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(44, 44);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 7;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox2.Click += new System.EventHandler(this.bunifuShadowPanel1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(81, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 0F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes1.BorderThickness = 2;
            this.bunifuShapes1.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(361, 196);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(101, 16);
            this.bunifuShapes1.TabIndex = 9;
            this.bunifuShapes1.Text = "bunifuShapes1";
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Angle = 0F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes2.BorderThickness = 2;
            this.bunifuShapes2.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(507, 226);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(8, 8);
            this.bunifuShapes2.TabIndex = 10;
            this.bunifuShapes2.Text = "bunifuShapes2";
            // 
            // merchant_widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "merchant_widget";
            this.Size = new System.Drawing.Size(622, 405);
            this.Load += new System.EventHandler(this.merchant_widget_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label bl_Store_Name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_prod_Number;
        private System.Windows.Forms.Label lbl_merchant_Name;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
    }
}
