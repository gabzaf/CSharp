using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    public class MaiorMenor
    {
        public double Maior(double a, double b)
        {
            if(a > b) return a;
            return b;
        }
        public double Maior(double a, double b, double c)
        {
            if (a > b)
            {
                if (a > c)
                    return a;
                return c;
            }

            if (c > b)
                return c;
            return b;
        }
        public double Menor(double a, double b)
        {
            if (a < b) return a;
            return b;
        }
    }
}
