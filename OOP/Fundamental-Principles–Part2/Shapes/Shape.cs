using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        //fields for width and height
        private int width;
        private int height;

        // an abstract method which should be invented by all 
        // classes that inherit this class
        public abstract double CalculateSurface();

        public int Width
        {
            // property for the width field
            get { return this.width; }
            set { this.width = value; }
        }

        public int Height
        {
            // property for the height field
            get { return this.height; }
            set { this.height = value; }
        }

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
