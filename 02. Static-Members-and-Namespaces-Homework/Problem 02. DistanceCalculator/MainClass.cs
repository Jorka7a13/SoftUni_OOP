using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public class MainClass
    {
        public static void Main()
        {
            Point3D firstPoint = new Point3D();
            Point3D secondPoint = new Point3D(1, 2, 3);

            Console.WriteLine("The distance is: " + DistanceCalculator.CalcDistance(firstPoint, secondPoint));
        }
    }
}
