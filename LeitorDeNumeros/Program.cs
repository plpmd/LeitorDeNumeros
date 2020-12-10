using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Quantos produtos você quer ler?");
            int qtdProdutos = int.Parse(Console.ReadLine());

            Produto[] arrayProdutos = new Produto[qtdProdutos];

            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.WriteLine("Digite o nome do " + (i + 1) + "º produto");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o preco do(a) " + nome);
                Console.WriteLine("Digite o preco do(a) {0}", nome);
                Console.WriteLine($"Digite o preco do(a) {nome}");
                double preco = double.Parse(Console.ReadLine());

                Produto produto = new Produto(nome, preco);

                arrayProdutos[i] = produto;
            }

            double valorTotal = 0;

            for (int i = 0; i < qtdProdutos; i++)
            {
                valorTotal += arrayProdutos[i].Preco;
            }

            Console.WriteLine("Média dos preços: R$" + (valorTotal/qtdProdutos).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
