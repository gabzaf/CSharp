

double radius = Convert.ToDouble(Console.ReadLine());
double volume = ((4/ 3.0) * 3.14159 * (Math.Pow(radius, 3)));
//Use (4/3.0) or (4.0/3) in your formula, because some languages (including C#) assume that the division's result between two integers is another integer. :)
Console.WriteLine("VOLUME = "+ volume.ToString("0.000"));
Console.ReadLine();