using System;

namespace _04.CompanyHierarchy
{
    interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        uint Price { get; set; }
    }
}