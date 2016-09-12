using System;

namespace _01.Point3D
{
    class MainClass
    {
        public static void Main()
        {
            Point3D point1 = new Point3D(1.5, 2, 4);
            Console.WriteLine(point1);

            Point3D point2 = new Point3D(3, 2);
            Console.WriteLine(point2);

            Console.WriteLine("Starting point is: " + Point3D.StartingPoint);

            //Point3D invalidPoint = new Point3D(-1.5, 0, 2);
        }
    }
}
