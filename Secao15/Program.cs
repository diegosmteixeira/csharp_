using System;
using Secao15.Entities;
using System.Collections.Generic;

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
            */

            /*
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine("a = b :" + a.Equals(b));
            Console.WriteLine("a = a :" + a.Equals(a));

            //Gera um HashCode diferente a cada execução
            Console.WriteLine("a Hash :" + a.GetHashCode());
            Console.WriteLine("b Hash:" + b.GetHashCode());

            //Exemplo com emails diferentes
            Client c1 = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client c2 = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine("São iguais? (Alex e Maria com emails diferentes): " + c1.Equals(c2));

            //Exemplo com emails iguais
            Client c3 = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client c4 = new Client { Name = "Alex", Email = "maria@gmail.com" };

            //Responde True, pois o critério de comparação foi o email
            Console.WriteLine("São iguais? (Alex e Maria com emails iguais): " + c3.Equals(c4));

            //Porém == retorna false, pois ele leva em consideração a 'referência de ponteiro de memória'
            Console.WriteLine("São iguais? c3 e c4? Não, pela referência de ponteiro de memória:" + (c3 == c4));
            */

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); //retorna true avisando que o elemento está contido no conjunto

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();


            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            //Union - união entre conjuntos
            SortedSet<int> c = new SortedSet<int>(a); //instancia e já insere todos os elementos de a
            c.UnionWith(b);

            Console.WriteLine();

            //Intersection - interseção entre conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);
            Console.WriteLine();

            //Difference - diferença entre conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        //IEnumerable é uma interface implementada por todas as coleções básicas do system.Collections
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
