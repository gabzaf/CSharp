int number = Convert.ToInt32(Console.ReadLine());
int workedHours = Convert.ToInt32(Console.ReadLine());
float receivedPerHour = Convert.ToSingle(Console.ReadLine());

float salary = workedHours * receivedPerHour;

Console.WriteLine($"NUMBER = {number}\nSALARY = U$ {salary.ToString("0.00")}");
Console.ReadLine();