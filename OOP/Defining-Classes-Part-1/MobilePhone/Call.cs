using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Call
    {
        private DateTime callTime;
        private string dialedNumber;
        private int duration;
        // making the wanted fields for the class Call

        public Call(DateTime now, string dialedNumber = "09999999",int duration = 60)
        {
            this.callTime = now;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }
        public DateTime CallTime
        {
            get { return this.callTime; }
            set { this.callTime = value; }
        }
        // making it public so it can be adjusted by the outside

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }
        // making it public so it can be adjusted by the outside

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        // making it public so it can be adjusted by the outside
    }
}
