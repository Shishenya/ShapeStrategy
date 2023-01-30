using ShapeStrategy.Area;
using ShapeStrategy.Perimeter;
using System;

namespace ShapeStrategy.Shape
{
    public class Circle : BaseShape
    {

        public Circle(double[] values) {
            this.values = values;
            perimeterable = new CirclePerimetr();
            areable = new AreaCircle();
        }

        public override void Display()
        {
            Console.WriteLine($"Я круг с периметром: {values[0]}");
        }
    }
}
