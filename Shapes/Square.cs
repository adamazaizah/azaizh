using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Shapes
{
    public class Square : AbstractShape
    {
        double width;

        public Square(double width)
        {
            this.width = width;
        }
        public override double GetArea()
        {
            return Math.Pow(width, 2);
        }

        public override double GetCircumference()
        {
            return width * 4;
        }

        public override string ToString()
        {
            return $"Square: width={width}";
        }
    }
}
