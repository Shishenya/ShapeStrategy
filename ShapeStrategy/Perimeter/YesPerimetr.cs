using System;

namespace ShapeStrategy.Perimeter
{
    public class YesPerimetr : IPerimeterable
    {
        public void CalculatePerimetr(double[] values)
        {
            double result = 0;
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }
            Console.WriteLine($"Мой периметр равен: {result}");
        }
    }
}
