using System;

namespace Sobrecargas
{
    class Programa
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double primeiroMaior = 0;
            double segundoMaior = 0;
            double menor = 0;

            MaiorMenor maiorMenor = new MaiorMenor();

            primeiroMaior = maiorMenor.Maior(a, b);
            segundoMaior = maiorMenor.Maior(a, b, c);


            Console.WriteLine(primeiroMaior);
            Console.WriteLine(segundoMaior);

        }
    }
}

