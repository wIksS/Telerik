using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public class TimeInfoEventArgs : EventArgs
    {
        public int hour;
        public int minute;
        public int second;
        //The TimeInfoEventArgs class has information about the current hour, 
        //minute, and second. It defines a constructor and three public integer variables.

        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            // In addition to its delegate, the Clock class has three member variables-hour, 
            // minute, and second-as well as a single method, Run( ):
        }
    }
}
