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
    public partial class BingForm : Form
    {
        private FormWindowState tmpFormWindowState;
        private Size tmpFormSize;
        private Point tmpFormLocation;
        private bool IsClose = false;

        public BingForm()
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
    }
}
