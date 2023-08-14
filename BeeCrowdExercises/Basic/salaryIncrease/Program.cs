string input = Console.ReadLine();
double salary = double.Parse(input);

double bonus = 0;
double a = 0;

if (salary > 0 && salary <= 400.00)
{
    bonus = salary * 0.15;
    salary += bonus;
    a = 15;
}
else if (salary >= 400.01 && salary <= 800.00)
{
    bonus = salary * 0.12;
    salary += bonus;
    a = 12;
}
else if (salary >= 800.01 && salary <= 1200.00)
{
    bonus = salary * 0.1;
    salary += bonus;
    a = 10;
}
else if (salary >= 1200.01 && salary <= 2000.00)
{
    bonus = salary * 0.07;
    salary += bonus;
    a = 7;
}
else if(salary > 2000.00)
{
    bonus = salary * 0.04;
    salary += bonus;
    a = 4;
}

Console.WriteLine($"Novo salario: {salary.ToString("0.00")}");
Console.WriteLine($"Reajuste ganho: {bonus.ToString("0.00")}");
Console.WriteLine($"Em percentual: {a} %");
Console.ReadLine();