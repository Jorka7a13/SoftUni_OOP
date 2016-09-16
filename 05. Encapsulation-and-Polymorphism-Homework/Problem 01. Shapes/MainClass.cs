// Problem 1. Shapes

// Create an array of different shapes (Circle, Rectangle, Triangle) and test the behavior 
// of the CalculateSurface() and CalculatePerimeter() methods.

namespace _01.Shapes
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            IShape[] shapes =
            {
                new Triangle(2.0, 3.0, 4.0),
                new Triangle(2.5, 2.5, 2.5),
                new Rectangle(2.0, 4.0),
                new Rectangle(5.0, 8.0),
                new Circle(2.5),
                new Circle(5) 
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(String.Format("{0} -> Parameter: {1}, Area: {2}",
                    shape.GetType().Name, shape.CalculateParameter(), shape.CalculateArea()));
            }
        }
    }
}