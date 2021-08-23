namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio9
{
    public class Account
    {
        public int Number { get; protected set; }

        public string Holder { get; set; }

        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // virtual -> para habilitar a sobreescrita nas classes filhas
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
