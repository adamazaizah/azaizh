using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Shapes
{
    class RightTriangle : AbstractShape
    {
        private double width, high;

        public RightTriangle(double width, double high)
        {
            this.width = width;
            this.high = high;
        }
        public override double GetArea()
        {
            return (width * high) / 2;
        }

        public override double GetCircumference()
        {
            return width + high + Math.Sqrt(Math.Pow(width, 2) + Math.Pow(high, 2));
        }

        public override string ToString()
        {
            return $"Right Triangle:width+{width},High:{high}";
        }
    }
}
