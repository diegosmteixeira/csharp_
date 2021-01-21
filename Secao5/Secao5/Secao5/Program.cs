using System;
using System.Globalization;

namespace Secao5
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            //Temos a propertie do Nome que passou a parecer como um atributo
            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

            //Note que quantidade e preco não podem ser alterados, pois não possuem métodos "Setters"
        }
    }
}
