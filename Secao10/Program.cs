using System;
using Secao10.Entities;

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

            
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);  //Upcasting OK

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}