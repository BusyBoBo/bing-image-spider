using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingImageSpider.Common
{
    public class PTextBoxTraceListener : TraceListener
    {
        private TextBox textbox;

        public PTextBoxTraceListener(TextBox textbox)
        {
            this.textbox = textbox;
        }

        public delegate void CBString(string a);

        public override void Write(string message)
        {
            if (this.textbox.InvokeRequired)
            {
                CBString method = new CBString(this.Write);
                this.textbox.Invoke(method, new object[]
                {
                    message
                });
                return;
            }
            if (this.textbox.MaxLength < this.textbox.Text.Length + message.Length)
            {
                this.textbox.Text = message;
            }
            else
            {
                TextBox expr_6D = this.textbox;
                expr_6D.Text += message;
            }
            if (this.textbox.Text.Length >= 2)
            {
                this.textbox.Select(this.textbox.Text.Length - 2, 2);
                this.textbox.ScrollToCaret();
            }
        }

        public override void WriteLine(string message)
        {
            this.Write(message + "\r\n");
        }
    }
}
