using System;
using System.Globalization;


namespace Secao4
{
    class Program
    {
        /*
        O valor de Pi deve ser estático, pois vai ser usado em outra função de mesma classe que também é estática
        static double Pi = 3.14;
        */

        static void Main(string[] args)

        {
            /*
            Triangulo x;
            x = new Triangulo();

            Console.WriteLine("Programa para calcular a area do Triangulo X com duas casas decimais:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Entre com as medida do primeiro lado");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medida do segundo lado");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medida do terceiro lado");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine("A área do triangulo informado é " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            

            //----------------------------------------------------------------------------------------//

            
            Produto p = new Produto();

            Console.WriteLine("Programa para adicionar ou remover produtos de um Estoque: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            

            //----------------------------------------------------------------------------------------//

            Console.WriteLine("Programa para ler os valores da largura e altura de um retângulo: ");
            Console.WriteLine("------------------------------");
            
            Retangulo r1 = new Retangulo(); 

            Console.WriteLine("Digite a largura do retângulo: ");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Digite a altura do retângulo: ");
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Area = " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            

            //----------------------------------------------------------------------------------------//

            Funcionario f1 = new Funcionario();

            Console.WriteLine("Programa para visualizar os dados de um funcionário: ");
            Console.WriteLine("------------------------------");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario Total (sem descontos): "); 
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto sobre a Renda: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Nome e salário do funcionário: " + f1);
            Console.WriteLine();

            Console.Write("Qual a porcentagem de aumento do salário?");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porcentagem);
            Console.WriteLine();

            Console.WriteLine("Informações atualizadas: " + f1);
            */

            //----------------------------------------------------------------------------------------//

            Console.WriteLine("Programa para trabalhar com membros estáticos realizando cálculos de uma circunferência: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.WriteLine("Entre com o valor do raio da circunferência");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

            /*
             * O cálculo independe de instânciar um objeto. Direto com o nome da classe e passando um valor do raio
             * já é possível obter os valores do Volume, Circunferencia e Pi.
             */
        }
    }
}
