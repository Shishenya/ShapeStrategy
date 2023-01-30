using ShapeStrategy.Perimeter;
using System;

namespace ShapeStrategy.Shape
{
    public class Line: BaseShape
    {
        public Line(double[] values) { 
            this.values = values;
            perimeterable = new NoPerimetr();
        }

        public override void Display()
        {
            Console.WriteLine($"Я простая линия длиной {values[0]}");
        }
    }
}
