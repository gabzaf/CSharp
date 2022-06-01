using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoExceptions
{
    public class Divisor
    {
        public int A { get; }
        public int B { get; }
        public Divisor(int a, int b)
        {
            A = a;
            B = b;
        }
        public int Divide()
        {
            int c = A / B;
            return c;
        }
        
    }
}
