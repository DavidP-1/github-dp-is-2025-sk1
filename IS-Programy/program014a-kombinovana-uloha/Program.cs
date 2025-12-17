string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*****************************");
    Console.WriteLine("***** Kombinovaná úloha *****");
    Console.WriteLine("*****************************");
    Console.WriteLine("******* David Pavlů *********");
    Console.WriteLine("*****************************");
    Console.WriteLine();

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }
    
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("=======================================");
    Console.WriteLine("Počet generovaných čísel: {0}, dolní mez: {1}, horní mez: {2}.", n, lowerBound, upperBound);
    Console.WriteLine("=======================================");


    //Deklarace pole
    int[] numbs = new int[n];

    //Random myRandNumb = new Random(50); generování stejných čísel při stejném vstupu (hodí se při testování)
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        numbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", numbs[i]);
    }

    //Max, Min a jejich pozice
    int poz1 = 0;
    int poz2 = 0;
    int max = numbs[0];
    int min = numbs[0];
    for (int i = 1; i < n; i++)
    {
        if (numbs[i] > max)
            max = numbs[i];

        if (numbs[i] < min)
            min = numbs[i];
    }
    
    for (int i = 0; i < n; i++)
    {
        if (numbs[i] == max)
            poz1 = i;
    }
        for (int i = 0; i < n; i++)
    {
        if (numbs[i] == min)
            poz2 = i;
    }
    Console.WriteLine();
    Console.WriteLine("Maximum je {0}; jeho pozice je: {1}.", max, poz1);
    Console.WriteLine("Minimum je {0}; jeho pozice je: {1}.", min, poz2);

    //Seřazení pole
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (numbs[j] < numbs[j + 1])
            {
                int temp = numbs[j + 1];
                numbs[j + 1] = numbs[j];
                numbs[j] = temp;
            }

        }
    }
    
    //Výpis seřazených čísel
    Console.WriteLine("======================================");
    Console.WriteLine("Seřazená čísla:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", numbs[i]);
    }

    //Hledání xtého největšího čísla
    int uniqueCount = 0;
    int lastValue = int.MinValue;
    int second = 0, third = 0, fourth = 0;
    for (int i = 0; i < n; i++)
    {
        if (numbs[i] != lastValue)
        {
            uniqueCount++;
            lastValue = numbs[i];

            if (uniqueCount == 2)
                second = numbs[i];
            if (uniqueCount == 3)
                third = numbs[i];
            if (uniqueCount == 4)
                fourth = numbs[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("Druhé největší číslo: " + second);
    Console.WriteLine("Třetí největší číslo: " + third);
    Console.WriteLine("Čtvrté největší číslo: " + fourth);

    //Medián
    int median;
    if (n % 2 == 1)
        median = numbs[n / 2];
    else
        median = (numbs[n / 2 - 1] + numbs[n / 2]) / 2;
    
    Console.WriteLine("==================================");
    Console.WriteLine($"Medián: {median}");
    
    //Převod do binární soustavy
    string bin = "";
    int x = fourth;
    if (x == 0) bin = "0";
    while (x > 0)
    {
        bin = (x % 2) + bin;
        x /= 2; // to samé jako x = x / 2;
    }
    
    Console.WriteLine("=================================="); 
    Console.WriteLine($"Čtvrté největší číslo v binární soustavě: {fourth}(2) = {bin}");
    
    //Vykreslení obrazce
    Console.WriteLine();
    Console.WriteLine("=================================="); 
    
    int height = median;
    int width = third;

    Console.WriteLine($"Obrazec jehož výška je {height} a šířka je {width}");
    Console.WriteLine();

    int part = height / 3;

    // rozhodnutí podle sudé / liché šířky
    int smallWidth;
    int indent;

    if (width % 2 == 0)
    {
        smallWidth = 2;
        indent = (width - 2) / 2;
    }
    else
    {
        smallWidth = 3;
        indent = (width - 3) / 2;
    }

    for (int i = 0; i < height; i++)
    {
        // horní část
        if (i < part)
        {
            for (int s = 0; s < indent; s++)
                Console.Write("  ");

            for (int j = 0; j < smallWidth; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
        // prostřední část
        else if (i < height - part)
        {
            for (int j = 0; j < width; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
        // dolní část
        else
        {
            for (int s = 0; s < indent; s++)
                Console.Write("  ");

            for (int j = 0; j < smallWidth; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }


    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}