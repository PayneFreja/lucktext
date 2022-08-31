string name = "";
string favoriteFood = "";
string friendName = "";

Console.WriteLine("Vad heter du?:");
name = Console.ReadLine();

Console.WriteLine($"Hej {name}! Vad för mat gillar du att laga?:");
favoriteFood = Console.ReadLine();

Console.WriteLine($"Vem brukar du laga {favoriteFood} till?:");
friendName = Console.ReadLine();

Console.WriteLine($"{name}, Jag har nått att säga till dig...");
Console.WriteLine($"{friendName} Berätta för mig att du lagar hemsk {favoriteFood} och när {friendName} äter det så vill han/hon spy.");

Console.WriteLine("goodbye");

Console.WriteLine("Tryck på ENTER för att avsluta.");
Console.ReadLine();