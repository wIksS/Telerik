using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // class triangle which inherits
    // the abstract class Shape
    class Triangle : Shape
    {
        // a constructor which inherits the 
        // abstract base class shape
        public Triangle(int width, int height)
            : base(width, height)
        {
        }

        // overriden method for calculating surface
        // of a triangle by the given formula in the task
        public override double CalculateSurface()
        {
            double surface = this.Height * (this.Width / 2.0);
            return surface;
        }
    }
}
