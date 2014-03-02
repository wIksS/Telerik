using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class DisplayTimer
    {
        public void Subscribe(Timer theTimer)
        {
            theTimer.SecondChanged +=
                 new Timer.Delegate(TimeHasChanged);
        }

        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            DelegateTSeconds eachDelegateSeconds = Program.TestMethod;
            eachDelegateSeconds();
        }
    }
}
