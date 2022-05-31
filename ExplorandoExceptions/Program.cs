using System;

namespace ExplorandoExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Divisor divisor = new Divisor();
            divisor.a = 10;
            divisor.b = 0;
            try
            {
                double divisor2 = divisor.Divide();
            }
            catch (DivideByZeroException) {

                Console.WriteLine("Tentou dividir por zero! ");
            }
        }
    }
}