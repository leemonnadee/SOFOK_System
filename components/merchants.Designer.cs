
namespace SOFOK_System.components
{
    partial class merchants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(merchants));
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bl_Store_Name = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_merchant_Name = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_prod_Number = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_available_prod = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 25;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.lbl_available_prod);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_prod_Number);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_merchant_Name);
            this.bunifuShadowPanel1.Controls.Add(this.bl_Store_Name);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(324, 317);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // bl_Store_Name
            // 
            this.bl_Store_Name.AllowParentOverrides = false;
            this.bl_Store_Name.AutoEllipsis = false;
            this.bl_Store_Name.CursorType = System.Windows.Forms.Cursors.Default;
            this.bl_Store_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.bl_Store_Name.ForeColor = System.Drawing.Color.Navy;
            this.bl_Store_Name.Location = new System.Drawing.Point(76, 189);
            this.bl_Store_Name.Name = "bl_Store_Name";
            this.bl_Store_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bl_Store_Name.Size = new System.Drawing.Size(170, 33);
            this.bl_Store_Name.TabIndex = 0;
            this.bl_Store_Name.Text = "Merchant Store";
            this.bl_Store_Name.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bl_Store_Name.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_merchant_Name
            // 
            this.lbl_merchant_Name.AllowParentOverrides = false;
            this.lbl_merchant_Name.AutoEllipsis = false;
            this.lbl_merchant_Name.CursorType = null;
            this.lbl_merchant_Name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_merchant_Name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_merchant_Name.Location = new System.Drawing.Point(87, 227);
            this.lbl_merchant_Name.Name = "lbl_merchant_Name";
            this.lbl_merchant_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_merchant_Name.Size = new System.Drawing.Size(142, 25);
            this.lbl_merchant_Name.TabIndex = 1;
            this.lbl_merchant_Name.Text = "Merchant Name";
            this.lbl_merchant_Name.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_merchant_Name.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_prod_Number
            // 
            this.lbl_prod_Number.AllowParentOverrides = false;
            this.lbl_prod_Number.AutoEllipsis = false;
            this.lbl_prod_Number.CursorType = null;
            this.lbl_prod_Number.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_prod_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_prod_Number.Location = new System.Drawing.Point(130, 114);
            this.lbl_prod_Number.Name = "lbl_prod_Number";
            this.lbl_prod_Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_prod_Number.Size = new System.Drawing.Size(56, 64);
            this.lbl_prod_Number.TabIndex = 2;
            this.lbl_prod_Number.Text = "00";
            this.lbl_prod_Number.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_prod_Number.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_available_prod
            // 
            this.lbl_available_prod.AllowParentOverrides = false;
            this.lbl_available_prod.AutoEllipsis = false;
            this.lbl_available_prod.CursorType = null;
            this.lbl_available_prod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_available_prod.Location = new System.Drawing.Point(87, 69);
            this.lbl_available_prod.Name = "lbl_available_prod";
            this.lbl_available_prod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_available_prod.Size = new System.Drawing.Size(165, 25);
            this.lbl_available_prod.TabIndex = 3;
            this.lbl_available_prod.Text = "Available Products";
            this.lbl_available_prod.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_available_prod.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // merchants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "merchants";
            this.Size = new System.Drawing.Size(324, 317);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bl_Store_Name;
        private Bunifu.UI.WinForms.BunifuLabel lbl_available_prod;
        private Bunifu.UI.WinForms.BunifuLabel lbl_prod_Number;
        private Bunifu.UI.WinForms.BunifuLabel lbl_merchant_Name;
    }
}
