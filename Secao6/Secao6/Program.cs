using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apenas declarar a variável não possibilita que ela seja impressa
            Point p;

            //Para que permita imprimir a variável é necessário inicializar os valores
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();

            Console.WriteLine(p);
        }
    }
}
