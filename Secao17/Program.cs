﻿using System;
using Secao17.Services;
using System.Linq;
using System.Collections.Generic;
using Secao17.Entities;

namespace Secao17
{

    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationMulticast(double n1, double n2);
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /*
            double a = 10;
            double b = 12;

            //O objeto OP passa ser uma referência à função CalculationService.Sum
            BinaryNumericOperation op = CalculationService.Sum;

            //Sintaxe alternativa (mais verboso)
            BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Sum);


            double result = op(a, b);
            //Sintaxe alternativa:
            double result2 = op2.Invoke(a, b);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            //Lembrando que o Delegate é uma assinatura com type safety.
            //Ou seja, caso atribua CalculationService.Square ele não vai aceitar, pois está disposto que ele recebe 2 números double e retorna um double


            //Multicast - Nesse momento o op3 aponta para duas funções
            BinaryNumericOperationMulticast op3 = CalculationServiceMulticast.ShowSum;
            op3 += CalculationServiceMulticast.ShowMax;

            //Primeiro mostra a soma, depois mostra o max
            op3.Invoke(a, b);
            //ou sintaxe alternativa:
            op3(a, b);
            */

            /*
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 }; //poderia ser um arquivo, banco de dados, etc.

            // Define the query expression
            IEnumerable<int> result = numbers  //as bibliotecas preferem gerar resultados mais genéricos (IEnumerable) que é compatível com as demais funções de coleção
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
            */

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            //Funcao Print definida como método estático
            Print("TIER 1 AND PRICE < 900", r1);

            //Nomes dos produtos da categoria tools

            //Select recebe uma função, retorna um produto do tipo que você quiser
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //Retorna objeto começado com 'C', mas somente nome, preço e categoria.
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //Produtos que o TIER seja igual a 1, ordenados por preço e se empatar ordenar por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //Skip e Take = usados para paginação
            //Skip(2) = pula os dois primeiros
            //Take(4) = pega os 4 primeiros
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            //FirstOrDefault = se não encontrar ninguém retorna nulo
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            //Um resultado ou nenhum
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); //ou um ou nenhum elemento
            Console.WriteLine("Single or default test3: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault(); //ou um ou nenhum elemento
            Console.WriteLine("Single or default test4: " + r9);

            //Maximo baseado no preço
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            //Menor preço
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            //Soma dos preços da categoria 1
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            //Media dos preços da categoria 1
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            //Default if empty (se a coleção for vazia, atribui o resultado zero
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            //Select e Agregate = (MAP e REDUCE) em outras linguagens.
            //Serve para montar uma operação agregada personalizada (A minha própria alteração)
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y); //Agregate recebe 2 argumentos x e y, e realiza a soma deles
            Console.WriteLine("Category 1 aggregate sum: " + r15);

            //Recebendo uma sobrecarga de valor padrão inicial
            var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r16);

            //Agrupamento
            var r17 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r17) //cada elemento é desse tipo IGrouping, contendo uma chave (category) e uma coleção (product)
            {
                Console.WriteLine("Category " + group.Key.Id);
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
