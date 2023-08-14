
class URI
{
    static void Main(string[] args)
    {
        string animalClasse = Console.ReadLine();
        isLower(animalClasse);

        string animalTipo = Console.ReadLine();
        isLower(animalTipo);

        string animalAlimenta = Console.ReadLine();
        isLower(animalAlimenta);

        string output = "";

        if (animalClasse.Equals("vertebrado"))
        {
            if (animalTipo.Equals("ave"))
            {
                if (animalAlimenta.Equals("carnivoro")) output = "aguia";
                else if (animalAlimenta.Equals("onivoro")) output = "pomba";
            }
            else if (animalTipo.Equals("mamifero"))
            {
                if (animalAlimenta.Equals("onivoro")) output = "homem";
                else if (animalAlimenta.Equals("herbivoro")) output = "vaca";
            }
        }
        else if (animalClasse.Equals("invertebrado"))
        {
            if (animalTipo.Equals("inseto"))
            {
                if (animalAlimenta.Equals("hematofago")) output = "pulga";
                else if (animalAlimenta.Equals("herbivoro")) output = "lagarta";
            }
            else if (animalTipo.Equals("anelideo"))
            {
                if (animalAlimenta.Equals("hematofago")) output = "sanguessuga";
                else if (animalAlimenta.Equals("onivoro")) output = "minhoca";
            }
        }
        Console.WriteLine(output);
        Console.ReadLine();
    }
    static void isLower(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (char.IsUpper(c)) return;
        }
    }
}