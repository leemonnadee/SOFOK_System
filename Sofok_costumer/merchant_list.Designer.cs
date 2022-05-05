
namespace SOFOK_System.Sofok_costumer
{
    partial class merchant_list
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
            this.components = new System.ComponentModel.Container();
            this.docker = new Bunifu.UI.WinForms.BunifuFormDock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.merchant_widget = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // docker
            // 
            this.docker.AllowFormDragging = true;
            this.docker.AllowFormDropShadow = true;
            this.docker.AllowFormResizing = true;
            this.docker.AllowHidingBottomRegion = true;
            this.docker.AllowOpacityChangesWhileDragging = false;
            this.docker.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.BottomBorder.BorderThickness = 1;
            this.docker.BorderOptions.BottomBorder.ShowBorder = true;
            this.docker.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.LeftBorder.BorderThickness = 1;
            this.docker.BorderOptions.LeftBorder.ShowBorder = true;
            this.docker.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.RightBorder.BorderThickness = 1;
            this.docker.BorderOptions.RightBorder.ShowBorder = true;
            this.docker.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.docker.BorderOptions.TopBorder.BorderThickness = 1;
            this.docker.BorderOptions.TopBorder.ShowBorder = true;
            this.docker.ContainerControl = this;
            this.docker.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.docker.DockingIndicatorsOpacity = 0.5D;
            this.docker.DockingOptions.DockAll = true;
            this.docker.DockingOptions.DockBottomLeft = true;
            this.docker.DockingOptions.DockBottomRight = true;
            this.docker.DockingOptions.DockFullScreen = true;
            this.docker.DockingOptions.DockLeft = true;
            this.docker.DockingOptions.DockRight = true;
            this.docker.DockingOptions.DockTopLeft = true;
            this.docker.DockingOptions.DockTopRight = true;
            this.docker.FormDraggingOpacity = 0.9D;
            this.docker.ParentForm = this;
            this.docker.ShowCursorChanges = true;
            this.docker.ShowDockingIndicators = true;
            this.docker.TitleBarOptions.AllowFormDragging = true;
            this.docker.TitleBarOptions.BunifuFormDock = this.docker;
            this.docker.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.docker.TitleBarOptions.TitleBarControl = null;
            this.docker.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            this.docker.FormDragging += new System.EventHandler<Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs>(this.bunifuFormDock1_FormDragging);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(389, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Stores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 150);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1121, 713);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // merchant_widget
            // 
            this.merchant_widget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.merchant_widget.AutoScroll = true;
            this.merchant_widget.BackColor = System.Drawing.Color.White;
            this.merchant_widget.Location = new System.Drawing.Point(140, 152);
            this.merchant_widget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.merchant_widget.Name = "merchant_widget";
            this.merchant_widget.Size = new System.Drawing.Size(1081, 527);
            this.merchant_widget.TabIndex = 4;
            // 
            // merchant_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 799);
            this.Controls.Add(this.merchant_widget);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "merchant_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "merchant_list";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.merchant_list_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuFormDock docker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel merchant_widget;
    }
}