﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TXClock.Enums;
using TXClock.Interface;
using TXClock.Service;

namespace TXClock.Model
{
    public class GlobalClock:IXmlConvert
    {
        public string Tag { get; set; }
        private List<GlobalClockTime> timeList;
        public List<GlobalClockTime> TimeList
        {
            get
            {
                if (timeList == null)
                {
                    timeList = new List<GlobalClockTime>();
                }
                return timeList;
            }
            set { timeList = value; }
        }
        private List<WeekType> weekList;
        public List<WeekType> WeekList
        {
            get
            {
                if (weekList == null)
                {
                    weekList = new List<WeekType>();
                }
                return weekList;
            }
            set
            {
                weekList = value;
            }
        }
        public GlobalClockType ClockType { get; set; }

        

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
            doc.Save(GlobalParamsConfig.GlobalClockXmlPath);
        }

        public void SaveToXmlNode(XmlDocument doc)
        {
            XmlElement clock = doc.CreateElement("Clock");
            clock.SetAttribute("tag", Tag);
            clock.SetAttribute("type", ((int)ClockType).ToString());
            
            XmlNode globalClock = doc.SelectSingleNode("/GlobalClock");
            globalClock.AppendChild(clock);
            XmlElement times = doc.CreateElement("Times");
            clock.AppendChild(times);
            foreach (GlobalClockTime gct in TimeList)
            {
                XmlElement time = doc.CreateElement("Time");
                time.InnerText = gct.Time;
                time.SetAttribute("tag", gct.Note);
                time.SetAttribute("enable", gct.Enable ? "1" : "0");
                times.AppendChild(time);
            }
            XmlElement weeks = doc.CreateElement("Weeks");
            clock.AppendChild(weeks);
            foreach (WeekType weekType in WeekList)
            {
                XmlElement week = doc.CreateElement("Week");
                week.InnerText = ((int)weekType).ToString();
                weeks.AppendChild(week);
            }
            doc.Save(GlobalParamsConfig.GlobalClockXmlPath);
        }

        public void InitFromXmlNode(XmlNode node)
        {

            Tag = node.Attributes["tag"].Value;
            ClockType = (GlobalClockType)Enum.Parse(typeof(GlobalClockType), node.Attributes["type"].Value);
            XmlNode times = node.SelectSingleNode("Times");
            XmlNodeList timeList = times.ChildNodes;
            if (timeList!=null && timeList.Count>0)
            {
                XmlNode weeks = node.SelectSingleNode("Weeks");
                XmlNodeList weekList = weeks.ChildNodes;
                if (weekList != null && weekList.Count > 0)
                {
                    foreach (XmlNode weekNode in weekList)
                    {
                        WeekList.Add((WeekType)Enum.Parse(typeof(WeekType), weekNode.InnerText));
                    }
                }
                foreach (XmlNode timeNode in timeList)
                {
                    GlobalClockTime gct = new GlobalClockTime();
                    gct.Note = timeNode.Attributes["tag"].Value;
                    gct.Time = timeNode.InnerText;
                    gct.ParantTag = Tag;
                    gct.Enable = timeNode.Attributes["enable"].Value.ToString() == "1";
                    if (gct.Enable)
                    {
                        gct.LeftTime = TimeService.GetLeftTime(gct.Time, ClockType, WeekList);
                    }
                    gct.ParentClock = this;
                    TimeList.Add(gct);
                }
            }
        }
        
    }
}
