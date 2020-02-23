using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class ShapeFactory
    {
        public static AbstractShape CreateShape(int shapeNumber)
        {
            switch(shapeNumber)
            {
                case 2:
                    Console.WriteLine("Enter width:");
                    double w = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter high:");
                    double h = double.Parse(Console.ReadLine());
                    return new Rectangle(w, h);

                case 1:
                    Console.WriteLine("Enter width:");
                    double sqaureWidth = double.Parse(Console.ReadLine());
                    return new Square(sqaureWidth);

                case 3:
                    Console.WriteLine("Enter Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    return new Circle(radius);

                case 4:
                    Console.WriteLine("Enter width:");
                    double righTriangleW = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter high:");
                    double righTriangleH = double.Parse(Console.ReadLine());
                    return new RightTriangle(righTriangleW, righTriangleH);
            }
            return null;
        }
    }
}
