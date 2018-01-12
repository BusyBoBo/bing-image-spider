using BingImageSpider.Common;
using System;
using System.ServiceModel;

namespace BingImageSpider
{
    internal static class Host
    {
        private static ServiceHost host;

        public static void Start()
        {
            try
            {
                LogHelper.LogInformation("Bing网站抓图服务正在启动...");
                if (host != null)
                {
                    //host = new ServiceHost(typeof(ServiceBE));
                    host.Open();
                }
                LogHelper.LogInformation("Bing网站抓图服务开启成功.");
            }
            catch (Exception ex)
            {
                try
                {
                    if (host != null)
                    {
                        host.Abort();
                    }
                }
                catch
                {
                }
                finally
                {
                    host = null;
                }
                LogHelper.LogError(ex);
            }
        }

        public static void Stop()
        {
            try
            {
                LogHelper.LogInformation("Bing网站抓图服务正在停止...");
                if (host != null)
                {
                    host.Close();
                }
                LogHelper.LogInformation("Bing网站抓图服务停止成功.");
            }
            catch (Exception ex)
            {
                try
                {
                    if (host != null)
                    {
                        host.Abort();
                    }
                }
                catch
                {
                }
                LogHelper.LogError(ex);
            }
            finally
            {
                host = null;
            }
        }
    }
}
