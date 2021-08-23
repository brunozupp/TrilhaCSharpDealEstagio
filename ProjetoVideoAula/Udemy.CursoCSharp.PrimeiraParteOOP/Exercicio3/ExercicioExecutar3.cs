using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio3
{
    class ExercicioExecutar3
    {
        public static void Executar()
        {
            Produto p = new Produto("Arroz", 15.00, 10);
            Console.WriteLine("Produto normal");
            Console.WriteLine(p);

            Console.WriteLine("Produto adicionado");
            p.AdicionarProdutos(5);
            Console.WriteLine(p);

            Console.WriteLine("Produto removido");
            p.RemoverProdutos(10);
            Console.WriteLine(p);
        }
    }
}
