using System;

namespace ShapeStrategy.Area
{
    internal class NoArea : IAreable
    {
        public void CalculateArea(double[] values)
        {
            Console.WriteLine("У меня нет площади или ее невозможно посчитать!");
        }
    }
}
