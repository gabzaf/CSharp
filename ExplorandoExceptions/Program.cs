using System;

namespace ExplorandoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisor divisor2 = null;
            double numerador = 10000;
            double denominador = -1;

            try
            {
                Divisor divisor = new Divisor(numerador, denominador);
                divisor.Positivos(numerador, denominador);
                double resultado = Teste(divisor);
                Console.WriteLine("O resultado é: " + resultado);
                double numero = divisor2.Divide();
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
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento que causou erro: " + ex.ParamName);
                Console.WriteLine("Ocorreu Exceção do tipo Argument Exception");
                Console.WriteLine(ex.Message);
            }
            catch (NumeradorOuDenominadorNegativoException e)
            {
                //Console.WriteLine("Argumento que causou erro: " + e.ParamName);
                Console.WriteLine("Ocorreu Exceção do tipo Numero Negativo");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        private static double Teste(Divisor a)
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