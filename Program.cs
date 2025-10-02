/*
Fruit Loops
Created by finn gilbert on 10-2-2025
*/
//Creating a list called fruits that holds 5 different fruits
using System.ComponentModel;
bool AddFruits = true;
bool RemoveFruits = false;
List<string> Fruits = new List<string> { "apple", "banana", "grape", "orange", "blackberry" };
//Print all fruits in the list Fruits with a for each loop
foreach (string fruit in Fruits)
{
    Console.WriteLine(fruit);
}
//Shows how many fruits are in the list 
Console.WriteLine($"There are {Fruits.Count} fruits in the list.");

//Asks the user choose 2 new fruits to add into the list
Console.WriteLine("Do you want add more fruits? True or False");
Console.Write(">> ");
AddFruits = bool.Parse(Console.ReadLine().ToLower());
while (AddFruits == true)
{
    Console.WriteLine("What is a fruit you want to add to the list?");
    Console.Write(">> ");
    string NewFruit = Console.ReadLine();
    //Use Contains method to check for duplicates before adding
    if (Fruits.Contains(NewFruit))
    {
        Console.WriteLine($"{NewFruit} is already in the list. Not adding duplicate.");
    }
    else
    {
        Fruits.Add(NewFruit);
    }
    foreach (string fruit in Fruits)
    {
        Console.WriteLine(fruit);
    }
    Console.WriteLine("Do you want add more fruits? True or False");
    Console.Write(">> ");
    AddFruits = bool.Parse(Console.ReadLine().ToLower());
} 
//Asks the user if they want to remove some fruits from the list
Console.WriteLine("Do you want remove some fruits from the list? True or False");
Console.Write(">> ");
RemoveFruits = bool.Parse(Console.ReadLine().ToLower());
while (RemoveFruits == true)
{
    Console.WriteLine("What is a fruit you want to remove from the list?");
    Console.Write(">> ");
    string RemoveFruit = Console.ReadLine().ToLower();
    Fruits.Remove(RemoveFruit);
    foreach (string fruit in Fruits)
    {
        Console.WriteLine(fruit);
    }
    Console.WriteLine("Do you want to remove more fruits? True or False");
    Console.Write(">> ");
    RemoveFruits = bool.Parse(Console.ReadLine().ToLower());
} 

//Sort the list alphabetically and display it
Fruits.Sort();
Console.WriteLine("Fruits sorted alphabetically:");
foreach (string fruit in Fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine();

//Reverse the list and display it
Fruits.Reverse();
Console.WriteLine("Fruits in reverse order:");
foreach (string fruit in Fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine();

//Finally display of fruits in the list
Console.WriteLine($"The fruits in your list are:");
foreach (string fruit in Fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine();