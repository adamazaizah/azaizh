using Shapes.Shapes;
using System;
using System.Collections.Generic;

namespace Shapes
{
    class Shape
    {
        private static List<AbstractShape> shapes;

        private static readonly string Message = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}",
            Environment.NewLine,"1. Add new shape",
            "2. List all shaped",
            "3. Sum all circumferences",
            "4. Sum all areas", 
            "5. Find biggest circumferences", 
            "6. Find biggest area",
            "7. Exit");

        static void Main(string[] args)
        {
            Console.WriteLine(Message);
            int choice;

            choice = int.Parse(Console.ReadLine());
            while(choice!=7)
            {
                switch (choice)
                {
                    case 1:
                        ShapesPool.AddShape();
                        break;
                    case 2:
                        ShapesPool.ListAllShapes();
                        break;
                    case 3:
                        ShapesPool.SumAllCircumference();
                        break;
                    case 4:
                        ShapesPool.SumAllAreas();
                        break;
                    case 5:
                        ShapesPool.BiggestCircumference();
                        break;
                    case 6:
                        ShapesPool.BiggestArea();
                        break;
                    default:
                        Console.WriteLine("Supported numbers: 1-7");
                        break;
                    
                }
                Console.WriteLine(Message);
                choice = int.Parse(Console.ReadLine());
            }

        }
    }
}
