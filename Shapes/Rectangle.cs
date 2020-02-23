
namespace Shapes.Shapes
{
    public class Rectangle :AbstractShape
    {
        double width, hight;

        public Rectangle(double width, double hight)
        {
            this.hight = hight;
            this.width = width;
        }

        public override double GetArea()
        {
            return width * hight;
        }

        public override double GetCircumference()
        {
            return 2 * width + 2 * hight;
        }

        public override string ToString()
        {
            return $"Rectangle: width={width},hight={hight}";
        }
    }
}
