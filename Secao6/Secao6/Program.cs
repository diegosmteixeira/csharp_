using System;
using System.Globalization;

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
            /*Console.WriteLine(x.Value); //lança uma exceção se você utilizá-la a partir de um nullable
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
            */

            /*
            Console.WriteLine("Digite o tamanho da Lista de pesssoas: ");
            int n = int.Parse(Console.ReadLine());

            //Criando um vetor na memória
            double[] vect = new double[n];

            //Inserindo dados no vetor
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite a altura da " + (i + 1) + " pessoa: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString(), CultureInfo.InvariantCulture);
            */

            //Diferença Vetor do tipo classe vs Vetor do tipo struct:
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do " + (i+1) + " produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do " + (i+1) + " produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
                Console.WriteLine();
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Produtos registrados: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(vect[i].Name + " R$ ");
                Console.Write(vect[i].Price.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
        }
    }
}
