string again = "a";
while (again == "a")
{
    Console.Clear();
    razitko();
    //Načítání hodnot
    ulong a = nactiCislo("Zadejte číslo a: ");
    ulong b = nactiCislo("Zadejte číslo b: ");

    ulong nsd = vypocitatNSD(a, b);
    ulong nsn = vypocitatNSN(a, b, nsd);

    zobrazitVysledky(a, b, nsd, nsn);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}

//metoda, která nic nevrací
static void razitko()
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("************ Výpočet NSD a NSN ************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** David Pavlů ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
}

//metoda pro načtení čísel
static ulong nactiCislo(string zprava)
{
    Console.WriteLine(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číslo znovu: ");
    }

    // metoda, ketrá vrací nějaký konkrétní datový typ, musí obsahovat tento řádek
    return cislo;

}

//metoda pro výpočet NSD dvou čísel
static ulong vypocitatNSD(ulong a, ulong b)
{
    while (a != b)
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}

//metoda pro výpočrt NSN dvou čísel na základě známé hodnoty NSD
static ulong vypocitatNSN(ulong a, ulong b, ulong nsd)
{
    return (a * b / nsd);
}

//metoda vypišující vysledky
static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine("NSD čísel {0} a {1} je {2}.", a, b, nsd);
    Console.WriteLine("====================================");
    Console.WriteLine("NSN čísel {0} a {1} je {2}.", a, b, nsn);
    Console.WriteLine("====================================");
}