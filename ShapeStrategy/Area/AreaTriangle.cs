using System;

namespace ShapeStrategy.Area
{
    public class AreaTriangle : IAreable
    {
        public void CalculateArea(double[] values)
        {
            double p = (values[0] + values[1] + values[2]) / 2;
            double result = (Math.Sqrt(p * (p - values[0]) * (p - values[1]) * (p - values[2])));
            Console.WriteLine($"Моя площадь равна: {result}");
        }
    }
}
