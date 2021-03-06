﻿using System;
using System.Xml;
using TXClock.Enums;
using TXClock.Service;

namespace TXClock.Model
{
    public class GlobalClockTime:IComparable<GlobalClockTime>
    {
        public GlobalClock ParentClock { get; set; }
        public TimeSpan LeftTime { get; set; }
        public string ParantTag { get; set; }
        public string Note { get; set; }
        public string Time { get; set; }
        private bool? enable = null;
        public bool Enable
        {
            get
            {
                if (enable == null)
                {
                    enable = true;
                }
                return (bool)enable;
            }
            set
            {
                enable = value;
            }
        }
        public int CompareTo(GlobalClockTime anotherClock)
        {
            if (LeftTime < anotherClock.LeftTime)
            {
                return -1;
            }
            else if (LeftTime == anotherClock.LeftTime)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public void UpdateState(bool enable)
        {
            XmlNodeList clockNodeList = XmlService.GlobalClockXml.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == ParantTag)
                {
                    XmlNodeList timeList = clockNodeList[i].SelectNodes("Times/Time");
                    for(int j=0;j< timeList.Count;j++)
                    {
                        if (timeList[j].InnerText==Time)
                        {
                            timeList[j].Attributes["enable"].Value = (enable ? "1" : "0");
                            XmlService.SaveGlobalClockXml();
                            break;
                        }
                    }
                    break;
                }
            }
        }
        public void DeleteOnceTime()
        {
            XmlNodeList clockNodeList = XmlService.GlobalClockXml.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == ParantTag)
                {
                    XmlNodeList timeList = clockNodeList[i].SelectNodes("Times/Time");
                    for (int j = 0; j < timeList.Count; j++)
                    {
                        if (timeList[j].InnerText == Time)
                        {
                            timeList[j].ParentNode.RemoveChild(timeList[j]);
                            XmlService.SaveGlobalClockXml();
                            break;
                        }
                    }
                    //检查一次性的，时间没了之后删除该节点
                    if (int.Parse(clockNodeList[i].Attributes["type"].Value) == (int)GlobalClockType.once)
                    {
                        XmlNodeList leftTimeList = clockNodeList[i].SelectNodes("Times/Time");
                        if (leftTimeList == null || leftTimeList.Count == 0)
                        {
                            //为啥不直接clockNodeList[i].ParentNode.RemoveChild(clockNodeList[i])
                            //因为在上面删除time节点后，clockNodeList[i]实际上已经修改了，直接删除删除不了
                            DeleteOnceClock();
                        }
                    }
                    break;
                }
            }
        }

        private void DeleteOnceClock()
        {
            XmlNodeList clockNodeList = XmlService.GlobalClockXml.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == ParantTag)
                {
                    clockNodeList[i].ParentNode.RemoveChild(clockNodeList[i]);
                    XmlService.SaveGlobalClockXml();
                    break;
                }
            }
        }

    }
}
