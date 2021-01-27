using System;
using System.IO;
using System.Collections.Generic;

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

            /*
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
            */


            /*
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            //Ler o file1 e salvar todo o conteúdo no fil2
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
            */

            /*
            string path = @"c:\temp\myfolder";

            try
            {
                //listar todas as subpastas a partir da pasta indicada
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //*.* = máscara de busca (qualquer nome de arquivo, qualquer extensão)
                //AllDirectories = pastas e subpastas

                //O resultado disso será uma coleção contendo os strings correspondentes as pastas
                //Essa coleção será do tipo mais genérico IEnumerable

                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder"); //para não colocar duas barras deve-se usar = @"\\newfolder"
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
            */

            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Path.PathSeparator " + Path.PathSeparator);              //entre path diferentes o ; é utilizado para separar os path
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetDirectoryName: " + Path.GetFileName(path));
            Console.WriteLine("Path.GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("Path.GetFUllPath: " + Path.GetFullPath(path));
            Console.WriteLine("Path.GetTempPath: " + Path.GetTempPath());     //informa a pasta temporária do sistema na qual é possível manipular dados temporários de aplicações.

        }
    }
}