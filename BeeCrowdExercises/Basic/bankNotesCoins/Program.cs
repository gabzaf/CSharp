double input = Convert.ToDouble(Console.ReadLine());
int notas = (int)input;
int aux;

Console.WriteLine("NOTAS:");
Console.WriteLine($"{ notas / 100 } nota(s) de R$ 100.00");

aux = notas % 100;
Console.WriteLine($"{ aux / 50 } nota(s) de R$ 50.00");

aux %= 50;
Console.WriteLine($"{ aux / 20 } nota(s) de R$ 20.00");

aux %= 20;
Console.WriteLine($"{ aux / 10 } nota(s) de R$ 10.00");

aux %= 10;
Console.WriteLine($"{ aux / 5 } nota(s) de R$ 5.00");

aux %= 5;
Console.WriteLine($"{ aux / 2 } nota(s) de R$ 2.00");

Console.WriteLine("MOEDAS:");

aux %= 2;
Console.WriteLine($"{ aux / 1 } moeda(s) de R$ 1.00");

input = Math.Round(input * 100);
input = input % 100;
aux = (int)input;

aux %= 100;
Console.WriteLine($"{ aux / 50 } moeda(s) de R$ 0.50");

aux %= 50;
Console.WriteLine($"{ aux / 25 } moeda(s) de R$ 0.25");

aux %= 25;
Console.WriteLine($"{ aux / 10 } moeda(s) de R$ 0.10");

aux %= 10;
Console.WriteLine($"{ aux / 5 } moeda(s) de R$ 0.05");

aux %= 5;
Console.WriteLine($"{ aux } moeda(s) de R$ 0.01");
Console.ReadLine();

