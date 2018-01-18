using BingImageSpider.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingImageSpider
{
    public partial class Main : Form
    {
        private FormWindowState tmpFormWindowState;
        private Size tmpFormSize;
        private Point tmpFormLocation;
        private bool IsClose = false;

        public Main()
        {
            InitializeComponent();
        }

        private void BingForm_Load(object sender, EventArgs e)
        {
            try
            {
                LogHelper.Listeners.Clear();
                LogHelper.Listeners.Add(new PTextBoxTraceListener(this.txtLogs));
                this.notifyIcon.Visible = true;
                this.Visible = true;
                Host.Start();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            try
            {
                if (((MouseEventArgs)e).Button == MouseButtons.Left)
                {
                    if (this.Visible)
                    {
                        this.tmpFormWindowState = this.WindowState;
                        this.tmpFormSize = this.Size;
                        this.tmpFormLocation = this.Location;
                        this.Visible = false;
                    }
                    else
                    {
                        this.Visible = true;
                        this.WindowState = tmpFormWindowState;
                        this.Size = tmpFormSize;
                        this.Location = tmpFormLocation;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            IsClose = true;
            Close();
        }

        private void menuShowWindow_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = tmpFormWindowState;
                this.Size = tmpFormSize;
                this.Location = tmpFormLocation;
                this.Visible = true;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.WindowsShutDown || IsClose)
                {
                    return;
                }
                e.Cancel = true;
                this.tmpFormWindowState = this.WindowState;
                this.tmpFormSize = this.Size;
                this.tmpFormLocation = this.Location;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
