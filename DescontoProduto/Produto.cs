namespace DescontoProduto
{
    class Produto
    {
        private string _nome;
        private double _precoOriginal;
        private int _quantidade;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double PrecoOriginal
        {
            get { return _precoOriginal; }
            set { _precoOriginal = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            PrecoOriginal = preco;
            Quantidade = quantidade;
        }

        public double CalcularPrecoTotal(double desconto)
        {
            return PrecoOriginal * Quantidade * (1 - desconto);
        }

        public double CalcularDesconto(double precoOriginalTotal, double precoTotal)
        {
            return precoOriginalTotal - precoTotal;
        }
    }
}