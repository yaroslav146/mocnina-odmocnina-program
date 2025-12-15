Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\t ---- Mocnina -----");
Console.ForegroundColor = ConsoleColor.White;
bool zkouska1;
float mocnina = 0;
float odmocnina = 0;
float reseni1 = 0;
double reseni2 = 0;

do
{
    Console.Write("Zadejte číslo, ze kterého se spočítá třetí mocnina: ");
    Console.ForegroundColor = ConsoleColor.Green;
    if (float.TryParse(Console.ReadLine(), out mocnina) == false)
    {
        zkouska1 = false;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Špatně zadáne číslo. Zkus ještě jednou.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        zkouska1 = true;
        Console.WriteLine("Toto číslo se nyní třikrát umocní.");
        reseni1 = mocnina * mocnina * mocnina;
        Console.Write($"Třetí mocnina z čísla ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(mocnina);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" je ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(reseni1);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
} while (zkouska1 == false);


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\t ---- Odmocnina -----");
Console.ForegroundColor = ConsoleColor.White;
bool zkouska2;
do
{
    Console.Write("Zadejte číslo, ze kterého se spočítá odmocnina: ");
    Console.ForegroundColor = ConsoleColor.Green;
    if (float.TryParse(Console.ReadLine(), out odmocnina) == false || odmocnina < 0)
    {
        zkouska2 = false;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Špatně zadáne číslo. Zkus ještě jednou.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        zkouska2 = true;
        Console.WriteLine("Toto číslo je větší, než nula a bude odmocněno.");
        reseni2 = Math.Sqrt(odmocnina);
        Console.Write($"Odmocnina z čísla ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(odmocnina);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" je ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(reseni2);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
} while (zkouska2 == false);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\t-----Přehledná tabulka-----");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\t\t| číslo \t| výsledek ");
Console.WriteLine($"Mocnina \t| {mocnina} \t\t| {reseni1}");
Console.WriteLine($"Odmocnina \t| {odmocnina} \t\t| {reseni2}");
Console.WriteLine();
