using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses_PartTwo
{
    public struct Point3D
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        // Im doing three fields for the three
        // coordinates in the 3D space and I use get,set so I can use them later
        public static Point3D startPoint = new Point3D();
        // this point has 0/0/0 by default and we cant
        // change it because we use onlt get in the property

        public override string ToString()
        {
            return String.Format("X --> {0}\nY -->  {1}\nZ --> {2}", this.x, this.y, this.z);
            // this overrides the operator ToString() to
            // return x,y,z value all on new lines 
            // (you can also make it on one line)
        }

        public static Point3D StartPoint
        {
            get { return startPoint; }
        }
    }
}
