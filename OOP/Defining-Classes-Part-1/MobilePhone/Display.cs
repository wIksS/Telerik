using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Display
    {
        private int size;
        private int colorsNumber;
        //declarating fields

        public Display(int size = 0 , int colorsNumber = 0)
        {
            this.size = size;
            this.colorsNumber = colorsNumber;
        }
        // making the constructor taking parameters or making them null

        public int Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect size !");
                }
                // checking if the size is null or empty
                this.size = value;
            }
        }
        // making it public so it can be adjusted by the outside

        public int ColorsNumber
        {
            get { return this.colorsNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect ColorsNumber !");
                }
                // checking if the ColorsNumber is null or empty
                this.ColorsNumber = value;
            }
        }
        // making it public so it can be adjusted by the outside
    }
}
