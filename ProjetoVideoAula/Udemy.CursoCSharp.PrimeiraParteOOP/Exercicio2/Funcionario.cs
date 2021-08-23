namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio2
{
    public class Funcionario
    {
        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; private set; }

        public decimal Salario { get; private set; }


    }
}
