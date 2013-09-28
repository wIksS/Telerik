using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses_PartTwo
{
    class TestPointsIn3D
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Point3D p1 = new Point3D();
            Point3D p2 = new Point3D();

            p1.x = 5;
            p1.y = 6;
            p1.z = 2;
            p2.x = -7;
            p2.y = 11;
            p2.z = -13;

            Console.WriteLine(TwoPointsDistance.FindDistance(p1,p2));
        }
    }
}
