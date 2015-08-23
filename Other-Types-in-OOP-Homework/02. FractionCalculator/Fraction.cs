namespace _02.FractionCalculator
{
    using System;

    internal struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            private set { this.numerator = value; }
        }

        public long Denominator
        {
            get { return this.denominator; }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can't be zero!");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            long LCD = FindLeastCommonMultiple(first.Denominator, second.Denominator);

            long firstNewNumerator = first.Numerator * (LCD / first.Denominator);
            long secondNewNumerator = second.Numerator * (LCD / second.Denominator);

            return new Fraction(firstNewNumerator + secondNewNumerator, LCD);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            long LCD = FindLeastCommonMultiple(first.Denominator, second.Denominator);

            long firstNewNumerator = first.Numerator * (LCD / first.Denominator);
            long secondNewNumerator = second.Numerator * (LCD / second.Denominator);

            return new Fraction(firstNewNumerator - secondNewNumerator, LCD);
        }

        public override string ToString()
        {
            return ((double) this.Numerator / this.Denominator).ToString();
        }

        private static long FindLeastCommonMultiple(long firstNumber, long secondNumber)
        {
            return (firstNumber * secondNumber) / FindGreatestCommonDivisor(firstNumber, secondNumber);
        }

        private static long FindGreatestCommonDivisor(long firstNumber, long secondNumber)
        {
            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber) 
                { 
                    firstNumber = firstNumber - secondNumber;
                }
                else
                {
                    secondNumber = secondNumber - firstNumber;
                }
            }

            return firstNumber;
        }
    }
}