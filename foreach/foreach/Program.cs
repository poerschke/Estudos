using System;

namespace foreacha
{
    class Program
{
    static void Main(string[] args)
    {
        string[] vetor = new string[] { "teste", "teste1", "teste2"};

        foreach(string vet in vetor)
        {
            Console.WriteLine(vet);
        }
    }
}
}
