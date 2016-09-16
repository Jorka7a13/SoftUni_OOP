// Problem 2. Fraction Calculator

// Create a struct "Fraction" that holds the "numerator" and "denominator" of a fraction as fields.

namespace _02.FractionCalculator
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;

            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}