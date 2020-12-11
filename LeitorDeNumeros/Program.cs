namespace LeitorDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("", 0.0);

            int quantidadeProdutos = produto.DefineTamanhoArray();

            Produto[] listaProdutos = produto.LeituraDadosProduto(quantidadeProdutos);

            double mediaValorProdutos = produto.CalculaMediaPrecos(listaProdutos);

            produto.ImprimeMediaPrecos(mediaValorProdutos);

        }
    }
}
