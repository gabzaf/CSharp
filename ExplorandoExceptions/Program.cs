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
                int resultado = Teste(divisor);
                Console.WriteLine("O resultado é: " + resultado);
                int numero = divisor2.Divide();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                Console.WriteLine(e.StackTrace); ;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exceção de referência nula");
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
        private static int Teste(Divisor a)
        {
            try
            {
                return a.Divide();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com divisor = 0");
                throw;
            }
        }
    }
}