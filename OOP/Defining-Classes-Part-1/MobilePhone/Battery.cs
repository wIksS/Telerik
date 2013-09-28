using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;
        //declarating fields

        public Battery(string model = null, int hoursIdle = 0, int hoursTalk = 0, BatteryType type = 0)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }
        // making the constructor taking parameters or making them null

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect model!");
                }
                // checking if the model is null or empty
                this.model = value;
            }
        }
        // making it public so it can be adjusted by the outside

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect hours idle!");
                }
                // checking if the hoursIdle is null or empty
                this.hoursIdle = value;
            }
        }
        // making it public so it can be adjusted by the outside

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect hours talk!");
                }
                // checking if the hoursTalk is null or empty
                this.hoursTalk = value;
            }
        }
        // making it public so it can be adjusted by the outside
    }
}
