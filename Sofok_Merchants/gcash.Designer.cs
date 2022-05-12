namespace SOFOK_System.Sofok_Merchants
{
    partial class gcash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gcash));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.lbl_total_amount = new Bunifu.UI.WinForms.BunifuLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_done = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.QR_img = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QR_img)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.btn_done);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_total_amount);
            this.bunifuShadowPanel1.Controls.Add(this.QR_img);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(22, 22);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(1399, 844);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // lbl_total_amount
            // 
            this.lbl_total_amount.AllowParentOverrides = false;
            this.lbl_total_amount.AutoEllipsis = false;
            this.lbl_total_amount.AutoSize = false;
            this.lbl_total_amount.CursorType = null;
            this.lbl_total_amount.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold);
            this.lbl_total_amount.Location = new System.Drawing.Point(85, 684);
            this.lbl_total_amount.Name = "lbl_total_amount";
            this.lbl_total_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_total_amount.Size = new System.Drawing.Size(1229, 106);
            this.lbl_total_amount.TabIndex = 10;
            this.lbl_total_amount.Text = "TOTAL";
            this.lbl_total_amount.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_total_amount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_done
            // 
            this.btn_done.AllowAnimations = true;
            this.btn_done.AllowMouseEffects = true;
            this.btn_done.AllowToggling = false;
            this.btn_done.AnimationSpeed = 200;
            this.btn_done.AutoGenerateColors = false;
            this.btn_done.AutoRoundBorders = false;
            this.btn_done.AutoSizeLeftIcon = true;
            this.btn_done.AutoSizeRightIcon = true;
            this.btn_done.BackColor = System.Drawing.Color.Transparent;
            this.btn_done.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_done.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_done.BackgroundImage")));
            this.btn_done.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.ButtonText = "Done";
            this.btn_done.ButtonTextMarginLeft = 0;
            this.btn_done.ColorContrastOnClick = 45;
            this.btn_done.ColorContrastOnHover = 45;
            this.btn_done.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_done.CustomizableEdges = borderEdges1;
            this.btn_done.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_done.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_done.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_done.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_done.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_done.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.IconLeft = null;
            this.btn_done.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_done.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_done.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_done.IconMarginLeft = 11;
            this.btn_done.IconPadding = 10;
            this.btn_done.IconRight = null;
            this.btn_done.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_done.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_done.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_done.IconSize = 25;
            this.btn_done.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_done.IdleBorderRadius = 0;
            this.btn_done.IdleBorderThickness = 0;
            this.btn_done.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_done.IdleIconLeftImage = null;
            this.btn_done.IdleIconRightImage = null;
            this.btn_done.IndicateFocus = false;
            this.btn_done.Location = new System.Drawing.Point(625, 796);
            this.btn_done.Name = "btn_done";
            this.btn_done.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_done.OnDisabledState.BorderRadius = 1;
            this.btn_done.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.OnDisabledState.BorderThickness = 1;
            this.btn_done.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_done.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_done.OnDisabledState.IconLeftImage = null;
            this.btn_done.OnDisabledState.IconRightImage = null;
            this.btn_done.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_done.onHoverState.BorderRadius = 1;
            this.btn_done.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.onHoverState.BorderThickness = 1;
            this.btn_done.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_done.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_done.onHoverState.IconLeftImage = null;
            this.btn_done.onHoverState.IconRightImage = null;
            this.btn_done.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_done.OnIdleState.BorderRadius = 1;
            this.btn_done.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.OnIdleState.BorderThickness = 1;
            this.btn_done.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_done.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_done.OnIdleState.IconLeftImage = null;
            this.btn_done.OnIdleState.IconRightImage = null;
            this.btn_done.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_done.OnPressedState.BorderRadius = 1;
            this.btn_done.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_done.OnPressedState.BorderThickness = 1;
            this.btn_done.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_done.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_done.OnPressedState.IconLeftImage = null;
            this.btn_done.OnPressedState.IconRightImage = null;
            this.btn_done.Size = new System.Drawing.Size(149, 32);
            this.btn_done.TabIndex = 11;
            this.btn_done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_done.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_done.TextMarginLeft = 0;
            this.btn_done.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_done.UseDefaultRadiusAndThickness = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // QR_img
            // 
            this.QR_img.AllowFocused = false;
            this.QR_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QR_img.AutoSizeHeight = true;
            this.QR_img.BorderRadius = 0;
            this.QR_img.Image = ((System.Drawing.Image)(resources.GetObject("QR_img.Image")));
            this.QR_img.IsCircle = true;
            this.QR_img.Location = new System.Drawing.Point(371, 17);
            this.QR_img.Name = "QR_img";
            this.QR_img.Size = new System.Drawing.Size(661, 661);
            this.QR_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QR_img.TabIndex = 9;
            this.QR_img.TabStop = false;
            this.QR_img.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // gcash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 878);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gcash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gcash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.gcash_Shown);
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QR_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_done;
        private Bunifu.UI.WinForms.BunifuLabel lbl_total_amount;
        private Bunifu.UI.WinForms.BunifuPictureBox QR_img;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}