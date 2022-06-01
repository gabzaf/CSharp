using System;

namespace ExplorandoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisor divisor = new Divisor(10, 2);
            Divisor divisor2 = null;
            try
            {
                int resultado = divisor.Divide();
                Console.WriteLine("O resultado da divisão é: " + resultado);
                divisor2.Divide();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                Console.WriteLine(e.StackTrace);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Não pode passar referência nula!");
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}