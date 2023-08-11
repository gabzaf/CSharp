string[] firstLine = Console.ReadLine().Split();
string[] secondLine = Console.ReadLine().Split();

float productCode1 = float.Parse(firstLine[0]);
float numberOfUnits1 = float.Parse(firstLine[1]);
float priceCode1 = float.Parse(firstLine[2]);

float productCode2 = float.Parse(secondLine[0]);
float numberOfUnits2 = float.Parse(secondLine[1]);
float priceCode2 = float.Parse(secondLine[2]);

Console.WriteLine("VALOR A PAGAR: R$ " + ((numberOfUnits1*priceCode1)+(numberOfUnits2 * priceCode2)).ToString("0.00"));

Console.ReadLine();