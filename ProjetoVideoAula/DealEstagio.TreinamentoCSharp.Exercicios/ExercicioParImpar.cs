using System;

namespace DealEstagio.TreinamentoCSharp.Exercicios
{
    class ExercicioParImpar
    {
        public static void executar()
        {

            while (true)
            {
                
                try
                {

                    Console.Write("Digite um número = ");

                    int number = Convert.ToInt32(Console.ReadLine());

                    bool isOdd = number % 2 != 0;

                    Console.WriteLine(isOdd ? "Número é ímpar" : "Número é par");

                    break;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Entrada inválida. É preciso que seja um número inteiro");
                }
            }

        }
    }
}
