using System;
using System.Globalization;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio17
{
    public class Funcionario : IComparable<Funcionario>
    {
        public string Nome { get; set; }

        public double Salario { get; set; }

        public Funcionario(string linhaArquivo)
        {
            string[] partes = linhaArquivo.Split(",");

            Nome = partes[0];
            Salario = Convert.ToDouble(partes[1], CultureInfo.InvariantCulture);
        }


        public override string ToString()
        {
            return $"Cliente: {Nome}, R$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Funcionario other)
        {
            return Salario.CompareTo(other.Salario);
        }
    }
}
