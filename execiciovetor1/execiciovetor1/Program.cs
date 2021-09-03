using System;

namespace execiciovetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] Quarto = new Quartos[10];
            Console.WriteLine("Quartos: ");
            int QtdQuartos = int.Parse(Console.ReadLine());
            for (int x = 0; x < QtdQuartos; x++)
            {
                Console.Write("Quarto: ");
                int NumQuarto = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("email: ");
                string Email = Console.ReadLine();
                Quarto[x] = new Quartos { Quarto = NumQuarto, Nome = Nome, Email = Email };
            }

            for (int x = 0; x < QtdQuartos; x++)
            {
                if (Quarto[x] != null)
                {
                    Console.WriteLine("Quarto #" + Quarto[x].Quarto.ToString());
                    Console.WriteLine("Nome: " + Quarto[x].Nome);
                    Console.WriteLine("Email: " + Quarto[x].Email);
                }
            }
        }
    }
}
