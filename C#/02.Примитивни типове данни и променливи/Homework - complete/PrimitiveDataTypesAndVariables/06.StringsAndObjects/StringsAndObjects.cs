using System;

class StringsAndObjects
{
    static void Main()
    {
        // Declare two string variables and assign them with “Hello” and “World”. 
        string hello = "Hello";
        string world = "World";

        // Declare an object variable with the concatenation of the hello and world variables
        object greeting = hello + " " + world;

        // Declare a string variable with the value of the object variable
        string sayhello = greeting.ToString();

        // Print the result
        Console.WriteLine(sayhello);
    }
}