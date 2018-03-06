using System.IO;
using System.Xml;

namespace TXClock.Service
{
    public class XmlService
    {
        public static XmlDocument GlobalClockXml { get; set; }
        public static XmlDocument CountClockXml { get; set; }
        public static XmlDocument ConfigXml { get; set; }
        public static void CheckXml()
        {
            if (!Directory.Exists(ParamsConfig.XmlConfigFolderPath))
            {
                Directory.CreateDirectory(ParamsConfig.XmlConfigFolderPath);
            }
            if (!File.Exists(ParamsConfig.GlobalClockXmlPath))
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(xmldecl);
                XmlElement GlobalClock = xmldoc.CreateElement("GlobalClock");
                xmldoc.AppendChild(GlobalClock);
                xmldoc.Save(ParamsConfig.GlobalClockXmlPath);
            }
            if (!File.Exists(ParamsConfig.ConfigXmlPath))
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(xmldecl);
                XmlElement Config = xmldoc.CreateElement("Config");
                xmldoc.AppendChild(Config);
                XmlElement IsMessage = xmldoc.CreateElement("IsMessage");
                IsMessage.InnerText = "1";
                Config.AppendChild(IsMessage);
                XmlElement IsDialog = xmldoc.CreateElement("IsDialog");
                IsDialog.InnerText = "0";
                Config.AppendChild(IsDialog);
                XmlElement IsStart = xmldoc.CreateElement("IsStart");
                IsStart.InnerText = "0";
                Config.AppendChild(IsStart);
                xmldoc.Save(ParamsConfig.ConfigXmlPath);
            }
            if (!File.Exists(ParamsConfig.CountClockXmlPath))
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(xmldecl);
                XmlElement CountClock = xmldoc.CreateElement("CountClock");
                xmldoc.AppendChild(CountClock);
                xmldoc.Save(ParamsConfig.CountClockXmlPath);
            }
        }
        public static void InitXml()
        {
            GlobalClockXml = TXDLL.Tools.XmlTools.GetXmlByPath(ParamsConfig.GlobalClockXmlPath);
            CountClockXml = TXDLL.Tools.XmlTools.GetXmlByPath(ParamsConfig.CountClockXmlPath);
            ConfigXml = TXDLL.Tools.XmlTools.GetXmlByPath(ParamsConfig.ConfigXmlPath);
        }
        public static void ReloadGlobalClockXml()
        {
            GlobalClockXml = TXDLL.Tools.XmlTools.GetXmlByPath(ParamsConfig.GlobalClockXmlPath);
        }
        public static void ReloadCountClockXml()
        {
            CountClockXml = TXDLL.Tools.XmlTools.GetXmlByPath(ParamsConfig.CountClockXmlPath);
        }
        public static void ReloadConfigXml()
        {
            ConfigXml = TXDLL.Tools.XmlTools.GetXmlByPath(ParamsConfig.ConfigXmlPath);
        }
        public static void SaveGlobalClockXml()
        {
            GlobalClockXml.Save(ParamsConfig.GlobalClockXmlPath);
            ReloadGlobalClockXml();
        }
        public static void SaveCountClockXml()
        {
            CountClockXml.Save(ParamsConfig.CountClockXmlPath);
            ReloadCountClockXml();
        }
        public static void SaveConfigXml()
        {
            ConfigXml.Save(ParamsConfig.ConfigXmlPath);
            ReloadConfigXml();
        }
    }
}
