using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}