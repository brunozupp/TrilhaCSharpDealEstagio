using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio2
{
    public class Exercicio2Executar
    {
        public static void Executar()
        {
            Funcionario f1 = new Funcionario("Sergio", 6300.00m);
            Funcionario f2 = new Funcionario("Mauro", 6700.00m);

            decimal media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine(media);
        }
    }
}
