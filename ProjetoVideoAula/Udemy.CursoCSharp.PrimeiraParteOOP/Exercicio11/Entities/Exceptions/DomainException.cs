using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio11.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
