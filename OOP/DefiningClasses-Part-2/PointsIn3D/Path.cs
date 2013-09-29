using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses_PartTwo
{
    public static class Path
    {
        static private List<Point3D> points = new List<Point3D>();
        // I m using this list to store all the points

        public static void Add(Point3D point)
        {
            points.Add(point);
            // with this method i add a new element to the list
        }
    }
}
