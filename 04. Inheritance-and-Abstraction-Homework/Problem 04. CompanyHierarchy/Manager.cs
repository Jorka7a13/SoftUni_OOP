using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(ushort id, string firstName, string lastName, uint salary, 
            Department department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("employees", "Employees can't be null or empty!");
                }
                this.employees = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}, Employees:\n",
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department);

            foreach (var employee in Employees)
            {
                result += "\t" + employee.ToString();
            }

            return result;
        }
    }
}