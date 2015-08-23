namespace _02.BankOfKurtovoKonare.Accounts
{
    using System;
    using _02.BankOfKurtovoKonare.Customers;

    internal class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal ballanceInDollars, double monthlyInterestRateInPercent) 
            : base(customer, ballanceInDollars, monthlyInterestRateInPercent)
        {
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentNullException("amount", "Amount can't be negative!");
            }

            this.BalanceInDollars -= amount;
        }

        public override decimal CalcInterest(short months)
        {
            if (this.BalanceInDollars < 1000)
            {
                throw new Exception("Your balance is less than 1000. " +
                                  "Deposit accounts have no interest if their balance is less than 1000.");
            }

            return base.CalcInterest(months);
        }
    }
}
