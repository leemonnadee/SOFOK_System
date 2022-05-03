
namespace SOFOK_System.Sofok_Merchants
{
    partial class uploadImage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uploadImage));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_exit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(139)))), ((int)(((byte)(30)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btn_exit);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(705, 84);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.ActiveImage = null;
            this.btn_exit.AllowAnimations = true;
            this.btn_exit.AllowBuffering = false;
            this.btn_exit.AllowToggling = false;
            this.btn_exit.AllowZooming = true;
            this.btn_exit.AllowZoomingOnFocus = false;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(139)))), ((int)(((byte)(30)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_exit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.ErrorImage")));
            this.btn_exit.FadeWhenInactive = false;
            this.btn_exit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_exit.Image = global::SOFOK_System.Properties.Resources.Close_40px;
            this.btn_exit.ImageActive = null;
            this.btn_exit.ImageLocation = null;
            this.btn_exit.ImageMargin = 20;
            this.btn_exit.ImageSize = new System.Drawing.Size(19, 19);
            this.btn_exit.ImageZoomSize = new System.Drawing.Size(39, 39);
            this.btn_exit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.InitialImage")));
            this.btn_exit.Location = new System.Drawing.Point(666, 2);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Rotation = 0;
            this.btn_exit.ShowActiveImage = true;
            this.btn_exit.ShowCursorChanges = true;
            this.btn_exit.ShowImageBorders = true;
            this.btn_exit.ShowSizeMarkers = false;
            this.btn_exit.Size = new System.Drawing.Size(39, 39);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.ToolTipText = "";
            this.btn_exit.WaitOnLoad = false;
            this.btn_exit.Zoom = 20;
            this.btn_exit.ZoomSpeed = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // uploadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 606);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uploadImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uploadImage";
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_exit;
    }
}