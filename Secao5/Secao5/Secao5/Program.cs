using System;
using System.Globalization;

namespace Secao5
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());

            //Note que quantidade e preco não podem ser alterados, pois não possuem métodos "Setters"
        }
    }
}
