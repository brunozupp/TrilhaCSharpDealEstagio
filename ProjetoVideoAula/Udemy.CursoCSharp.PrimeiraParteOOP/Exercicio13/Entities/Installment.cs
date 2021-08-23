﻿using System;
using System.Globalization;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio13.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }

        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
