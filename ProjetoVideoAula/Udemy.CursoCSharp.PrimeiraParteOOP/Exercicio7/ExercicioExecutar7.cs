using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio7
{
    public class ExercicioExecutar7
    {
        public static void Executar()
        {
            try
            {
                Account acc1 = new Account("Bruno", 12345);
                Console.WriteLine(acc1);

                acc1.Saque(100.0);
                Console.WriteLine(acc1);

                acc1.Deposito(205.0);
                Console.WriteLine(acc1);

                Account acc2 = new Account("Marcos", 2345, 1000.0);
                Console.WriteLine(acc2);

                acc2.Saque(100.0);
                Console.WriteLine(acc2);

                acc2.Deposito(205.0);
                Console.WriteLine(acc2);

                Account acc3 = new Account("Teste Erro", 475, -58.0);
                Console.WriteLine(acc3);


            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
