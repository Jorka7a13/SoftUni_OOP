// Problem 1. Square Root

// Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 

using System;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        public static void CalcSquareRoot()
        {
            try
            {
                Console.WriteLine("Please enter a number:");
                int number = Int32.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentNullException();
                }

                Console.WriteLine("Square root of " + number + " is: " + Math.Sqrt(number));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}