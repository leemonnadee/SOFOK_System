
namespace SOFOK_System.components
{
    partial class orderwidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderwidget));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ordernumber = new Bunifu.UI.WinForms.BunifuLabel();
            this.widget1 = new SOFOK_System.components.widget();
            this.widget2 = new SOFOK_System.components.widget();
            this.widget3 = new SOFOK_System.components.widget();
            this.bunifuPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.flowLayoutPanel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(11, 9);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(350, 326);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.widget1);
            this.flowLayoutPanel1.Controls.Add(this.ordernumber);
            this.flowLayoutPanel1.Controls.Add(this.widget2);
            this.flowLayoutPanel1.Controls.Add(this.widget3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 326);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ordernumber
            // 
            this.ordernumber.AllowParentOverrides = false;
            this.ordernumber.AutoEllipsis = false;
            this.ordernumber.CursorType = System.Windows.Forms.Cursors.Default;
            this.ordernumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordernumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.ordernumber.Location = new System.Drawing.Point(264, 3);
            this.ordernumber.Name = "ordernumber";
            this.ordernumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ordernumber.Size = new System.Drawing.Size(64, 19);
            this.ordernumber.TabIndex = 3;
            this.ordernumber.Text = "ORDER #";
            this.ordernumber.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ordernumber.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // widget1
            // 
            this.widget1.BackColor = System.Drawing.Color.Transparent;
            this.widget1.Category = SOFOK_System.components.widget.categories.food;
            this.widget1.Cost = 0D;
            this.widget1.Icon = ((System.Drawing.Image)(resources.GetObject("widget1.Icon")));
            this.widget1.Location = new System.Drawing.Point(2, 2);
            this.widget1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widget1.Name = "widget1";
            this.widget1.Size = new System.Drawing.Size(257, 176);
            this.widget1.Store = "Store";
            this.widget1.TabIndex = 4;
            this.widget1.Title = "label1";
            // 
            // widget2
            // 
            this.widget2.BackColor = System.Drawing.Color.Transparent;
            this.widget2.Category = SOFOK_System.components.widget.categories.food;
            this.widget2.Cost = 0D;
            this.widget2.Icon = ((System.Drawing.Image)(resources.GetObject("widget2.Icon")));
            this.widget2.Location = new System.Drawing.Point(2, 182);
            this.widget2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widget2.Name = "widget2";
            this.widget2.Size = new System.Drawing.Size(257, 176);
            this.widget2.Store = "Store";
            this.widget2.TabIndex = 5;
            this.widget2.Title = "label1";
            // 
            // widget3
            // 
            this.widget3.BackColor = System.Drawing.Color.Transparent;
            this.widget3.Category = SOFOK_System.components.widget.categories.food;
            this.widget3.Cost = 0D;
            this.widget3.Icon = ((System.Drawing.Image)(resources.GetObject("widget3.Icon")));
            this.widget3.Location = new System.Drawing.Point(2, 362);
            this.widget3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widget3.Name = "widget3";
            this.widget3.Size = new System.Drawing.Size(257, 176);
            this.widget3.Store = "Store";
            this.widget3.TabIndex = 6;
            this.widget3.Title = "label1";
            // 
            // orderwidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "orderwidget";
            this.Size = new System.Drawing.Size(371, 346);
            this.bunifuPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuLabel ordernumber;
        private widget widget1;
        private widget widget2;
        private widget widget3;
    }
}
