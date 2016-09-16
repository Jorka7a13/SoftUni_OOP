using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    public class SalesEmployee : Employee
    {
        private List<Sale> sales; 

        public SalesEmployee(ushort id, string firstName, string lastName, uint salary, 
            Department department, List<Sale> sales) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales  
        {
            get { return this.sales; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("sales", "Sales can't be null or empty!");
                }
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}, Sales:\n", 
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department);

            foreach (var sale in Sales)
            {
                result += "\t" + sale.ToString() + "\n";
            }

            return result;
        }
    }
}