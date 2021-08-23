﻿namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio9
{
    public class BusinessAccount : Account
    {

        public double LoanLimit { get; private set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }
    }
}
