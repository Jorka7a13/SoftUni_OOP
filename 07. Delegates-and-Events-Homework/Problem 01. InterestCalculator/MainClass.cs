// Problem 1. Interest Calculator

// Create a class InterestCalculator that takes in its constructor money, interest, years and interest calculation delegate.

namespace _01.InterestCalculator
{
    using System;

    public class MainClass
    {
        public static decimal GetSimpleInterest(decimal amount, double interest, int years)
        {
            return amount * (1 + (decimal)(interest / 100) * years);
        }

        public static decimal GetCompoundInterest(decimal amount, double interest, int years)
        {
            return amount * (decimal)Math.Pow((1 + (interest / 100) / 12), years * 12);
        }

        public static void Main()
        {
            InterestCalculator compoundInterest = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(compoundInterest);

            InterestCalculator simpleInterest = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(simpleInterest);
        }
    }
}