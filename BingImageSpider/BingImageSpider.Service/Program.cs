using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using BingImageSpider.Common;

namespace BingImageSpider.Service
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            string url = "https://cn.bing.com/";
            HttpHelper.Get_Http(url);
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new BingSpiderService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
