using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXClock.Interface;

namespace TXClock.Model
{
    public class MyClockForm: Form,IClockForm
    {
        public GlobalClock globalClock { get; set; }

        public virtual void ReloadData()
        {
            
        }
    }
}
