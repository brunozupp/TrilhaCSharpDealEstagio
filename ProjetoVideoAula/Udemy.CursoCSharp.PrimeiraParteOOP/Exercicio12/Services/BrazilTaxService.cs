﻿namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio12.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {

            if (amount <= 100.0)
            {
                return amount * 0.2;
            }

            return amount * 0.15;
        }

    }
}
