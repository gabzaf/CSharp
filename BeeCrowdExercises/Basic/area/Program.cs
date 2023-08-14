string[] abc = Console.ReadLine().Split();

double a = double.Parse(abc[0]);
double b = double.Parse(abc[1]);
double c = double.Parse(abc[2]);

double areaOfTriangle = (a * c)/2;
double areaOfCircle = 3.14159 * c * c;
double areaOfTrapezium = ((a+b)/2.0)*c;
double areaOfSquare = (b*b);
double areaOfRectangle = a * b;

Console.WriteLine("TRIANGULO: " + areaOfTriangle.ToString("0.000"));
Console.WriteLine("CIRCULO: " + areaOfCircle.ToString("0.000"));
Console.WriteLine("TRAPEZIO: " + areaOfTrapezium.ToString("0.000"));
Console.WriteLine("QUADRADO: " + areaOfSquare.ToString("0.000"));
Console.WriteLine("RETANGULO: " + areaOfRectangle.ToString("0.000"));

Console.ReadLine();