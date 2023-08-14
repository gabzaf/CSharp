string[] values = Console.ReadLine().Split();

int a = int.Parse(values[0]);
int b = int.Parse(values[1]);

if(a > b)
{
    if (a % b != 0) Console.WriteLine("Nao sao Multiplos");
    else Console.WriteLine("Sao Multiplos");
}
else
{
    if (b % a != 0) Console.WriteLine("Nao sao Multiplos");
    else Console.WriteLine("Sao Multiplos");
}
Console.ReadLine();