using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    interface IManager
    {
        List<Employee> Employees { get; set; } 
    }
}