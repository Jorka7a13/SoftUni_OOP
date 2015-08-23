namespace _01.Shapes
{
    using System;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentNullException("radius", "Radius can't be null or negative!");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalculateParameter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}