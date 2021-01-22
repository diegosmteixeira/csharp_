using System;
using System.Globalization;

namespace Secao_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Funções para strings

            string original = "abcde FGHIJ ABC abc DEFG   ";

            //Lembrando que string é imutável, o conteúdo da variável original não vai mudar!
            //string se comporta como uma Classe apontando para o conteúdo.

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.Write("Original: -" + original + "-");
            Console.WriteLine();

            //Todas letras para maiúsculo
            Console.Write("ToUpper: -" + s1 + "-");
            Console.WriteLine();

            //Todas letras para minúsculo
            Console.Write("ToLower: -" + s2 + "-");
            Console.WriteLine();

            //A função Trim() apaga os espaços em branco tanto no inicio quanto final
            Console.Write("Trim: -" + s3 + "-");
            Console.WriteLine();

            //Recortar uma parte da string a partir da terceira posição
            Console.Write("Substring(3): -" + s4 + "-");
            Console.WriteLine();

            //Recortar uma parte da string a partir da terceira posição cortando apenas 5 caracteres
            Console.Write("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine();

            //Substituir o caractere por outro
            Console.Write("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine();

            //Substituir caracteres por outros caracteres (não precisa ser do mesmo tamanho)
            Console.Write("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine();

            //Verificar se a string é vazia ou nula (essencial para formulários de cadastro)
            Console.Write("IsNullOrEmpty: " + b1);
            Console.WriteLine();

            //Verificar se a string é vazia, nula, ou um monte de espaço em branco (para formulários de cadastro)
            Console.Write("IsNullOrEmptyOrWhiteSpace: " + b2);
            Console.WriteLine();

            //Procurar a posição de letras dentro de uma string
            Console.Write("IndexOf('bc'): " + n1);
            Console.WriteLine();

            //Procurar a última ocorrência de letras
            Console.Write("LastIndexOf('bc'): " + n2);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            */


            //DateTime
            DateTime d = DateTime.Now;

            Console.WriteLine("Hora Atual: " + d);
            Console.WriteLine("Total de Ticks desde a hora zero: " + d.Ticks); 

            //Ano, mes, dia
            DateTime d1 = new DateTime(2018, 11, 25);
            Console.WriteLine("ano/mes/dia: " + d1);

            //Ano, mes, dia, hora
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine("ano/mes/dia hora:minutos:segundos: " + d2);

            //nao aceita milissegundos nesse formato
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // nesse tipo de formatação não aceita milissegundos (logo, o 500 não é impresso)
            Console.WriteLine("ano/mes/dia hora:minutos:segundos: " + d3 + " (não imprime milissegundos)");

            //Utilizando os builders
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow; //horário atual no Greenwich

            Console.WriteLine("Now: " + d4);
            Console.WriteLine("Today: " + d5);
            Console.WriteLine("UtcNow: " + d6);


            //Converter uma data de string para DateTime
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

            Console.WriteLine("Converter de string para DateTime: " + d7);
            Console.WriteLine("Converter de string para DateTime com hora: " + d8);

            //Aceita também converter uma data de string no formato BR
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine("Converter de string para DateTime(BR): " + d9);
            Console.WriteLine("Converter de string para DateTime(BR) com hora: " + d10);


            //1. ParseExact - quando você quer determinar o formato da data
            //2. após a data usar uma máscara de formatação no modelo como você deseja formatar ex: "yyyy-MM-dd"
            //3. após a máscara utilizar o Format Provider (CultureInfo.InvariantCulture)

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine("ParseExact: " + d11);

            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("ParseExact com hora: " + d12);

        }
    }
}
