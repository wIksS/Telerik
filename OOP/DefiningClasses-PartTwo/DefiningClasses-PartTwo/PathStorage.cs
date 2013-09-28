using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses_PartTwo
{
    public static class PathStorage
    {
        public static void SaveFile(List<Point3D> points)
        {
            StreamWriter file = new StreamWriter("file.txt");
            // defining a streamwriter class and making a new file "file.txt"
            int counter = 1;
            using (file)
            {
                foreach (var point in points)
                {
                    file.Write(counter + " --> ");
                    file.WriteLine("x = {0}, y = {1}, z = {2}", point.x, point.y, point.z);
                }
            }
            // I use using {} so the file can close itself 
            // and be ready to be used again
        }

        public static string ReadFile(string filePath)
        {
            StringBuilder result = new StringBuilder();
            // I am using the stringbuilder class for better performance
            StreamReader path = new StreamReader(filePath);
            // making a StreamReader variable by the given file path
            using (path)
            {
                result.Append(path.ReadToEnd());
            }
            // I use using {} so the file can close itself 
            // and be ready to be used again
            return result.ToString();
        }
    }
}
