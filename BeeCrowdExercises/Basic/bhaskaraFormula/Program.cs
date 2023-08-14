string[] abc = Console.ReadLine().Split();

double a = double.Parse(abc[0]);
double b = double.Parse(abc[1]);
double c = double.Parse(abc[2]);

double delta = (b*b) - 4*a*c;
double den = 2 * a;

if (delta < 0 || den == 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    double pR1 = (-b + Math.Sqrt(delta)) / den;
    double pR2 = (-b - Math.Sqrt(delta)) / den;

    Console.WriteLine($"R1 = {pR1.ToString("0.00000")}");
    Console.WriteLine($"R2 = {pR2.ToString("0.00000")}");
}
Console.ReadLine();
