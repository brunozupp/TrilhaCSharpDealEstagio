using System;
using System.Collections.Generic;
using System.IO;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio15
{
    public class ExercicioExecutar15
    {
        public static void Executar()
        {
            string path = @"C:\Users\bruni\Desktop\DealEstagio\TreinamentoC#\ProjetoVideoAula\Udemy.CursoCSharp.PrimeiraParteOOP\Exercicio15\names.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<String> list = new List<string>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    // Para isso funcionar o objeto deve implementar a interface icomparable
                    list.Sort();

                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
