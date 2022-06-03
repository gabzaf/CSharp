using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoExceptions
{
    public class NumeradorOuDenominadorNegativoException : Exception
    {
        public NumeradorOuDenominadorNegativoException() { }
        public NumeradorOuDenominadorNegativoException(string mensagem): base(mensagem) { }
    }
}
