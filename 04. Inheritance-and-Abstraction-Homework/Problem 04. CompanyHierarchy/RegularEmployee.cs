using System;

namespace _04.CompanyHierarchy
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(ushort id, string firstName, string lastName, uint salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}", 
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department);
        }
    }
}