using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using BingImageSpider.Common;

namespace BingImageSpider
{
    public partial class BingSpider_Service : ServiceBase
    {
        public BingSpider_Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            LogHelper.Listeners.Clear();
            Host.Start();

            string url="https://cn.bing.com/";
            HttpHelper.Get_Http(url);
        }

        protected override void OnStop()
        {
            Host.Stop();
        }
    }
}
