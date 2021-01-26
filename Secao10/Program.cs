using System;
using System.Collections.Generic;
using Secao10.Entities;
using System.Globalization;
using Secao10.Entities.Enums;

namespace Secao10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            // protected - no programa principal não é possível modificar o valor protected
            // apenas as subclasses ou a própria classe podem alterar esse valor:
            // account.Balance = 200.0; //não é possível
            

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            //UPCASTING = Conversão da subclasse para superclasse

            Account acc1 = bacc; // Conversão de um <objeto> BusinessAccount para uma <variável> Account
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // Conversão de uma instânciação subclass para superclasse
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING = Conversão da superclasse para subclasse

            BusinessAccount acc4 = (BusinessAccount)acc2;
            //é necessário um casting (BusinessAccount) antes, 
            //pois o compilador não enxerga o objeto que já está associado à acc2 (que é uma BusinessAccount)
            //apenas enxerga o tipo (Account) da variável

            acc4.Loan(100.0);
            //acc2.Loan(100.0) não existe, pois o compilador apenas enxerga o tipo Account para acc2
            //apenas existirá o acc2.Loan se for feito um Downcasting antes.

            Console.WriteLine("BusinessAccount acc5 = (BusinessAccount)acc3; GERA ERRO");
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            //***Embora o compilador não declare ERRO em tempo de execução ele acontece***
            //*BusinessAccount não é compatível com SavingsAccount*

            Console.WriteLine("Downcasting é uma operação insegura");

            //Teste de possibilidade de conversão:
            if (acc3 is BusinessAccount)
            {
                //Essa operação vai falhar, pois acc3 é SavingsAccount
                BusinessAccount acc6 = (BusinessAccount)acc3;
                acc6.Loan(200.0);
                Console.WriteLine("Loan! - Emprestimo feito");
            }

            if (acc3 is SavingsAccount)
            {
                //Essa operação terá êxito e será impressa.
                SavingsAccount acc6 = (SavingsAccount)acc3;
                acc6.UpdateBalance();
                Console.WriteLine("Update do Balance");
            }

            //Sintaxe alternativa

            //BusinessAccount acc7 = acc3 as BusinessAccount;
            */

            /*
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);  //Upcasting OK

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            */


            /*
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            */

            /*
            //Classe Abstract

            //mesmo a classe sendo Abstract é possível gerar uma lista
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));
            //Nota: caso a classe Account não existisse, 
            //      não seria possível formar uma lista misturada com tipos diferentes.

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
            */

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}