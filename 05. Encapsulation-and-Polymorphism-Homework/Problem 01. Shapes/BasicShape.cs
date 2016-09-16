namespace _01.Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get { return this.width; }
            set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentNullException("width", "Width can't be null or negative!");
                }
                this.width = value;
            }
        }

        protected double Height
        {
            get { return this.height; }
            set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentNullException("height", "Height can't be null or negative!");
                }
                this.height = value;
            }
        }

        abstract public double CalculateArea();

        abstract public double CalculateParameter();
    }
}