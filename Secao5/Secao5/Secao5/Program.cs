using System;
using System.Globalization;

namespace Secao5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Produto p = new Produto("TV", 500.00, 10);

            //Temos a propertie do Nome que passou a parecer como um atributo
            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

            //Note que quantidade e preco não podem ser alterados, pois não possuem métodos "Setters"
            */

            ContaBancaria conta;

            Console.Write("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor de depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta: " + conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: " + conta);

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: " + conta);
        }
    }
}
