using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXClock
{
    public static class GlobalParamsConfig
    {
        public static string XmlConfigFolderPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"ConfigXml";
            }
        }
        public static string GlobalClockXmlPath
        {
            get{
                return AppDomain.CurrentDomain.BaseDirectory + @"ConfigXml\GlobalClock.xml";
            }
        }
        public static string CountClockXmlPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"ConfigXml\CountClock.xml";
            }
        }
        public static string ConfigXmlPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"ConfigXml\Config.xml";
            }
        }
        public static string ApplicationKey
        {
            get
            {
                return "TXClock";
            }
        }
        public static DateTime Now { get; set; }
    }
}
