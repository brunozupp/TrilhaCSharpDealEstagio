namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio1
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }

    }
}
