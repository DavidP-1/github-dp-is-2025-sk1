string again = "a";
while (again == "a")
{
    Console.Clear();
    razitko();
    //Načítání hodnot
    ulong a = nactiCislo("Zadejte číslo a: ");
    ulong b = nactiCislo("Zadejte číslo b: ");

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



