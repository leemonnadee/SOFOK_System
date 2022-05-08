
namespace SOFOK_System
{
    partial class merchantorders
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
            this.order_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.docker = new Bunifu.UI.WinForms.BunifuFormDock();
            this.flowlayout_orders = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // order_flowPanel
            // 
            this.order_flowPanel.AutoSize = true;
            this.order_flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.order_flowPanel.BackColor = System.Drawing.Color.White;
            this.order_flowPanel.Location = new System.Drawing.Point(0, 0);
            this.order_flowPanel.Name = "order_flowPanel";
            this.order_flowPanel.Size = new System.Drawing.Size(0, 0);
            this.order_flowPanel.TabIndex = 1;
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
            // 
            // flowlayout_orders
            // 
            this.flowlayout_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowlayout_orders.AutoScroll = true;
            this.flowlayout_orders.BackColor = System.Drawing.Color.White;
            this.flowlayout_orders.Location = new System.Drawing.Point(20, 70);
            this.flowlayout_orders.Margin = new System.Windows.Forms.Padding(2);
            this.flowlayout_orders.Name = "flowlayout_orders";
            this.flowlayout_orders.Size = new System.Drawing.Size(740, 530);
            this.flowlayout_orders.TabIndex = 2;
            // 
            // merchantorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 670);
            this.Controls.Add(this.flowlayout_orders);
            this.Controls.Add(this.order_flowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "merchantorders";
            this.Text = "merchantorders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.merchantorders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel order_flowPanel;
        private Bunifu.UI.WinForms.BunifuFormDock docker;
        private System.Windows.Forms.FlowLayoutPanel flowlayout_orders;
    }
}