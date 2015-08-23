using System;

namespace _04.CompanyHierarchy
{
    public class Sale :ISale
    {
        private string productName;
        private DateTime date;
        private uint price;

        public Sale(string productName, DateTime date, uint price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("productName", "Product name can't be null or empty!");
                }
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("date", "Date can't be null!");
                }
                this.date = value;
            }
        }

        public uint Price
        {
            get { return this.price; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("price", "Price can't be null!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Product name: {0}, Date: {1}, Price: {2}", this.ProductName, this.Date, this.Price);
        }
    }
}