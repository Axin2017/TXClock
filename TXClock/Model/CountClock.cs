using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TXClock.Interface;

namespace TXClock.Model
{
    public class CountClock: IXmlConvert
    {
        public string Tag { get; set; }
        public string Time { get; set; }
        public string Note { get; set; }

        public void SaveToXmlNode(XmlDocument doc)
        {
            XmlElement clock = doc.CreateElement("Clock");
            clock.SetAttribute("tag", Tag);
            clock.SetAttribute("note", Note);
            clock.InnerText = Time;
            XmlNode countClock = doc.SelectSingleNode("CountClock");
            countClock.AppendChild(clock);
            doc.Save(GlobalParamsConfig.CountClockXmlPath);
        }

        public void DeleteFromXmlNode(XmlDocument doc)
        {
            XmlNodeList clockNodeList = doc.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == Tag)
                {
                    clockNodeList[i].ParentNode.RemoveChild(clockNodeList[i]);
                    break;
                }
            }
            doc.Save(GlobalParamsConfig.CountClockXmlPath);
        }

        public void InitFromXmlNode(XmlNode node)
        {
            Tag = node.Attributes["tag"].Value;
            Note= node.Attributes["note"].Value;
            Time = node.InnerText;
        }
        public void UpdateClock()
        {
            XmlDocument doc = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.CountClockXmlPath);
            XmlNodeList clockNodeList = doc.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == Tag)
                {
                    clockNodeList[i].Attributes["time"].Value = Time;
                    clockNodeList[i].Attributes["note"].Value = Note;
                    doc.Save(GlobalParamsConfig.CountClockXmlPath);
                    break;
                }
            }
        }
    }
}
