// Problem 2. Distance Calculator

// Write a static class DistanceCalculator with a static method 
// to calculate the distance between two points in the 3D space.

using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalcDistance(Point3D startPoint, Point3D endPoint)
        {
            return Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) +
                               Math.Pow(endPoint.Y - startPoint.Y, 2) +
                               Math.Pow(endPoint.Z - startPoint.Z, 2));
        }
    }
}
