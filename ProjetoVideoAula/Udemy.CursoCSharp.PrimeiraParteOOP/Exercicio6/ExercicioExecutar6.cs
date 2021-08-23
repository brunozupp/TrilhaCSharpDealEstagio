using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio6
{
    public class ExercicioExecutar6
    {
        public static void Executar()
        {
            Produto p1 = new Produto("Produto 1", 3000.0);

            Produto p2 = new Produto("Produto 2", 500.0, 40);

            //p2.Categoria = "VELHA"; // Muda o valor
            //p2.Categoria = "B"; // Não muda o valor por causa da validação

            Console.WriteLine(p2.Categoria);

            // Precisei tirar o private do set. Precisa de ter o construtor padrão para essa alternativa funcione
            Produto p3 = new Produto
            {
                Nome = "Produto 3",
                Preco = 145.00,
                Quantidade = 9

            };

            Produto p4 = new Produto()
            {
                Nome = "Produto 4",
                Preco = 145.00,
                Quantidade = 9

            };
        }
    }
}
