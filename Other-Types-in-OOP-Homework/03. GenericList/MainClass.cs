// Problem 3. Generic List

// Write a generic class "GenericList<T>" that keeps a list of elements of some parametric type T. 

namespace _03.GenericList
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            GenericList<int> myIntList = new GenericList<int>(4);
            myIntList.Add(1);
            myIntList.Add(3);
            myIntList.Insert(1, 2);
            Console.WriteLine("My int list: " + myIntList);
            Console.WriteLine("Max is: " + myIntList.Max());
            Console.WriteLine("Min is: " + myIntList.Min());

            Console.WriteLine();

            GenericList<string> myStringList = new GenericList<string>();
            myStringList.Add("Joro");
            myStringList.Add("Ivan");
            myStringList.Add("Barack Obama");

            Console.WriteLine("My string list: " + myStringList);
            Console.WriteLine("Max is: " + myStringList.Max());
            Console.WriteLine("Min is: " + myStringList.Min());

            Console.WriteLine();

            object[] versionAttributes = typeof(GenericList<string>).GetCustomAttributes(false);
            Console.WriteLine("Version is: " + versionAttributes[1]);
        }
    }
}