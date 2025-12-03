string again = "a";
while (again == "a")
{
    Console.Clear();
    razitko();

    Console.Write("Zadejte první číslo (celé číslo): ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    Console.Write("Zadejte druhé číslo (celé číslo): ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }



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