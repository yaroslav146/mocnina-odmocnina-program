Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---- Mocnina -----");
Console.ForegroundColor = ConsoleColor.White;
bool zkouska1;

do
{
    Console.Write("Zadejte číslo, ze kterého se spočítá třetí mocnina: ");
    if (float.TryParse(Console.ReadLine(), out float mocnina) == false)
    {
        zkouska1 = false;
        Console.WriteLine("Špatně zadáne číslo. Zkus ještě jednou.");
    }
    else
    {
        zkouska1 = true;
        Console.WriteLine("Toto číslo se nyní třikrát umocní.");
        float reseni1 = mocnina*mocnina*mocnina;
        Console.Write($"Třetí mocnina z čísla ");
        Console.ForegroundColor = ConsoleColor.Red;
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
Console.WriteLine("---- Odmocnina -----");
Console.ForegroundColor = ConsoleColor.White;
bool zkouska2;
do
{
    Console.Write("Zadejte číslo, ze kterého se spočítá odmocnina: ");
    if (float.TryParse(Console.ReadLine(), out float odmocnina) == false || odmocnina < 0)
    {
        zkouska2 = false;
        Console.WriteLine("Špatně zadáne číslo. Zkus ještě jednou.");
    }
    else
    {
        zkouska2 = true;
        Console.WriteLine("Toto číslo je větší, než nula a bude odmocněno.");
        double reseni2 = Math.Sqrt(odmocnina);
        Console.Write($"Odmocnina z čísla ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(odmocnina);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" je ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(reseni2);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
} while (zkouska2 == false);