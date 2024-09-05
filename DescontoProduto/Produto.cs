namespace DescontoProduto
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double CalcularPrecoTotal(double desconto)
        {
            return Preco * Quantidade * (1 - desconto);
        }

        public double CalcularDesconto(double precoOriginalTotal, double precoTotal)
        {
            return precoOriginalTotal - precoTotal;
        }
    }
}