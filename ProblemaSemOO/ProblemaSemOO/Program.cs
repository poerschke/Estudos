using System;
using System.Globalization;

namespace ProblemaSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidadas do triangulo Y: ");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xP = (xA + xB + xC) / 2;
            double yP = (yA + yB + yC) / 2;

            double xArea = Math.Sqrt(xP * (xP - xA) * (xP - xB) * (xP - xC));
            double yArea = Math.Sqrt(yP * (yP - yA) * (yP - yB) * (yP - yC));
            Console.WriteLine("Area triangulo X: "+ xArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area triangulo Y: "+ yArea.ToString("F4", CultureInfo.InvariantCulture));
            if (xArea > yArea)
            {
                Console.WriteLine("Maior area triangulo X");
            }
            else
            {
                Console.WriteLine("Maior area triangulo Y");
            }

        }

    }
}