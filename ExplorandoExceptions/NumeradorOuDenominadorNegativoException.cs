using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoExceptions
{
    public class NumeradorOuDenominadorNegativoException : Exception
    {
        public double Numerador { get; }
        public double Denominador { get; }
        public NumeradorOuDenominadorNegativoException() { }
        public NumeradorOuDenominadorNegativoException(double numerador, double denominador) : this("Tentativa de operador negativo! Numerador " + numerador + " Denominador: " + denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }
        public NumeradorOuDenominadorNegativoException(string mensagem) : base(mensagem) { }

    }
}
