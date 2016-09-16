using System;

namespace _03.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, ushort age)
            : base(name, age, "female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(String.Format("My name is {0}. Kittenish: mew!", this.Name));
        }
    }
}