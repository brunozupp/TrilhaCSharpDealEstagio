using System;
using System.Collections.Generic;

namespace DealEstagio.TreinamentoCSharp.Aulas
{
    public class AulaCollection
    {
        public static void executar()
        {
            List<string> names = new List<string>();

            names.Add("Danilo");
            names.Add("Antonia");
            names.Add("Bruno");

            Console.WriteLine(names.Count);

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            if (names.Exists(e => e.Equals("Danilo")))
            {
                Console.WriteLine("Tem o Danilo");
            }
        }
    }
}
