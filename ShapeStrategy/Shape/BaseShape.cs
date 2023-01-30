using ShapeStrategy.Area;
using ShapeStrategy.Perimeter;

namespace ShapeStrategy.Shape
{
    public abstract class BaseShape
    {

        protected IAreable areable;
        protected IPerimeterable perimeterable;

        protected double[] values;

        public BaseShape()
        {
            perimeterable = new YesPerimetr();
            areable = new NoArea();
        }

        /// <summary>
        /// Подсчет площади
        /// </summary>
        public void CalculateArea()
        {
            areable.CalculateArea(values);
        }

        /// <summary>
        /// Подсчет периметра
        /// </summary>
        public void CalculatePerimetr()
        {
            perimeterable.CalculatePerimetr(values);
        }

        public abstract void Display(); // Вывод фигуры на экран

    }
}
