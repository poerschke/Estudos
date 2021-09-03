using System;
using System.Collections.Generic;
using System.Globalization;

namespace listas1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> id = new List<int>();
            List<string> name = new List<string>();
            List<double> salary = new List<double>();




            Console.Write("Funcionários a serem gestrados? ");
            int funcs = int.Parse(Console.ReadLine());

            for(int x = 1; x <= funcs; x++)
            {
                Console.WriteLine("Empregado #"+ x + ":");
                Console.Write("ID: ");
                id.Add(int.Parse(Console.ReadLine()));
                Console.Write("Name: ");
                name.Add(Console.ReadLine());
                Console.Write("Salary: ");
                salary.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.Write("informe o ID do funcionário que terá aumento salarial: ");

            int IdFunc = id.FindIndex(x => x == int.Parse(Console.ReadLine()));
        
            if(IdFunc == -1)
            {
                Console.WriteLine("Funcionário não encontrado");
            }
            else
            {
                Console.Write("Percentual de aumento? ");
                double per = double.Parse(Console.ReadLine());
                salary[IdFunc] = salary[IdFunc] + salary[IdFunc] * (per / 100);
                
            }

            Console.WriteLine("dados atualizados:");

            for(int x = 0; x < id.Count; x++)
            {
                Console.WriteLine(id[x] + ", " + name[x] + ", " + salary[x]);
            } 
        }
    }
}
