using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoExceptions
{
    public class Divisor
    {
        public int a { get; set; }
        public int b { get; set; }
        public int Divide()
        {
            int c = a / b;
            return c;
        }
    }
}
