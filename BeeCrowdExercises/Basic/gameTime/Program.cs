string[] numbers = Console.ReadLine().Split();

int start = int.Parse(numbers[0]);
int end = int.Parse(numbers[1]);
int md = 24;
int aux, duration;

if(start > end)
{
    aux = md - start;
    duration = aux + end;
    Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
}
else if (start == end) Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
else
{
    duration = Math.Abs(start - end);
    Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
}
Console.ReadLine();


