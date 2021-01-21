using System;
using System.Collections.Generic;
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

            /*
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
            */

            /*
            //Modificador de parâmetros: [params]

            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(result);


            //Modificador de parâmetro: [ref]

            int a = 10;
            Calculator.Triple(a); //não funciona pois a variável x apenas existe no próprio escopo.
            Console.WriteLine(a);

            Calculator.TripeRef(ref a); //aqui funciona pois a variável local x muda o valor de a como referência.
            Console.WriteLine(a);


            //Modificador de parâmetro: [out]
            
            int b = 10;
            int triple;
            Calculator.TripleOut(b, out triple); //a diferença é que a variável triple não precisou ser iniciada, pois é uma variável de saída.
            Console.WriteLine(triple);
            */

            //Instanciar uma lista:
            List<string> list = new List<string>();

            //Instanciar já passando elementos:
            List<string> list2 = new List<string> { "Maria", "Alex" };

            List<string> list3 = new List<string>();

            //Comando Add - Adiciona por padrão ao final da lista
            Console.WriteLine("Nomes adicionados na lista - (Add):");
            Console.WriteLine("-------------------------");
            

            list.Add("Pablo");
            list.Add("Joao");
            list.Add("Fabio");
            list.Add("Felipe");
            list.Add("Fritz");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Comando Insert - Adiciona na posição referenciada
            list.Insert(2, "Marco");

            Console.WriteLine("Nome inserido na lista - (Insert):");
            Console.WriteLine("-------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            Console.WriteLine("Buscando elementos na lista: ");
            Console.WriteLine("-------------------------");

            //Comando Count - Conta o número dos elementos da lista
            Console.WriteLine("List count - (Count): " + list.Count);

            //Comando Find - Encontra a primeira ocorrência que satisfaça um predicado
            string s1 = list.Find(x => x[0] == 'F');  //expressão lambda
            Console.WriteLine("First 'F' - (Find): " + s1);

            //Comando FindLast - Encontra a última ocorrência que satisfaça um predicado
            string s2 = list.FindLast(x => x[0] == 'F');
            Console.WriteLine("Last 'F' - (FindLast): " + s2);

            //Comando FindIndex - Encontra a primeira posição que satisfaça um predicado
            int pos1 = list.FindIndex(x => x[0] == 'F');
            Console.WriteLine("First position 'F' - (FindIndex): " + pos1);

            //Comando FindLastIndex - Encontra a última posição que satisfaça um predicado
            int pos2 = list.FindLastIndex(x => x[0] == 'F');
            Console.WriteLine("Last position 'F'- (FindLastIndex): " + pos2);
            Console.WriteLine();

            //Comando FindAll - Filtra a lista com base em um predicado (cria uma nova lista contendo somente os elementos que satisfaçam o predicado)
            List<string> list4 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("Lista filtrada com os nomes que possuem 5 caracteres - (FindAll): ");
            Console.WriteLine("-------------------------");
            foreach (string obj in list4)
            {
                Console.WriteLine(obj);
            }

            //Comando Remove - espera como parâmetro uma string
            list4.Remove("Fabio");
            Console.WriteLine();

            Console.WriteLine("Removendo 'Fabio' - (Remove): "); //caso o nome passado esteja incorreto ele simplesmente não remove
            Console.WriteLine("-------------------------");
            foreach (string obj in list4)
            {
                Console.WriteLine(obj);
            }

            //Comando RemoveAll - remove os elementos de uma lista de acordo com um predicado
            list4.RemoveAll(x => x[0] == 'F');
            Console.WriteLine();

            Console.WriteLine("Removendo todos que começam com 'F' - (RemoveAll): ");
            Console.WriteLine("-------------------------");

            foreach (string obj in list4)
            {
                Console.WriteLine(obj);
            }

            //Comando RemoveAt - remove o elemento pela posição dele
            list4.RemoveAt(1);

            Console.WriteLine();
            Console.WriteLine("Removendo elemento da posicao 1 - (RemoveAt): ");
            Console.WriteLine("-------------------------");

            foreach (string obj in list4)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //
            Console.WriteLine("Nomes adicionados novamente na lista - (Add):");
            Console.WriteLine("-------------------------");


            list4.Add("Pablo");
            list4.Add("Joao");
            list4.Add("Fabio");
            list4.Add("Felipe");
            list4.Add("Fritz");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            //Comando RemoveRange - remove os elementos por uma faixa
            list4.RemoveRange(2, 3);

            Console.WriteLine("Removendo elementos de uma 'faixa' da lista - (RemoveRange):");
            Console.WriteLine("-------------------------");

            foreach (string obj in list4)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
