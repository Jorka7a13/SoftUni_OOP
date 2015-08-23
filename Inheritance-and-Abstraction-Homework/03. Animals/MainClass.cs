// Problem 3. Animals

// Create arrays of different kinds of animals and calculate the average age of each kind of animal using LINQ.

using System;
using System.Linq;

namespace _03.Animals
{
    public class MainClass
    {
        public static void Main()
        {
            Dog[] dogs =
            {
                new Dog("Charlie", 3, "male"),
                new Dog("Johnny", 6, "male"),
                new Dog("Rachel", 4, "female"),
                new Dog("Richi", 1, "male")
            };

            Frog[] frogs =
            {
                new Frog("Chocho", 2, "male"),
                new Frog("Mimi", 5, "female"),
                new Frog("Bobo", 4, "male"),
                new Frog("Toni", 1, "male")
            };

            Cat[] cats =
            {
                new Cat("Chiko", 4, "male"),
                new Cat("Bobo", 4, "female"),
                new Kitten("Chocho", 1),
                new Tomcat("Petur", 4),
                new Tomcat("Francis", 7)
            };

            double dogsAverageAge = dogs.Average(dog => dog.Age);
            double frogsAverageAge = frogs.Average(frog => frog.Age);
            double catsAverageAge = cats.Average(cat => cat.Age);

            Console.WriteLine("Average ages:");
            Console.WriteLine("Dogs: {0}\nFrogs:{1}\nCats: {2}", dogsAverageAge, frogsAverageAge, catsAverageAge);
        }
    }
}