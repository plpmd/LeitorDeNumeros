using System;
using System.Globalization;

namespace LeitorDeNumeros
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public int DefineTamanhoArray()
        {
            Console.WriteLine("Quantos produtos deseja cadastrar?");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            return quantidadeProdutos;
        }


        public Produto[] LeituraDadosProduto(int quantidadeProdutos)
        {
            Produto[] listaProdutos = new Produto[quantidadeProdutos];

            for (int i = 0; i < (quantidadeProdutos); i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}º produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite o preço do(a) {nome}: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Produto produto = new Produto(nome, preco);

                listaProdutos[i] = produto;
            }

            return listaProdutos;
        }


        public double CalculaMediaPrecos(Produto[] listaProdutos)
        {
            double valorTotalProdutos = 0.0;
            for (int i = 0; i < listaProdutos.Length; i++)
            {
                valorTotalProdutos = valorTotalProdutos + listaProdutos[i].Preco;
            }
            double mediaValoresProdutos = valorTotalProdutos / listaProdutos.Length;
            return mediaValoresProdutos;
        }


        public void ImprimeMediaPrecos(double mediaValoresProdutos)
        {
            Console.WriteLine("A média dos valores dos produtos é de: R$ {0} reais", mediaValoresProdutos.ToString("F2"));
            Console.ReadLine();
        }

    }
}
