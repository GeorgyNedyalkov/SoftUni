using System;

class QuotesInStrings
{
    static void Main()
    {
        // Declare strings variables with and without quoted values
        string firtQuotes = "The \"use\" of quotations causes difficulties.";
        string secondQuotes = @"The ""use"" of quotations causes difficulties.";

        // Print it out on the console
        Console.WriteLine(firtQuotes);
        Console.WriteLine(secondQuotes);
    }
}