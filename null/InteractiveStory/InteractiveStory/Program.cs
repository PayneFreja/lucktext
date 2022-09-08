

Console.WriteLine("Du ska välja kläder.");
Console.WriteLine("Väljer du ett svart linne eller en svart t-shirt?");
Console.WriteLine("(Svara utan beskrivning av plagget och i små bokstäver)");
string val = Console.ReadLine();
if (val == "linne")
{
    Console.WriteLine("Bra val!");
    Console.WriteLine("Vill du styla ditt linne med ett par jeans eller ett par baggy trackpants?");
    val = Console.ReadLine();

    if (val == "jeans")
    {
        Console.WriteLine("Lite tråkigt, men det funkar.");
        Console.WriteLine("Kanske vi kan style det med en söt väska eller ett coolt bälte?");
        Console.WriteLine("väskan eller bältet?");
        val = Console.ReadLine();


        if (val == "väskan")
        {
            Console.WriteLine("Skit bra!");
            Console.WriteLine("Du har valt ett snyggt linne tillsammans med ett par jeans och stylat det med en cool väska.");
            Console.WriteLine("Tryck enter för att avsluta.");
        }
        else if (val == "bältet")
        {
            Console.WriteLine("Du har valt ett snyggt linne tillsammans med ett par jeans och stylat det med ett häftigt bälte.");
            Console.WriteLine("Tryck enter för att avsluta.");

        }
    }
    else if (val == "trackpants")
    {
        Console.WriteLine("YES! Detta kommer att bli skit snyggt.");
        Console.WriteLine("Kan tänka mig att antingen en liten handväska eller ett par hörlurar kan bli fint med detta.");
        Console.WriteLine("väskan eller hörlurar?");
        val = Console.ReadLine();

        if (val == "väskan")
        {
            Console.WriteLine("Skit bra!");
            Console.WriteLine("Du har valt ett snyggt linne tillsammans med ett par trackpants och stylat det med en cool väska.");
            Console.WriteLine("Tryck enter för att avsluta.");
        }
        else if (val == "hörlurar")
        {
            Console.WriteLine("Du har valt ett snyggt linne tillsammans med ett par trackpants och stylat det med några balla hörlurar.");
            Console.WriteLine("Tryck enter för att avsluta.");

        }
    }
}

else if (val == "t-shirt") ;
{
    Console.WriteLine("Bra val!");
    Console.WriteLine("Vill du styla din t-shirt med en mini-skirt eller ett par jeans?");
    val = Console.ReadLine();

    if (val == "jeans")
    {
        Console.WriteLine("Lite tråkigt, men det funkar.");
        Console.WriteLine("Kanske vi kan style det med en söt väska eller ett coolt bälte?");
        Console.WriteLine("väskan eller bältet?");
        val = Console.ReadLine();


        if (val == "väskan")
        {
            Console.WriteLine("Skit bra!");
            Console.WriteLine("Du har valt en t-shirt tillsammans med ett par jeans och stylat det med en cool väska.");
            Console.WriteLine("Tryck enter för att avsluta.");
        }
        else if (val == "bältet")
        {
            Console.WriteLine("Du har valt en t-shirt tillsammans med ett par jeans och stylat det med ett häftigt bälte.");
            Console.WriteLine("Tryck enter för att avsluta.");

        }
    }
    else if (val == "mini-skirt")
    {
        Console.WriteLine("YES! Detta kommer att bli skit snyggt.");
        Console.WriteLine("Kan tänka mig att antingen en liten handväska eller ett par hörlurar kan bli fint med detta.");
        Console.WriteLine("väskan eller hörlurar?");
        val = Console.ReadLine();

        if (val == "väskan")
        {
            Console.WriteLine("Skit bra!");
            Console.WriteLine("Du har valt en t-shirt tillsammans med en mini-skirt och stylat det med en cool väska.");
            Console.WriteLine("Tryck enter för att avsluta.");
        }
        else if (val == "hörlurar")
        {
            Console.WriteLine("Du har valt en t-shirt tillsammans med en mini-skirt och stylat det med några balla hörlurar.");
            Console.WriteLine("Tryck enter för att avsluta.");

        }
    }

}

Console.ReadLine();