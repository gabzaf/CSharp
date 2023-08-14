int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{n / 3600}:{((n % 3600)/60)}:{(n % 60)}");

Console.ReadLine();