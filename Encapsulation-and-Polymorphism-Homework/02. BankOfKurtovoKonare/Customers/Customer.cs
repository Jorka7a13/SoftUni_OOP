namespace _02.BankOfKurtovoKonare.Customers
{
    using System;

    internal abstract class Customer : ICustomer
    {
        private string name;

        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name can't be null or empty!");
                }
                this.name = value;
            }
        }
    }
}