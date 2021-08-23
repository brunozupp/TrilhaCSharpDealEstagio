namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio6
{
    public class Produto
    {
        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;

            /* Essa linha é indispensável, pois recebe o valor 0 por padrão se não inicializado o valor */
            Quantidade = 0;
        }

        /*public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }*/

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
            _categoria = "Nova";
            PorcentagemDesconto = 0.05;
        }


        // Exemplo de Auto Properties - O problema dessa solução seria as validações que eu
        // consigo ter no Properties normal.
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public double PorcentagemDesconto { get; private set; }

        // Exemplo de Propertie

        private string _categoria;

        public string Categoria
        {
            get { return _categoria; }

            // Para obter o valor que está vindo, utilizar a palavra 'value'
            set
            {
                if (value != null && value.Length > 1)
                {
                    _categoria = value;
                }
            }
        }

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
