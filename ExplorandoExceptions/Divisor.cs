using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoExceptions
{
    public class Divisor
    {
        public double A { get; }
        public double B { get; }
        public Divisor(double numerador, double denominador)
        {
            if (numerador > 10000)
            {
                ArgumentException exceção = new ArgumentException("O divisor não pode ter numerador maior que 10.000.", nameof(numerador));
                throw exceção;
            }
            if (denominador == 3.14)
            {
                ArgumentException exceção = new ArgumentException("O divisor não pode ter denominador igual a Pi.", nameof(denominador));
                throw exceção;
            }
            A = numerador;
            B = denominador;
        }
        public void Positivos(double numerador, double denominador)
        {
            if(numerador < 0 || denominador < 0)
            {
                throw new NumeradorOuDenominadorNegativoException("SOMENTE NÚMEROS POSITIVOS.");
            }
        }
        public double Divide()
        {
            double c = A / B;
            return c;
        }
        
    }
}
