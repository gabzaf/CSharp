double input = Convert.ToDouble(Console.ReadLine());

if (input < 0 || input > 100) Console.WriteLine("Fora de intervalo");
else
{
    if (input >= 0 && input <= 25) Console.WriteLine("Intervalo [0,25]");
    if (input > 25 && input <= 50) Console.WriteLine("Intervalo (25,50]");
    if (input > 50 && input <= 75) Console.WriteLine("Intervalo (50,75]");
    if (input > 75 && input <= 100) Console.WriteLine("Intervalo (75,100]");
}