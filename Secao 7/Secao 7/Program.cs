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

            /*
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
            */

            /*
            //TimeSpan é utilizado para calcular Multas, Juros, etc

            //TimeSpan
            TimeSpan t = new TimeSpan(0, 1, 30);

            Console.WriteLine("TimeSpan: " + t);
            Console.WriteLine("t1.Ticks: " + t.Ticks);

            //Construtores do TimeSpan
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(4, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(4, 2, 11, 21, 321);

            //Construtor vazio
            Console.WriteLine("Construtor vazio: " + t1);

            //Passando um número de ticks no construtor
            Console.WriteLine("Passando ticks no construtor: " + t2);

            //Passando horas no TimeSpan
            Console.WriteLine("Passando horas: " + t3);

            //Passando dias no TimeSpan
            Console.WriteLine("Passando também dias: " + t4);

            //Passando milissegundos no TimeSpan
            Console.WriteLine("Passando também milissegundos: " + t5);


            //Instanciar TimeSpan com Métodos.From
            TimeSpan f1 = TimeSpan.FromDays(1.5);
            TimeSpan f2 = TimeSpan.FromHours(1.5);
            TimeSpan f3 = TimeSpan.FromMinutes(1.5);
            TimeSpan f4 = TimeSpan.FromSeconds(1.5);
            TimeSpan f5 = TimeSpan.FromMilliseconds(1);
            TimeSpan f6 = TimeSpan.FromTicks(900000000L);



            //TimeSpan de dias
            Console.WriteLine("TimeSpan.FromDays: " + f1);

            //TimeSpan de horas
            Console.WriteLine("TimeSpan.FromHours: " + f2);

            //TimeSpan de minutos
            Console.WriteLine("TimeSpan.FromMinutes: " + f3);

            //TimeSpan de segundos
            Console.WriteLine("TimeSpan.FromSeconds: " + f4);

            //TimeSpan de milissegundos
            Console.WriteLine("TimeSpan.FromMilliseconds: " + f5);

            //TimeSpan de Ticks (menor unidade - aceita apenas números Long)
            Console.WriteLine("TimeSpan.FromTicks: " + f6 + " como o Tick é a menor unidade, não pode ser quebrado - logo esse método aceita números Long");
            Console.WriteLine();
            */

            /*
            //Propriedades e operações com DateTime

            //Propriedades
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Propriedades de um DateTime:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("   DateTime d = " + d);
            Console.WriteLine();
            Console.WriteLine("1) Date:        " + d.Date); //Imprimimindo data e desconsiderando horário
            Console.WriteLine("2) Day:         " + d.Day); //Imprime o dia
            Console.WriteLine("3) DayOfWeek:   " + d.DayOfWeek); //Imprime dia da semana
            Console.WriteLine("4) DayOfYear:   " + d.DayOfYear); //Imprime dia do ano
            Console.WriteLine("5) Hour:        " + d.Hour);
            Console.WriteLine("6) Kind:        " + d.Kind); //por padrão identifica local
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute:      " + d.Minute);
            Console.WriteLine("9) Month:       " + d.Month);
            Console.WriteLine("10) Second      " + d.Second);
            Console.WriteLine("11) Ticks:      " + d.Ticks);
            Console.WriteLine("12) TimeOfDay:  " + d.TimeOfDay); //é um TimeSpan
            Console.WriteLine("13) Year:       " + d.Year);
            Console.WriteLine();

            //Formatações para DateTime
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 598);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Formatações para DateTime  :");
            Console.WriteLine("----------------------------");
            Console.WriteLine("   ToString():            " + d1.ToString()); //formato local da data e depois o horário (Padrão)
            Console.WriteLine();
            Console.WriteLine("1) ToLongDateString():    " + d1.ToLongDateString()); //converte o DateTime para string
            Console.WriteLine("2) TooShortDateString():  " + d1.ToShortDateString()); //formato resumido
            Console.WriteLine("3) ToLongTimeString():    " + d1.ToLongTimeString());
            Console.WriteLine("4) ToShortTimeString():   " + d1.ToShortTimeString()); //imprime apenas hora e minuto
            Console.WriteLine("5) Formatando ToString(): " + d1.ToString("yyyy-MM-dd HH:mm:ss") + " (manualmente)"); //Formatando um DateTime para string
            Console.WriteLine("6) Formatando ToString(): " + d1.ToString("yyyy-MM-dd HH:mm:ss.fff") + " (com milissegundos)"); //Acrescentando milisegundos
            Console.WriteLine();



            //Operações com DateTime
            DateTime d2 = new DateTime(2001, 10, 18, 13, 45, 58, 598);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Operações com um DateTime  :");
            Console.WriteLine("----------------------------");
            Console.WriteLine("   DateTime d1 =  " + d1);
            Console.WriteLine();
            Console.WriteLine("1) AddHours(2):   " + d1.AddHours(2));
            Console.WriteLine("2) AddMinutes(3): " + d1.AddMinutes(3));
            Console.WriteLine("3) AddDays(7):    " + d1.AddDays(7));
            Console.WriteLine();
            Console.WriteLine("   DateTime d2 =  " + d2);
            Console.WriteLine();
            Console.WriteLine("4) d2.Subtract(d1): " + d2.Subtract(d1));
            Console.WriteLine();

            //Fórmula de outra operações usando TimeSpan
            //DateTime y = x.Subtract(TimeSpan);
            //TimeSpan t = x.Subtract(DateTime);
            */

            
            //Propriedades e operações com TimeSpan

            //Propriedades
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine("----------------------------");
            Console.WriteLine("Propriedades de um TimeSpan:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("MaxValue(): " + t1);
            Console.WriteLine("MinValue(): " + t2);
            Console.WriteLine("Zero():     " + t3);
            Console.WriteLine();

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine("----------------------------");
            Console.WriteLine("  Métodos com TimeSpan     :");
            Console.WriteLine("----------------------------");
            Console.WriteLine("TimeSpan t =  " + t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("----------------------------");
            Console.WriteLine("  Operações com TimeSpan   :");
            Console.WriteLine("----------------------------");

            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);

            Console.WriteLine("Soma: " + sum);
            Console.WriteLine("Subtração: " + dif);
            Console.WriteLine("Multiplicação: " + mult);
            Console.WriteLine("Divisão: " + div);
            Console.WriteLine();
        }
    }
}
