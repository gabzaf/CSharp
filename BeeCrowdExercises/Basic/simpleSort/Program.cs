string[] numbers = Console.ReadLine().Split();

int i1 = int.Parse(numbers[0]);
int i2 = int.Parse(numbers[1]);
int i3 = int.Parse(numbers[2]);

int[] numeros = new int[3];
numeros.SetValue(i1, 0);
numeros.SetValue(i2, 1);
numeros.SetValue(i3, 2);

int aux;

for(int i = 0; i < numeros.Length; i++)
{
    for (int j = 0; j < numeros.Length; j++)
    {
        if (numeros[i] < numeros[j])
        {
            aux = numeros[j];
            numeros[j] = numeros[i];
            numeros[i] = aux;
        }
    }
}
Console.WriteLine($"{numeros[0]}\n{numeros[1]}\n{numeros[2]}");
Console.WriteLine($"\n{numbers[0]}\n{numbers[1]}\n{numbers[2]}");
Console.ReadLine();