string[] abc = Console.ReadLine().Split();
double a = double.Parse(abc[0]);
double b = double.Parse(abc[1]);
double c = double.Parse(abc[2]);
double maiorAB = ((a+b)+(Math.Abs(a-b)))/2;
double maiorABmaiorC = ((maiorAB + c) + (Math.Abs(maiorAB - c))) / 2;
Console.WriteLine(maiorABmaiorC + " eh o maior");
Console.ReadLine();