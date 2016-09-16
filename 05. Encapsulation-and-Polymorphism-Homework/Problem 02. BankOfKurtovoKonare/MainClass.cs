// Problem 2. Bank of Kurtovo Konare

// Write a program to model the bank system with classes and interfaces. 

namespace _02.BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;
    using _02.BankOfKurtovoKonare.Accounts;
    using _02.BankOfKurtovoKonare.Customers;

    internal class MainClass
    {
        public static void Main()
        {
            List<IAccount> accounts = new List<IAccount>
            {
                new LoanAccount(new Company("Jurassic Pork"), 10000m, 9.4),
                new MortgageAccount(new Individual("Batman"), 0.01m, 4),
                new DepositAccount(new Individual("Bai Nakov"), 1000m, 2.6),                
            };

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }

            DepositAccount floristGumpAccount = new DepositAccount(new Company("Florist Gump"), 17500m, 5.5);
            floristGumpAccount.Withdraw(2500);
            floristGumpAccount.Deposit(1000);
            Console.WriteLine(floristGumpAccount); // Should be 16000

            Console.WriteLine();

            Console.WriteLine(floristGumpAccount.Customer.Name + " -> " + floristGumpAccount.CalcInterest(4));

            floristGumpAccount.Withdraw(15500);
            //Console.WriteLine(floristGumpAccount.CalcInterest(8)); // Should throw exception

            IAccount papaRazziPizza = new LoanAccount(new Company("Papa Razzi"), 25000m, 9.4);
            Console.WriteLine(papaRazziPizza.Customer.Name + " -> " +papaRazziPizza.CalcInterest(2));

            IAccount baiSvetlin = new MortgageAccount(new Individual("Bai Nakov"), 1000m, 2.6);
            Console.WriteLine(baiSvetlin.Customer.Name + " -> " + baiSvetlin.CalcInterest(8));
            //Console.WriteLine(baiSvetlin.Customer.Name + " -> " + baiSvetlin.CalcInterest(4)); // Should throw exception

            IAccount dejaBrewAccount = new MortgageAccount(new Company("Deja Brew Brewery"), 8000, 2.6);
            Console.WriteLine(dejaBrewAccount.Customer.Name + " -> " + dejaBrewAccount.CalcInterest(1));
        }
    }
}