using System;
using System.Globalization;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio16
{
    public class Cliente : IComparable<Cliente>
    {
        public string Nome { get; set; }

        public double Salario { get; set; }

        public Cliente(string linhaArquivo)
        {
            string[] partes = linhaArquivo.Split(",");

            Nome = partes[0];
            Salario = Convert.ToDouble(partes[1], CultureInfo.InvariantCulture);
        }

        int IComparable<Cliente>.CompareTo(Cliente other)
        {
            //return Nome.CompareTo(other.Nome);
            return Salario.CompareTo(other.Salario);
        }

        public override string ToString()
        {
            return $"Cliente: {Nome}, R$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
