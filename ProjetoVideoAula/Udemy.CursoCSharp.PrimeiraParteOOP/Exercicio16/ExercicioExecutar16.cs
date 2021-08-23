using System;
using System.Collections.Generic;
using System.IO;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio16
{
    public class ExercicioExecutar16
    {
        public static void Executar()
        {
            string path = @"C:\Users\bruni\Desktop\DealEstagio\TreinamentoC#\ProjetoVideoAula\Udemy.CursoCSharp.PrimeiraParteOOP\Exercicio16\clientes.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Cliente> list = new List<Cliente>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Cliente(sr.ReadLine()));
                    }

                    // Para isso funcionar o objeto deve implementar a interface icomparable
                    list.Sort();

                    foreach (Cliente cliente in list)
                    {
                        Console.WriteLine(cliente);
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
