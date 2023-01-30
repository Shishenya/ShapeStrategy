using System;

namespace ShapeStrategy.Area
{
    public class AreaCircle : IAreable
    {
        public void CalculateArea(double[] values)
        {
            double result = (Math.PI * Math.Pow(values[0], 2));
            Console.WriteLine($"Моя площадь равна: {result}");
        }
    }
}
