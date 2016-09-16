// Problem 4. Company Hierarchy

// Create several employees of type Manager, SalesEmployee and Developer and add them in a single collection. 
// Finally, print them in a for-each loop.

using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    public class MainClass
    {
        public static void Main()
        {
            List<Sale> sales = new List<Sale>()
            {
                new Sale("Shampoo", new DateTime(2015, 1, 18), 1500),
                new Sale("Pantofi", new DateTime(2014, 1, 22), 750)
            };

            RegularEmployee mishoRegEm = new RegularEmployee(21123, "Mihail", "Zapryanov", 3000, Department.Production);
            SalesEmployee monikaSaEm = new SalesEmployee(20133, "Monika", "Mihaileva", 2300, Department.Sales, sales);

            Project depProject = new Project("New Department of defense terminal", new DateTime(2014, 4, 25),
                "Detail detail detail...?");
            depProject.CloseProject();

            List<Project> projects = new List<Project>()
            {
                depProject,
                new Project("The classic snake game", new DateTime(2002, 2, 4), "The game should contain at least 1 snake!")
            };
            Developer goshkoDev = new Developer(0010101, "Georgi", "Stanimirchev", 2700, Department.Production, projects);

            List<Employee> employees = new List<Employee>() { mishoRegEm, monikaSaEm, goshkoDev };
            Manager ivan = new Manager(20342, "Ivan", "Stoyanov", 2000, Department.Marketing, employees); 

            Customer ginka = new Customer(20012, "Ginka", "Chikerova", 180M);

            List<Person> persons = new List<Person>() {ivan, ginka};

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}