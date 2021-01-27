using System;
using System.IO;

namespace Secao13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //A notação do @ serve para não ter que usar \\ para representar 
            //o caminho do arquivo
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            /*
            string path = @"c:\temp\file1.txt";

            FileStream fs = null; //stream genérica para gerenciar entrada e saída
            StreamReader sr = null; //stream particular para você realizar o que quer

            try
            {
                //São métodos externos conversando com o sistema operacional
                //Esse recurso não é gerenciado pelo CLR do .NET

                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs); //instanciou um objeto StreamReader com o parâmetro fs
                string line = sr.ReadLine(); //armazena na variável "line" a leitura do objeto StreamReader

                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Como esse recurso não é gerenciado pelo CLR do .NET
                //é necessário fechar essa Stream independente se deu certo ou não.
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            */

            /*
            //Outra maneira é utilizando o File.OpenText
            string path = @"c:\temp\file1.txt";

            StreamReader sr = null; //stream particular para você realizar o que quer

            try
            {
                //São métodos externos conversando com o sistema operacional
                //Esse recurso não é gerenciado pelo CLR do .NET

                sr = File.OpenText(path); //utilizou a classe file para instanciar objetos de stream 
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine(); //enquanto não chegar no EndOfStream lê a linha e mostra na tela
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Como esse recurso não é gerenciado pelo CLR do .NET
                //é necessário fechar essa Stream independente se deu certo ou não.
                if (sr != null) sr.Close();
            }
            */

            /*
            string path = @"c:\temp\file1.txt";

            try
            {
                //Tudo que for colocado no bloco será executado
                //ao final da execução será automaticamente fechado
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))   //um UsingBlock pode conter outro
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
        */
            string path = @"c:\temp\file1.txt";

            try
            {
                //Exemplo de instânciação do StreamReader de forma reduzida
                //fazendo apenas uma instânciação com a classe file
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
