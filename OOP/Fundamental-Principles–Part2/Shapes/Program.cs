using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            int height;
            int width;

            Console.Write("Rectangle height ---> ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Rectangle width ---> ");
            width = int.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(height, width));
            Console.Write("Triangle height ---> ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Triangle width ---> ");
            width = int.Parse(Console.ReadLine());
            shapes.Add(new Triangle(height, width));
            Console.Write("Circle height ---> ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Circle width ---> ");
            width = int.Parse(Console.ReadLine());
            shapes.Add(new Circle(height, width));

            foreach (var shape in shapes)
            {
                double surface = shape.CalculateSurface();
                Console.WriteLine("Surface --> {0}",surface);
            }
        }
    }
}
