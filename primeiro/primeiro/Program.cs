using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "douglas";
            int idade = 35;
            double variavel = 4658.465;
            Console.WriteLine("{0} tem {1} anos e tem saldo de R$ {2:F2}", nome, idade, variavel);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo de R$ {variavel:F2}");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo de R$ " + variavel.ToString("F2"));
        }
    }
}
