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
            /*
            //Apenas declarar a variável não possibilita que ela seja impressa
            Point p;

            //Para que permita imprimir a variável é necessário inicializar os valores
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();

            Console.WriteLine(p);

            //Conclusão: Mesmo sendo um tipo struct deve-se inicializar (ou colocando valores, ou fazendo new).
            */


            //Declarando variáveis nulas (de valor opcional):

            Nullable<double> x = null;

            //ou
            double? y = 10.0;

            //pega o valor do X ou o valor padrão da variável x (no caso, o zero)
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //diz se dentro da variável existe, ou não, um valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //pegar valor diretamente
            /*Console.WriteLine(x.Value);*/ //lança uma exceção se você utilizá-la a partir de um nullable
            Console.WriteLine(y.Value);

            //testando com condições:
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            //*** Operador de Coalescência Nula ***

            double? z = null;

            // se o valor de Z for nulo, joga em k o valor à direita do ??
            double k = z ?? 20.0;

            Console.WriteLine(k);

        }
    }
}
