using System;
using Secao_9.Entities;
using Secao_9.Entities.Enums;
using System.Globalization;

namespace Secao_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter tipo enumerado para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Converter string para tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

            //Categorias de Classes:
            /*
             * Por questões de design tais como organização, flexibilidade, reuso,
             * delegação, etc., há várias categorias de classes:
             * 
             * [Views]: Telas;
             * 
             * [Controllers]: O controlador faz o meio de campo entre a tela e o sistema;
             * 
             * [Entities]: Entidades de negócio (produtos, clientes, etc);
             * 
             * [Services]: Serviços;
             * 
             * [Repositories]: Objetos responsaveis por acessar os dados de um banco de dados ou de repositórios de dados;
            */

            /*
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Programa para calcular os ganhos de um empregado");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("------------------");
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("------------------");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"Enter #{i} contract date: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
            */

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful contry!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
