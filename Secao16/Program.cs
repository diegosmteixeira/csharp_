using System;

namespace Secao16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Método de extensão para o objeto DateTime
            //Você já coloca sua classe no mesmo namespace que o Tipo que será extendido (System)

            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());


            //Extension Cut para String

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
