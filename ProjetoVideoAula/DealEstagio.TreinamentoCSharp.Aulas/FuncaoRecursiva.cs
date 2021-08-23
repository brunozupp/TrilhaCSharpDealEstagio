using System;
using System.IO;

namespace DealEstagio.TreinamentoCSharp.Aulas
{
    public class FuncaoRecursiva
    {
        private static string absolutePath = @"C:\Users\bruni\Desktop\DealEstagio\TreinamentoC#\ProjetoVideoAula\DealEstagio.TreinamentoCSharp.Aulas\Arquivos";

        public static void Executar()
        {
            ReadFile("Arquivo", 1);
        }

        private static void ReadFile(string filename, int numberFile)
        {
            var file = absolutePath + @"\" + filename + numberFile + ".txt";

            if (!File.Exists(file))
            {
                return;
            }

            using (StreamReader reader = File.OpenText(file))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }

            ReadFile("Arquivo", ++numberFile);
        }
    }
}
