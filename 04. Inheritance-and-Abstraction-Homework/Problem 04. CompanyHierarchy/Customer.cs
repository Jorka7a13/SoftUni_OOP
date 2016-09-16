using System;

namespace _04.CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(ushort id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0 || value == null)
                {
                    throw new ArgumentNullException("netPurchaseAmount", "Net purchase amount can't be null or negative!");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1} {2}, Net purchase amount: {3}", 
                this.ID, this.FirstName, this.LastName, this.NetPurchaseAmount);
        }
    }
}