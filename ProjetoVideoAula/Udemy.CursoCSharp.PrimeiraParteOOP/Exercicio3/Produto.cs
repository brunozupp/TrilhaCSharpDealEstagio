namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio3
{
    public class Produto
    {
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome { get; private set; }

        public double Preco { get; private set; }

        public int Quantidade { get; private set; }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return string.Format("Produto = {0}\nQuantidade = {1}\nPreço = R$ {2}\nValor Total Em Estoque = R$ {3}\n",
                Nome, Quantidade, Preco, ValorTotalEmEstoque()
            );
        }
    }
}
