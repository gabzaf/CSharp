string[] scores = Console.ReadLine().Split();

double n1 = double.Parse(scores[0]);
double n2 = double.Parse(scores[1]);
double n3 = double.Parse(scores[2]);
double n4 = double.Parse(scores[3]);

double media = ((n1*2)+ (n2*3) + (n3*4) + (n4)) / 10.0;
string aprovado = "Aluno aprovado.";

Console.WriteLine($"Media: {media.ToString("F1")}");

if (media >= 7) Console.WriteLine(aprovado);
else if (media >= 5)
{
    Console.WriteLine("Aluno em exame.");
    double notaDoExame = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {notaDoExame}");
    notaDoExame = (media + notaDoExame) / 2.0;
    if (notaDoExame >= 5)
    {
        Console.WriteLine(aprovado);
        Console.WriteLine($"Media Final: {notaDoExame.ToString("F1")}");
    }
    else
    {
        Console.WriteLine($"Aluno reprovado.");
        Console.WriteLine($"Media Final: {notaDoExame.ToString("F1")}");
    }
}
else Console.WriteLine("Aluno reprovado.");
Console.ReadLine();
