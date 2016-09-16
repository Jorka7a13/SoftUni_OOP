namespace _01.Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC) : base(sideA, sideB)
        {
            this.SideC = sideC;
        }

        public double SideC
        {
            get { return this.sideC; }
            set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentNullException("sideC", "SideC can't be null or negative!");
                }
                this.sideC = value;
            }
        }
    
        public override double CalculateArea()
        {
            double p = (this.Width + this.Height + this.SideC) / 2;
            return Math.Sqrt(p * (p - this.Width) * (p - this.Height) * (p - this.SideC));
        }

        public override double CalculateParameter()
        {
            return this.Width + this.Height + this.SideC;
        }
    }
}