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

    //Vstup hodnoty do programu
    Console.Write("Zadejte celé číslo pro nějž chcete určit součet a součin cifer: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo ZNOVU: ");
    }

    //Součet cifer
    int suma = 0;
    int numberBackup = number;
    int digit;
    if (number < 0) {
        number = -number;
    }

    while (number >= 10) {
        digit = number % 10; //zbytek po dělení desítkou nám bude určovat jednetolivé cifry zprava
        number = number - digit / 10;
        Console.WriteLine("Zbytek: {}", digit);
        suma = suma + digit;
    }
    //nesmíme zapomenout vypsat poslední číslici
    Console.WriteLine("Zbytek: {}", number);
    
    //nesmíme zapomenout přičíst poslední číslici do sumy
    suma = suma + number;
    Console.WriteLine("Součet čísel čísla {0} je {1}.", numberBackup, suma);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
