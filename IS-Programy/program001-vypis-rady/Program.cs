string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**************************");
    Console.WriteLine("*****Výpis řady čísel*****");
    Console.WriteLine("**************************");
    Console.WriteLine("********David Pavlů*******");
    Console.WriteLine("**************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatné řešení
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu - sprvávné řešení
    Console.Write("Zadejte první (celé) číslo řady: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první celé číslo řady znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
