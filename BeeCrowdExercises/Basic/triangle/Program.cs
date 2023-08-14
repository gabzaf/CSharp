string[] values = Console.ReadLine().Split();

float a = float.Parse(values[0]);
float b = float.Parse(values[1]);
float c = float.Parse(values[2]);
float perimetro;
float area;

if (a + b > c && a + c > b && b + c > a)
{
    perimetro = a + b + c;
    Console.WriteLine($"Perimetro = {perimetro.ToString("F1")}");
}
else
{
    area = ((a + b) / 2) * c;
    Console.WriteLine($"Area = {area.ToString("F1")}");
}
Console.ReadLine();

