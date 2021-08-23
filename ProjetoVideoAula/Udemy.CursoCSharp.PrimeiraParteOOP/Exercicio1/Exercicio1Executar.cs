using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio1
{
    public class Exercicio1Executar
    {

        public static void Executar()
        {
            Pessoa p1 = new Pessoa("Bruno", 22);
            Pessoa p2 = new Pessoa("Renata", 14);

            string pessoaMaisVelha = p1.Idade > p2.Idade ? p1.Nome : p2.Nome;

            Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha}");
        }

    }
}
