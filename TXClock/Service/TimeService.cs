using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXClock.Enums;
using TXClock.Interface;

namespace TXClock.Service
{
    public class TimeService
    {
        public static bool IsGlobalClockTime(string time)
        {
            try
            {
                if (!time.Contains(":") || time.Split(':').Length != 2)
                {
                    return false;
                }
                string[] timeArray = time.Split(':');
                int hour = int.Parse(timeArray[0]);
                int minute = int.Parse(timeArray[1]);
                if (hour<0 || hour>23 || minute < 0 || minute >59)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsCountClockTime(string time)
        {
            try
            {
                if (!time.Contains(":"))
                {
                    return false;
                }
                int[] timeLimitArray = new int[] { 10000,59, 59 };
                string[] timeArray = time.Split(':');
                if (timeArray.Length!=3)//目前只精确到时分秒
                {
                    return false;
                }
                for (int i=0;i<timeArray.Length;i++)
                {
                    int m = 0;
                    if (int.TryParse(timeArray[i], out m)==false)
                    {
                        return false;
                    }else
                    {
                        if (m>timeLimitArray[i] || m<0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static TimeSpan GetLeftTime(string time, GlobalClockType clockType, List<WeekType> weekTypeList)
        {
            DateTime now = GlobalParamsConfig.Now;
            TimeSpan timeSpan = TimeSpan.Parse(time);
            WeekType? weekType = null;
            if (clockType==GlobalClockType.once && weekTypeList.Count==0)
            {
                if (timeSpan>new TimeSpan(now.Hour,now.Minute,now.Second))
                {
                    weekType = (WeekType)Enum.ToObject(typeof(WeekType), (int)now.DayOfWeek);
                }else
                {
                    weekType = (WeekType)Enum.ToObject(typeof(WeekType), ((int)now.DayOfWeek+1)%7);
                }
            }
            else
            {
                if (clockType == GlobalClockType.everyDay && weekTypeList.Count == 0)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        weekTypeList.Add((WeekType)Enum.ToObject(typeof(WeekType), i));
                    }
                }
                WeekType? nextWt = null;
                WeekType? preWt = null;
                int x = 8;
                int y = -8;
                DayOfWeek dw = now.DayOfWeek;
                foreach (WeekType wt in weekTypeList)
                {
                    if ((int)wt - (int)dw == 0)//在同一天内
                    {
                        if (timeSpan.Hours > now.Hour)
                        {
                            nextWt = (WeekType)Enum.ToObject(typeof(WeekType), (int)dw);
                            x = 0;
                            break;
                        }
                        else if (timeSpan.Hours == now.Hour)
                        {
                            if (timeSpan.Minutes > now.Minute)
                            {
                                nextWt = (WeekType)Enum.ToObject(typeof(WeekType), (int)dw);
                                x = 0;
                                break;
                            }
                            else
                            {
                                nextWt = (WeekType)Enum.ToObject(typeof(WeekType), (int)dw);
                                x = 7;
                            }
                        }
                        else
                        {
                            nextWt = (WeekType)Enum.ToObject(typeof(WeekType), (int)dw);
                            x = 7;
                        }
                        
                    }
                    else if((int)wt - (int)dw > 0)//在这一周的后面
                    {
                        if((int)wt - (int)dw < x)
                        {
                            x = (int)wt - (int)dw;
                            nextWt = wt;
                        }
                    }else if ((int)wt - (int)dw < 0)//在下一周
                    {
                        if ((int)wt - (int)dw >y)
                        {
                            y = (int)wt - (int)dw;
                            preWt = wt;
                        }
                    }
                }
                if (x<8)
                {
                    weekType = nextWt;
                }else
                {
                    weekType = preWt;
                }
            }
            int daySpan = ((int)weekType - (int)now.DayOfWeek + 7) % 7;
            int hourSpan = timeSpan.Hours - now.Hour;
            int minuteSpan = timeSpan.Minutes - now.Minute;
            int secondSpan = timeSpan.Seconds - now.Second;
            TimeSpan leftTime = new TimeSpan(daySpan, hourSpan, minuteSpan, secondSpan);
            if (leftTime< TimeSpan.Parse("00:00"))
            {
                leftTime = leftTime + new TimeSpan(7, 0, 0, 0, 0);
            }
            return leftTime;
        }
    }
}
