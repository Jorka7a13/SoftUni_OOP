using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    public class Developer : Employee, IDeveloper
    {
        private List<Project> projects;

        public Developer(ushort id, string firstName, string lastName, uint salary, 
            Department department, List<Project> projects) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("projects", "Projects can't be null or empty!");
                }
                this.projects = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("ID: {0}, Name: {1} {2}, Salary: {3}, Department: {4}, Projects:\n", 
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department);

            foreach (var project in Projects)
            {
                result += "\t" + project.ToString() + "\n";
            }

            return result;
        }
    }
}