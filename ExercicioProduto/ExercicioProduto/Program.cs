using System;


namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Entre com as informacoes do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int estoque = int.Parse(Console.ReadLine());
           
            Produto prod = new Produto(nome, preco, estoque);

            Console.WriteLine("Dados do produto: " + prod.ToString());
            Console.Write("Produtos a adicionar: ");
            prod.AdicionarProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + prod.ToString());
            Console.Write("Produtos a remover: ");
            prod.RemoverProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + prod.ToString());

        }
    }
}
