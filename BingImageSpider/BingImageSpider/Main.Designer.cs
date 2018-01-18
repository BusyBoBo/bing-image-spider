namespace BingImageSpider
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuShowWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.bingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bingMenu
            // 
            this.bingMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShowWindow,
            this.menuClose});
            this.bingMenu.Name = "bingMenu";
            this.bingMenu.Size = new System.Drawing.Size(145, 56);
            // 
            // menuShowWindow
            // 
            this.menuShowWindow.Name = "menuShowWindow";
            this.menuShowWindow.Size = new System.Drawing.Size(144, 26);
            this.menuShowWindow.Text = "显示窗口";
            this.menuShowWindow.Click += new System.EventHandler(this.menuShowWindow_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(144, 26);
            this.menuClose.Text = "关闭";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.bingMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Tag = "必应背景图片服务";
            this.notifyIcon.Text = "必应背景图片服务(BingSpiderService)";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(-1, 0);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(567, 306);
            this.txtLogs.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 305);
            this.Controls.Add(this.txtLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(580, 350);
            this.MinimumSize = new System.Drawing.Size(580, 350);
            this.Name = "Main";
            this.Text = "必应官网背景图抓取程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.BingForm_Load);
            this.bingMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip bingMenu;
        private System.Windows.Forms.ToolStripMenuItem menuShowWindow;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txtLogs;
    }
}