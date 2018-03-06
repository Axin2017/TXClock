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
