using System;
using System.Globalization;

namespace Exercicios_Capitulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            string p;
            double media;

            Console.WriteLine("**Calcular entre duas pessoas qual é mais velha**");
            Console.WriteLine("Digite o nome da primeira pessoa:");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa");
            y.Idade = int.Parse(Console.ReadLine());

            if(x.Idade > y.Idade)
            {
                p = x.Nome;
            }
            else
            {
                p = y.Nome;
            }

            Console.WriteLine("A pessoa mais velha é: " + p);
            Console.WriteLine("-------------------------");


            Console.WriteLine("***Calcular a média de salário entre dois funcionários***");
            Console.WriteLine("Digite o nome do funcionário 1");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário 1");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do funcionário 2");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário 2");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f2.Salario + f1.Salario) / 2.0;

            Console.WriteLine("A média dos salários é " + media);



        }

    }
}
