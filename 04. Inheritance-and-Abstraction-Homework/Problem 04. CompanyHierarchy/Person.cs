using System;

namespace _04.CompanyHierarchy
{
    abstract public class Person : IPerson
    {
        private ushort id;
        private string firstName;
        private string lastName;

        protected Person(ushort id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public ushort ID
        {
            get { return this.id; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("id", "ID can't be null!");
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "First name can't be null or empty!");
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
                    throw new ArgumentNullException("lastName", "Last name can't be null or empty!");
                }
                this.lastName = value;
            }
        }
    }
}