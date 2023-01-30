using ShapeStrategy.Area;
using System;

namespace ShapeStrategy.Shape
{
    public class Triangle : BaseShape
    {

        public Triangle(double[] values) : base()
        {
            this.values = values;
            areable = new AreaTriangle();
        }
        public override void Display()
        {
            Console.Write("Я треугольник со сторонами: ");
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
