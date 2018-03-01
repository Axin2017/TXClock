using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXClock.Enums;

namespace TXClock.Interface
{
    public interface ITimeService
    {
        bool IsTime(string time);
        TimeSpan GetLeftTime(string time, GlobalClockType clockType, List<WeekType> weekTypeList);
    }
}
