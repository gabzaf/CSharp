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
        public Divisor(double a, double b)
        {
            if(b == 3.14)
            {
                ArgumentException exceção = new ArgumentException("A calculadora não faz divisão por Pi.");
                throw exceção;
            }
            A = a;
            B = b;
        }
        public double Divide()
        {
            double c = A / B;
            return c;
        }
        
    }
}
