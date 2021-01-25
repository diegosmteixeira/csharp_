using System;
using Secao10.Entities;

namespace Secao10
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            /*
             * protected - no programa principal não é possível modificar o valor protected
             * apenas as subclasses ou a própria classe podem alterar esse valor:
            
               account.Balance = 200.0; //não é possível
            */

        }
    }
}