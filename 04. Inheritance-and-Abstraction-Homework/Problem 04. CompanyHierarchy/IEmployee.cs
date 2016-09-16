namespace _04.CompanyHierarchy
{
    interface IEmployee
    {
        uint Salary { get; set; }
        Department Department { get; set; }
    }
}