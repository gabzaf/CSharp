string[] xy = Console.ReadLine().Split();

int x = int.Parse(xy[0]);
int y = int.Parse(xy[1]);

double[] precos = new double[5];
precos[0] = 4.00;
precos[1] = 4.50;
precos[2] = 5.00;
precos[3] = 2.00;
precos[4] = 1.50;

Console.WriteLine($"Total: R$ {(precos[x-1] * y).ToString("0.00")}");
Console.ReadLine();
