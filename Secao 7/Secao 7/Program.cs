using System;

namespace Secao_7
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
