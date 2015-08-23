using System;

namespace _04.SoftwareUniversityLearningSystem
{
    class Person
    {
        private string firstName;
        private string lastName;
        private short age;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "First name must not be null or empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "Last name must not be null or empty!");
                }
                this.lastName = value;
            }
        }

        public short Age
        {
            get { return this.age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be greater than 1!");
                }
                this.age = value;
            }
        }

        public Person(string firstName, string lastName, short age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}