namespace _02.BankOfKurtovoKonare.Accounts
{
    using _02.BankOfKurtovoKonare.Customers;

    internal interface IAccount
    {
        ICustomer Customer { get; set; }
        decimal BalanceInDollars { get; set; }
        double MonthlyInterestRateInPercent { get; set; }

        decimal CalcInterest(short months);
        void Deposit(decimal amount);
    }
}