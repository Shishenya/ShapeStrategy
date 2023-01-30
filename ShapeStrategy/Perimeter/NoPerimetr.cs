using System;

namespace ShapeStrategy.Perimeter
{
    public class NoPerimetr : IPerimeterable
    {
        public void CalculatePerimetr(double[] values)
        {
            Console.WriteLine("У меня нет периметра!");
        }
    }
}
