namespace DescontoProduto
{
    class Produto
    {
        public string Nome { get; set; }
        public double PrecoOriginal { get; set; }
        public int Quantidade { get; set; }

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