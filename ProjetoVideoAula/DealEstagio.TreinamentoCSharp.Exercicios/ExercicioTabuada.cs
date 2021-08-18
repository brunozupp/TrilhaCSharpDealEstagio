using System;

namespace DealEstagio.TreinamentoCSharp.Exercicios
{
    public class ExercicioTabuada
    {
        public static void executar()
        {
            while (true)
            {

                try
                {

                    Console.Write("Digite um número inteiro que vai de 2 a 1000 = ");

                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number < 2 || number > 1000)
                    {
                        throw new ArgumentOutOfRangeException("", "O número precisa estar entre 2 e 1000");
                    }

                    Console.WriteLine($"Tabuada do número {number}");

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{i} x {number} = {i * number}");
                    }


                    break;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Entrada inválida. É preciso que seja um número inteiro");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
