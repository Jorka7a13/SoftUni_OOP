using Microsoft.Win32.SafeHandles;

namespace _02.BankOfKurtovoKonare.Accounts

{
    using System;
    using _02.BankOfKurtovoKonare.Customers;

    internal abstract class Account : IAccount
    {
        private ICustomer customer;
        private decimal balanceInDollars;
        private double monthlyInterestRateInPercent;

        protected Account(ICustomer customer, decimal ballanceInDollars, double monthlyInterestRateInPercent)
        {
            this.Customer = customer;
            this.BalanceInDollars = ballanceInDollars;
            this.MonthlyInterestRateInPercent = monthlyInterestRateInPercent;
        }

        public ICustomer Customer
        {
            get { return this.customer; }
            set {
                if (value == null)
                {
                    throw new ArgumentNullException("customer", "Customer can't be null!");
                }
                this.customer = value;
            }
        }

        public decimal BalanceInDollars
        {
            get { return this.balanceInDollars; }
            set {
                if (value < 0)
                {
                    throw new ArgumentNullException("balanceInDollars", "Balance can't be null or negative!");
                }
                this.balanceInDollars = value;
            }
        }

        public double MonthlyInterestRateInPercent
        {
            get { return this.monthlyInterestRateInPercent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("monthlyInterestRateInPercent", "Interest rate can't be null or negative!");
                }
                this.monthlyInterestRateInPercent = value;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentNullException("amount", "Amount can't be negative!");
            }

            this.BalanceInDollars += amount;
        }

        public virtual decimal CalcInterest(short months)
        {
            if (months < 0)
            {
                throw new ArgumentNullException("months", "Months can't be negative!");
            }

            return this.BalanceInDollars * (decimal)(1 + (this.MonthlyInterestRateInPercent / 100) * months);
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Balance: {1}", this.Customer.Name, this.BalanceInDollars);
        }
    }
}