using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingImageSpider.Common
{
    public static class LogHelper
    {
        private const string FLAG_INFORMATION = "Information";

        private const string FLAG_WARNING = "Warning    ";

        private const string FLAG_ERROR = "Error      ";

        public static TraceListenerCollection Listeners
        {
            get
            {
                return Trace.Listeners;
            }
        }

        private static void LogMessage(string flag, string message)
        {
            Trace.WriteLine(string.Format("{0}: {1:yyyy-MM-dd HH:mm:ss} - {2}", flag, DateTime.Now, message));
        }

        private static void LogMessage(string flag, string message, params object[] args)
        {
            LogHelper.LogMessage(flag, string.Format(message, args));
        }

        public static void LogInformation(string message)
        {
            LogHelper.LogMessage("Information", message);
        }

        public static void LogInformation(string message, params object[] args)
        {
            LogHelper.LogMessage("Information", message, args);
        }

        public static void LogWarning(string message)
        {
            LogHelper.LogMessage("Warning    ", message);
        }

        public static void LogWarning(string message, params object[] args)
        {
            LogHelper.LogMessage("Warning    ", message, args);
        }

        public static void LogError(string message)
        {
            LogHelper.LogMessage("Error      ", message);
        }

        public static void LogError(string message, params object[] args)
        {
            LogHelper.LogMessage("Error      ", message, args);
        }

        public static void LogError(Exception ex)
        {
            LogHelper.LogError(ex.ToString());
        }
    }
}
