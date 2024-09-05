using System;

namespace DescontoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('-', 40);
            Console.WriteLine("Informe o nome do produto:");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto:");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            double desconto = CalcularDesconto(quantidadeProduto);

            Produto produto = new Produto(nomeProduto, precoProduto, quantidadeProduto);

            double precoTotal = produto.CalcularPrecoTotal(desconto);
            double valorDesconto = produto.CalcularDesconto(precoProduto * quantidadeProduto, precoTotal);

            Console.WriteLine(sep);
            Console.WriteLine($"Valor total: {precoTotal.ToString("C")}");
            Console.WriteLine(sep);
            Console.WriteLine($"Desconto: {valorDesconto.ToString("C")}");
            Console.WriteLine(sep);
        }

        static double CalcularDesconto(int quantidade)
        {
            if (quantidade > 50)
                return 0.25;
            if (quantidade > 20)
                return 0.20;
            if (quantidade > 10)
                return 0.10;
            return 0;
        }
    }
}

