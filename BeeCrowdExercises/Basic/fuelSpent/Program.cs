double spentTime = Convert.ToDouble(Console.ReadLine());
double averageSpeed = Convert.ToDouble(Console.ReadLine());

int consumption = 12;
double liters = (spentTime*averageSpeed) / consumption;

Console.WriteLine(liters.ToString("0.000"));
Console.ReadLine(); 