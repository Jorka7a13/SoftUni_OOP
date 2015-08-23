using System;

namespace _01.School
{
    public abstract class Person : DetailedObject
    {
        private string name;

        protected Person(string name, string details = null)
            : base(details)
        {
            this.Name = name;
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
    }
}