using System;
using System.Globalization;


namespace Capitulo2
{
    class Program
    {
        static void Main(string[] args)

        {
            Triangulo x;
            x = new Triangulo();

            Console.WriteLine("Programa para calcular a area do Triangulo X com duas casas decimais:");
            System.Console.WriteLine("------------------------------");
            Console.WriteLine("Entre com as medida do primeiro lado");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medida do segundo lado");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medida do terceiro lado");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine("A área do triangulo informado é " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
