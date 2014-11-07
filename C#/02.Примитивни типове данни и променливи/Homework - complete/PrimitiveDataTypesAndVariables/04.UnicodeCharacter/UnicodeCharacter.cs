using System;

class UnicodeCharacter
{
    static void Main()
    {
        // Set the proper encoding for encoding in console (just in case)
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        // Declare a character variable with the symbol that has Unicode code 42 (decimal)
        char someChar = '\u002A';

        // Print it on the console
        Console.WriteLine(someChar);
    }
}