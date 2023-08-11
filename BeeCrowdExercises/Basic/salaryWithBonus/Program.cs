string name = Console.ReadLine();
double salary = Convert.ToDouble(Console.ReadLine());
double selledAmount = Convert.ToDouble(Console.ReadLine());

double total = salary + (selledAmount * 0.15);

Console.WriteLine("TOTAL = R$ " + total.ToString("0.00"));
Console.ReadLine();