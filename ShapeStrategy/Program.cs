using ShapeStrategy.Shape;
using System;
using System.Collections.Generic;

namespace ShapeStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<BaseShape> myShape = new List<BaseShape>();

            double[] triangleValues = { 3, 4, 5 };
            myShape.Add(new Triangle(triangleValues));

            double[] rectangleValues = { 3, 5, 3, 5 };
            myShape.Add(new Rectangle(rectangleValues));

            double[] lineValues = { 1.7 };
            myShape.Add(new Line(lineValues));

            double[] circleValues = { 3 };
            myShape.Add(new Circle(circleValues));

            foreach (BaseShape shape in myShape)
            {
                shape.Display();
                shape.CalculatePerimetr();
                shape.CalculateArea();

                Console.WriteLine();

            }

        }
    }
}
