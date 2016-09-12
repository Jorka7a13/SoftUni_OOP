// Problem 2. Enter Numbers

// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
// If the user enters an invalid number, let the user to enter again.

using System;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        public int ReadNumber(int start, int end)
        {
            int number = 0;

            try
            {
                Console.Write("Please enter a number:");
                number = Int32.Parse(Console.ReadLine());

                if (number <= start || number > end)
                {
                    throw new ArgumentException("Number should be in the range [" + start + ".." + end + "]");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                ReadNumber(start, 100);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
                ReadNumber(start, 100);
            }

            return number;
        }
    }
}