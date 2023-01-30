using System;

namespace ShapeStrategy.Area
{
    public class AreaRectangle : IAreable
    {
        public void CalculateArea(double[] values)
        {
            double result = values[0] * values[1];
            Console.WriteLine($"Моя площадь равна: {result}");
        }
    }
}
