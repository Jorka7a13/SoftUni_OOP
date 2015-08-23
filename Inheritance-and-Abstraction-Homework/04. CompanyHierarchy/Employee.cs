using System;

namespace _04.CompanyHierarchy
{
    abstract public class Employee : Person, IEmployee
    {
        private uint salary;
        private Department department;

        protected Employee(ushort id, string firstName, string lastName, uint salary, Department department) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public uint Salary
        {
            get { return this.salary; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("salary", "Salary can't be null!");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}",
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department);
        }
    }
}