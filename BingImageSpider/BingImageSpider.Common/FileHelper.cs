using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BingImageSpider.Common
{
    public class FileHelper
    {
        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="directoryPath">目录的绝对路径</param>
        public static void CreateDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                DirectorySecurity dirSecurity = di.GetAccessControl();
                dirSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                dirSecurity.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
                di.SetAccessControl(dirSecurity);
            }
        }

        /// <summary>
        /// 获取后缀名
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <returns>.gif|.html格式</returns>
        public static string GetPostfixStr(string filename)
        {
            int start = filename.LastIndexOf(".");
            int length = filename.Length;
            string postfix = filename.Substring(start, length - start);
            return postfix;
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="remoteUrl">文件远程地址</param>
        /// <param name="localUrl">文件保存地址</param>
        public static void DownloadFile(string remoteUrl, string localUrl)
        {
            try
            {
                CreateDirectory(localUrl);
                using (WebClient webClient = new WebClient())
                {
                    Uri uri = new Uri(remoteUrl);
                    webClient.DownloadFile(uri, localUrl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
