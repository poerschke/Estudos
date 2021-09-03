using System;

namespace ExercicioCap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta = 0;
            string nome = "";
            char opcao;
            double valor = 0.0;
            Conta contaCorrente;
            

            Console.Write("Informe o numero da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.Write("Havera deposito inicial? (s/n): ");
            opcao = char.Parse(Console.ReadLine());

            if(opcao == 's')
            {
                Console.Write("Digite o valor inicial: ");
                valor = double.Parse(Console.ReadLine());
                contaCorrente = new Conta(conta, nome, valor);
            }
            else
            {
                contaCorrente = new Conta(conta, nome);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaCorrente.ToString());

            Console.Write("entre com o valor do deposito: ");
            valor = double.Parse(Console.ReadLine());
            contaCorrente.deposito(valor);

            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(contaCorrente.ToString());

            Console.Write("Informe o valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            contaCorrente.saque(valor);

            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(contaCorrente.ToString());



        }
    }
}
