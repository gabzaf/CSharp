﻿int aux;
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n);

Console.WriteLine($"{n/100} nota(s) de R$ 100,00");
aux = n % 100;
Console.WriteLine($"{aux / 50} nota(s) de R$ 50,00");
aux = aux % 50;
Console.WriteLine($"{aux / 20} nota(s) de R$ 20,00");
aux = aux % 20;
Console.WriteLine($"{aux / 10} nota(s) de R$ 10,00");
aux = aux % 10;
Console.WriteLine($"{aux / 5} nota(s) de R$ 5,00");
aux = aux % 5;
Console.WriteLine($"{aux / 2} nota(s) de R$ 2,00");
aux = aux % 2;
Console.WriteLine($"{aux / 1} nota(s) de R$ 1,00");

Console.ReadLine();