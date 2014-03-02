using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // class Rectangle which inherits
    // the abstract class Shape
    class Rectangle : Shape
    {
        // a constructor which inherits the 
        // abstract base class shape
        public Rectangle(int width, int height)
            : base(width, height)
        {
        }

        // overriden method for calculating surface
        // of a triangle by the given formula in the task
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;
        }
    }
}
