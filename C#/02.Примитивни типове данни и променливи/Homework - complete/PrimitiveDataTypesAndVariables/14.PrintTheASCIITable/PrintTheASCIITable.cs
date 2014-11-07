using System;

class PrintTheASCIITable
{
    static void Main()
    {
        // Set the proper encoding for encoding in console
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        // Loop from 33 to 255 character, because the first 31 character can't be displayed
        // and the 32 character is empty space
        for (char asciiChar = (char)033; asciiChar <= (char)255; asciiChar++)
        {
            // Print it on the console
            Console.WriteLine(asciiChar);
        }
    }
}