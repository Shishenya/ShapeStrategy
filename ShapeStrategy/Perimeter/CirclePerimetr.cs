using System;

namespace ShapeStrategy.Perimeter
{
    internal class CirclePerimetr : IPerimeterable
    {
        public void CalculatePerimetr(double[] values)
        {
            double result = (2 * Math.PI * values[0]);
            Console.WriteLine($"Мой периметр равен: {result}");
        }
    }
}
