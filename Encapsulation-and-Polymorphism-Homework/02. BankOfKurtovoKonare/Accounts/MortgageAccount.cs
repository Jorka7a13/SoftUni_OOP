namespace _02.BankOfKurtovoKonare.Accounts
{
    using System;
    using _02.BankOfKurtovoKonare.Customers;

    internal class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal ballanceInDollars, double monthlyInterestRateInPercent) 
            : base(customer, ballanceInDollars, monthlyInterestRateInPercent)
        {
        }

        public override decimal CalcInterest(short months)
        {
            if (this.Customer.GetType().Name.Equals("Individual"))
            {
                if (months < 6)
                {
                    throw new Exception("No interest is accrued for the first 6 months on individuals' loan accounts!");
                }

                return base.CalcInterest((short) (months - 6));
            }
            else
            {
                if (months < 12)
                {
                    return this.BalanceInDollars * (decimal)(1 + ((this.MonthlyInterestRateInPercent / 2) / 100) * months);
                }

                return this.BalanceInDollars*(decimal) (1 + ((this.MonthlyInterestRateInPercent / 2) / 100) * 12) +
                       base.CalcInterest((short) (months - 12));
            }
        }
    }
}