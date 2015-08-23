using System;

namespace _04.CompanyHierarchy
{
    interface IProject
    {
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        bool IsOpen { get; set; }

        void CloseProject();
    }
}