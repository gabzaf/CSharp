int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n / 365} ano(s)\n{(n % 365) / 30} mes(es)\n{(n % 365) % 30} dia(s)");
Console.ReadLine();