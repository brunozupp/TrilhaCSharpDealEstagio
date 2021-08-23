using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio7
{
    public class Account
    {
        public string Titular { get; set; }

        public int Numero { get; private set; }

        public double Saldo { get; private set; }

        public Account(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }

        public Account(string titular, int numero, double saldo) : this(titular, numero)
        {
            if (saldo < 0.0)
            {
                throw new ArgumentException("Saldo não pode ser negativo");
            }

            Saldo = saldo;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.0);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return string.Format("Titular = {0}\nNúmero da conta = {1}\nSaldo = R$ {2}\n", Titular, Numero, Saldo);
        }
    }
}
