using System;
using Secao11.Entities;
using Secao11.Entities.Exceptions;

namespace Secao11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)   //upcasting
            {
                Console.WriteLine("Division by zero is not allowed ");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            finally //idependente de ter dado certo ou não
            {
                Console.WriteLine("Program is shutting down..");
            }
            */

            //Quando o programa pega uma exceção que não é tratada ocorre o stacktrace
            //o programa vai quebrar e o stacktrace vai mostrar: 
            //1. O tipo da exceção
            //2. A mensagem padrão dela
            //3. Aonde essa exceção ocorreu

            //O bloco finally é um bloco que contém código a ser executado independentemente de
            //ter ocorrido ou não uma exceção

            //[Exemplo clássico]: fechar um arquivo ou conexão de banco de dados ao final do processamento.

            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date(dd / MM / yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)  //tipo mais genérico de exceção
            {
                Console.WriteLine("Unexpected error: " + e.Message); //mensagem de erro inesperado
            }
           
        }
    }
}
