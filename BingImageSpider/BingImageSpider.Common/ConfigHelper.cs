using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingImageSpider.Common
{
    public class ConfigHelper
    {
        /// <summary>
        /// 获取配置信息中当前键值对应的值，并转换为相应的类型
        /// </summary>
        /// <typeparam name="T">要转换的类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>值</returns>
        public static T GetSetting<T>(string key, T defaultValue)
        {
            var value = ConfigurationManager.AppSettings[key];
            if (value != null && !value.Equals(default(T)))
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            return defaultValue;
        }
    }
}
