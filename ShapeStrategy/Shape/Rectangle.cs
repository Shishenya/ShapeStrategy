using ShapeStrategy.Area;
using System;

namespace ShapeStrategy.Shape
{
    public class Rectangle : BaseShape
    {

        public Rectangle(double[] values) {
            this.values = values;
            areable = new AreaRectangle();
        }

        public override void Display()
        {
            Console.Write("Я прямоугольник со сторонами: ");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i]);
                if (i + 1 == values.Length)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
