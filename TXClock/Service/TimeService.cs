using System;
using System.Collections.Generic;
using TXClock.Enums;

namespace TXClock.Service
{
    public class TimeService
    {
        public static TimeSpan GetGlobalClockLeftTime(string time, GlobalClockType clockType, List<WeekType> weekTypeList)
        {
            DateTime now = ParamsConfig.Now;
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
                int x = 7;
                int y = 0;
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
                        if ((int)wt - (int)dw <y)
                        {
                            y = (int)wt - (int)dw;
                            preWt = wt;
                        }
                    }
                }
                if (x<7 || preWt==null)
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
