using System;

namespace Shapes.Shapes
{
    class Circle : AbstractShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double GetCircumference()
        {
            return 2*Math.PI * radius;

        }


        public override string ToString()
        {
            return $"Circle: radius={radius}";
        }
    }
}
