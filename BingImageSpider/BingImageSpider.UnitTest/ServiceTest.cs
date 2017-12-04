using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BingImageSpider.Common;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Xml;
using System.Net;
using System.IO;

namespace BingImageSpider.UnitTest
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string bingImageUrl = ConfigHelper.GetSetting<string>("BingImageAPI", "https://cn.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1");
            string bingLonlatUrl = ConfigHelper.GetSetting<string>("BingLonlatAPI", "https://cn.bing.com/cnhp/life");
            string localImagePath = ConfigHelper.GetSetting<string>("ImagePath", "E:/Images");

            string imageJson = HttpHelper.Get_Http(bingImageUrl);
            Regex regexUrl = new Regex(@"\""url""\:\s*""(?'url'[^""]*)""", RegexOptions.IgnoreCase);
            Regex regexCopyright = new Regex(@"\""copyright""\:\s*""(?'copyright'[^""]*)""", RegexOptions.IgnoreCase);
            if (regexUrl.IsMatch(imageJson) && regexCopyright.IsMatch(imageJson))
            {
                string url = regexUrl.Match(imageJson).Groups["url"].Value;
                string copyright = regexCopyright.Match(imageJson).Groups["copyright"].Value;
                string imageUrl = string.Format("https://cn.bing.com{0}", url);
                FileHelper.DownloadFile(imageUrl, localImagePath + "/" + DateTime.Now.ToString("yyyyMMdd") + FileHelper.GetPostfixStr(url));
            }
            HtmlWeb webClient = new HtmlWeb();
            HtmlDocument doc = webClient.Load(bingLonlatUrl);
            string href = doc.DocumentNode.SelectSingleNode("//a[@class='hplaDMLink']").Attributes["href"].Value;
            href.Replace("&amp;", "&");
            Regex reg = new Regex(@"[^\?&]?lat=[^&]+", RegexOptions.IgnoreCase);
            if (reg.IsMatch(href))
            {
                string lat = reg.Match(href).Groups["lat"].Value;
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            string bingImageUrl = ConfigHelper.GetSetting<string>("BingImageAPI", "https://cn.bing.com/HPImageArchive.aspx?idx=0&n=1");
            var doc =XmlHelper.GetXmlByUrl(bingImageUrl);
            var urlNode = doc.SelectSingleNode("//images//image//url");
        }
    }
}
