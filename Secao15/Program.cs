using System;
using System.Collections.Generic;
using Secao15.Entities;
using System.Globalization;

namespace Secao15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Tipo <T> Genérico pede que quando você for instanciar você declare o tipo que você vai usar
            PrintService<string> printService = new PrintService<string>();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i+1}º valor: ");
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x.ToString());
            }

            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First: " + printService.First());
            */

            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i< n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);

            //Restrições Possíveis
            //where T : struct
            //where T : class
            //where T : unmanaged
            //where T : new()     -que tenha um construtor
            //where T : <base type name>   -de qualquer outro tipo
            //where T : U   -outro tipo genérico que tenha definido na classe

        }
    }
}
