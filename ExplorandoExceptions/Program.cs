using System;

namespace ExplorandoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisor divisor = new Divisor(10, 0);
            Divisor divisor2 = null;

            try
            {
                int resultado = divisor.Divide();
                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                Console.WriteLine(e.StackTrace);
            }

            Teste(divisor2);
            Console.ReadLine();
        }
        public static void Teste(Divisor b)
        {
            try
            {
                b.Divide();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Não pode passar referência nula!");
                Console.WriteLine(e.StackTrace);
            }

        }

    }
}