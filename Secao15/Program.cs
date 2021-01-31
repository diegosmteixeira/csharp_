using System;

namespace Secao15
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
