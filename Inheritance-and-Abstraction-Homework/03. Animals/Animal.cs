using System;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private ushort age;
        private string gender;

        public Animal(string name, ushort age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name can't be null or empty!");
                }
                this.name = value;
            }
        }

        public ushort Age
        {
            get { return this.age; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("age", "Age can't be null!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("gender", "Gender can't be null or empty!");
                }
                this.gender = value;
            }
        }

        public abstract void ProduceSound();
    }
}