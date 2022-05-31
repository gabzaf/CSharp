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
            double d = 6;
            double e = 7;
            double menorRecursivo;
            double primeiroMaior;
            double segundoMaiorSobrecarga;
            double terceiroMaiorRecursivo;
            double quartoMaiorRecursivoSobrecarga;
            double quartoMaiorRecursivo;

            MaiorMenor maiorMenor = new MaiorMenor();

            menorRecursivo = maiorMenor.Menor(maiorMenor.Menor(maiorMenor.Menor(maiorMenor.Menor(e, d), c), b), a);
            primeiroMaior = maiorMenor.Maior(a, b);
            segundoMaiorSobrecarga = maiorMenor.Maior(a, b, c);
            terceiroMaiorRecursivo = maiorMenor.Maior(maiorMenor.Maior(maiorMenor.Maior(a, b), c), d);
            quartoMaiorRecursivoSobrecarga = maiorMenor.Maior(maiorMenor.Maior(a, b, c), d, e);
            quartoMaiorRecursivo = maiorMenor.Maior(maiorMenor.Maior(maiorMenor.Maior(maiorMenor.Maior(a, b), c), d), e);

            Console.WriteLine(menorRecursivo);
            Console.WriteLine(primeiroMaior);
            Console.WriteLine(segundoMaiorSobrecarga);
            Console.WriteLine(terceiroMaiorRecursivo);
            Console.WriteLine(quartoMaiorRecursivoSobrecarga);
            Console.WriteLine(quartoMaiorRecursivo);

        }
    }
}

