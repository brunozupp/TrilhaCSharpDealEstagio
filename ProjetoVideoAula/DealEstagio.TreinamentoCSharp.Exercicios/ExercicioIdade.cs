using System;

namespace DealEstagio.TreinamentoCSharp.Exercicios
{
    public class ExercicioIdade
    {
        public static void executar()
        {
            while (true)
            {

                try
                {

                    Console.Write("Digite sua idade = ");

                    int age = Convert.ToInt32(Console.ReadLine());

                    if (age < 18)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sem Permissão", Console.ForegroundColor);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Permissão Concedida", Console.ForegroundColor);
                    }

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
