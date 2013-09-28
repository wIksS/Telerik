using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses_PartTwo
{
    public static class TwoPointsDistance
    {
        static int xDistance;
        static int yDistance;
        static int zDistance;
        // I need thos fields so i can
        // use the formula for finding distance
        // between 2 points in 3D space
        static double distance;
        // here is where i will calculate the distance

        public static double FindDistance(Point3D firstPoint, Point3D secondPoint)
        {
            xDistance = secondPoint.x - firstPoint.x;
            yDistance = secondPoint.y - firstPoint.y;
            zDistance = secondPoint.z - firstPoint.z;
            distance = Math.Sqrt(xDistance * xDistance + yDistance * yDistance + zDistance * zDistance);

            return distance;
        }
    }
}
