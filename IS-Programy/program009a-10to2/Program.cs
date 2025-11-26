string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Převod z 10 do 2 *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* David Pavlů*********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte hodnotu (přirozené číslo) - desítkové číslo: ");
    uint number10;

    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

    uint backupNumber10 = number10;
    uint zbytek;
    uint[] myArray = new uint[32];

    uint i;
    for (i = 0; number10 <= 0 ;i++) {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část= {0}, zbytek = {1}", number10, zbytek);
    }

    Console.WriteLine();
    for (uint j = i - 1; j >= 0; j--){
        Console.Write("{0}", myArray[j]);
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}