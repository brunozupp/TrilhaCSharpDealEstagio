using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio8
{
    public class ExercicioExecutar8
    {
        public static void Executar()
        {
            var valor = Calcular(1, 2, 3, 4);
            Console.WriteLine(valor);
        }

        private static double Calcular(params double[] valores)
        {
            double sum = 0.0;

            foreach (double valor in valores)
            {
                sum += valor;
            }

            return sum;
        }
    }
}
