using System;
using System.Globalization;

namespace vetoresParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Product[] vetor = new Product[n];
            double soma = 0;
            for (int x = 0; x < n; x++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[x] = new Product { Name = nome, Price = preco };
                soma += preco;
            }
            Console.WriteLine("Preço médio: "+ (soma/n).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
