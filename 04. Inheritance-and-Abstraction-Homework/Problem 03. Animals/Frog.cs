using System;

namespace _03.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, ushort age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(String.Format("My name is {0}. Croak!", this.Name));
        }
    }
}