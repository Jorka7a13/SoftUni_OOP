// Problem 1. Point3D

// Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.

using System;

namespace _01.Point3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint = new Point3D();

        public double X
        {
            get { return this.x; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("X must be a positive number");
                }
                this.x = value;
            }
        }

        public double Y
        {
            get { return this.y; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Y must be a positive number");
                }
                this.y = value;
            }
        }

        public double Z
        {
            get { return this.z; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Z must be a positive number");
                }
                this.z = value;
            }
        }

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public Point3D(double x = 0, double y = 0, double z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("X: {0}, Y: {1}, Z: {2}", this.X, this.Y, this.Z);
        }
    }
}