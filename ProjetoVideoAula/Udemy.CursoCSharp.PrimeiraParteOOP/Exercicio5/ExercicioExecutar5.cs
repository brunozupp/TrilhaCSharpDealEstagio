using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio5
{
    public class ExercicioExecutar5
    {
        public static void Executar()
        {
            double valor = CalculadoraDeMoeda.ConverterRealParaDolar(3.10, 200.0);

            Console.WriteLine(valor);
        }
    }
}
