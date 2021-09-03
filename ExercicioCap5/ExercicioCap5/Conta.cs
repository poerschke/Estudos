using System.Globalization;
using System;

namespace ExercicioCap5
{
    class Conta
    {
        public int ContaCorrente { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public Conta(int conta, string nome)
        {
            ContaCorrente = conta;
            Nome = nome;
            Saldo = 0.0;
        }

        public Conta(int conta, string nome, double valor) : this(conta, nome)
        {
            deposito(valor);
        }

        public void deposito(double valor)
        {
            Saldo += valor;
        }

        public void saque(double valor)
        {
            if(Saldo > valor)
            {
                Saldo -= valor + 5;
            }
            else
            {
                Console.WriteLine("Erro: Saldo insuficiente");
            }
        }

        public override string ToString()
        {
            return "Conta: " + ContaCorrente + ", Titular: " + Nome + " Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
