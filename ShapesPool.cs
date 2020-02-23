using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Shapes
{
    public class ShapesPool
    {
        private static List<AbstractShape> shapes;
        static ShapesPool()
        {
            shapes = new List<AbstractShape>();
        }

        public static void AddShape()
        {
            Console.WriteLine(string.Format("{0}{1}{0}{2}{0}{3}{0}{4}", Environment.NewLine, "1.square", "2.rectangle", "3.circle", "4.Right triangle"));
            int selectedShapeNumber = int.Parse(Console.ReadLine());
            shapes.Add(ShapeFactory.CreateShape(selectedShapeNumber));
        }

        public static void ListAllShapes()
        {
            foreach(AbstractShape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }


        public static void SumAllAreas()
        {
            Console.WriteLine(shapes.Sum(item => item.GetArea()));
        }

        public static void SumAllCircumference()
        {
            Console.WriteLine(shapes.Sum(item => item.GetCircumference()));

        }

        public static void BiggestCircumference()
        {
            Console.WriteLine(shapes.Max(item => item.GetCircumference()));

        }

        public static void BiggestArea()
        {
            Console.WriteLine(shapes.Max(item => item.GetArea()));
        }
    }
}
