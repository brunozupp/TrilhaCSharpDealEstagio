using System;

namespace DealEstagio.TreinamentoCSharp.Aulas
{
    public class AulaArray
    {
        public static void executar()
        {
            string[] names = new string[3];
            names[0] = "Danilo";
            names[1] = "Antonia";
            names[2] = "Bruno";

            Console.WriteLine(names.Length);


            Array.Sort(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            if (Array.Exists(names, e => e.Equals("Danilo")))
            {
                Console.WriteLine("Tem o Danilo");
            }
        }
    }
}
