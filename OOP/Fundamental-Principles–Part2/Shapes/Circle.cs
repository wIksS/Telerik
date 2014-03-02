using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // class Circle which inherits
    // the abstract class Shape
    class Circle : Shape
    {
        // constructor for the class Circle
        // that inherits the constructor of Shape
        public Circle(int width, int height)
            : base(width, height)
        {
            // throw an exeption if the height
            // is different to the width
            // like it is said in the task
            //try
            //{
                if (width != height)
                {
                    throw new ArgumentException("The width must be equal to the height");
                }
            //}
            //catch (ArgumentException exeption)
            //{
            //    Console.WriteLine(exeption.Message);
            //}
        }

        // overriden method for calculating surface
        // of a Circle by the formula for calculating surface
        public override double CalculateSurface()
        {
            // the forumla is : area = r2 * Pi
            double surface = ((this.Height / 2.0) * (this.Height / 2.0)) * Math.PI;
            return surface;
        }
    }
}
