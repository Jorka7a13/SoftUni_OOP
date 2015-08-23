namespace _02.BankOfKurtovoKonare.Accounts
{
    using System;
    using _02.BankOfKurtovoKonare.Customers;

    internal class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, decimal ballanceInDollars, double monthlyInterestRateInPercent) 
            : base(customer, ballanceInDollars, monthlyInterestRateInPercent)
        {
        }

        public override decimal CalcInterest(short months)
        {
            if (this.Customer.GetType().Name.Equals("Individual"))
            {
                if (months < 3)
                {
                    throw new Exception("No interest is accrued for the first 3 months on individuals' loan accounts!");
                }

                return base.CalcInterest((short) (months - 3));
            }
            else
            {
                if (months < 2)
                {
                    throw new Exception("No interest is accrued for the first 2 months on companies' loan accounts!");
                }

                return base.CalcInterest((short) (months - 2));
            }
        }
    }
}