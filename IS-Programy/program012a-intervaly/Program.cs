string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("******** Výpočet čísel v intervalu ********");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************** David Pavlů ****************");
    Console.WriteLine("*******************************************");
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
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); generování stejných čísel při stejném vstupu (hodí se při testování)
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    int interval1 = 0;
    int interval2 = 0;
    int interval3 = 0;
    int interval4 = 0;
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
        if (myRandNumbs[i] <= upperBound * 0.25)
        {
            interval1++;
        }
        else if (myRandNumbs[i] <= upperBound * 0.5)
        {
            interval2++;
        }
        else if (myRandNumbs[i] <= upperBound * 0.75)
        {
            interval3++;
        }
        else
            interval4++;
    }

    Console.WriteLine("Počet čísel v intervalu <{0}, {1}>: {2}.",lowerBound, upperBound * 0.25, interval1);
    Console.WriteLine("Počet čísel v intervalu <{0}, {1}>: {2}.",upperBound + 1 * 0.25, upperBound * 0.5, interval2);
    Console.WriteLine("Počet čísel v intervalu <{0}, {1}>: {2}.",upperBound + 1 * 0.5, upperBound * 0.55, interval3);
    Console.WriteLine("Počet čísel v intervalu <{0}, {1}>: {2}.",upperBound + 1 * 0.75, upperBound, interval4);
                



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}