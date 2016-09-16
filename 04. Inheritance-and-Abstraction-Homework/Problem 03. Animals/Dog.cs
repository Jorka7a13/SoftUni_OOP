using System;

namespace _03.Animals
{
    public class Dog : Animal
    {

        public Dog(string name, ushort age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(String.Format("My name is {0}. Woof!", this.Name));
        }
    }
}