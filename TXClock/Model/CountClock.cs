using System.Xml;
using TXClock.Interface;
using TXClock.Service;

namespace TXClock.Model
{
    public class CountClock: IXmlConvert
    {
        public string Tag { get; set; }
        public string Time { get; set; }
        public string Note { get; set; }
        private XmlDocument XmlDoc
        {
            get
            {
                return XmlService.CountClockXml;
            }
        }

        public void SaveToXmlNode()
        {
            XmlElement clock = XmlDoc.CreateElement("Clock");
            clock.SetAttribute("tag", Tag);
            clock.SetAttribute("note", Note);
            clock.InnerText = Time;
            XmlNode countClock = XmlDoc.SelectSingleNode("CountClock");
            countClock.AppendChild(clock);
            XmlService.SaveCountClockXml();
        }

        public void DeleteFromXmlNode()
        {
            XmlNodeList clockNodeList = XmlDoc.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == Tag)
                {
                    clockNodeList[i].ParentNode.RemoveChild(clockNodeList[i]);
                    break;
                }
            }
            XmlService.SaveCountClockXml();
        }

        public void InitFromXmlNode(XmlNode node)
        {
            Tag = node.Attributes["tag"].Value;
            Note= node.Attributes["note"].Value;
            Time = node.InnerText;
        }
        public void UpdateClock()
        {
            XmlNodeList clockNodeList = XmlDoc.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == Tag)
                {
                    clockNodeList[i].Attributes["time"].Value = Time;
                    clockNodeList[i].Attributes["note"].Value = Note;
                    XmlService.SaveCountClockXml();
                    break;
                }
            }
        }
    }
}
