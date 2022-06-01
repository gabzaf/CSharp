using System;

namespace ExplorandoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisor divisor = new Divisor(10, 2);
            TestaDivisao(divisor);
            Divisor divisor2 = null;
            Teste(divisor2);
        }
        public static void TestaDivisao(Divisor a)
        {
            try
            {
                int resultado = a.Divide();
                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
        }
        public static void Teste(Divisor b)
        {
            try
            {
                b.Divide();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Não pode passar referência nula!");
            }

        }

    }
}