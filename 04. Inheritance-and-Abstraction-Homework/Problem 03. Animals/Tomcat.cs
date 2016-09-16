using System;

namespace _03.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, ushort age)
            : base(name, age, "male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(String.Format("My name is {0}. Tomcatish: MEEEOW!", this.Name));
        }
    }
}