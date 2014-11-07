using System;

public class Program
{
    public static void Main()
    {
        // Set the proper encoding for printing copyright symbols
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Set the necessary variables
        char copyrightSymbol = '\u00A9'; // char variable with copyright symbols
        int totalLines = 9; // number of the copyright symbols for the entire triangle
        int leftSpace = totalLines - 2; // free/blank space on the left bofore copyright symbol
        int middleSpace = 1; // free/blank space inside the triangle
        string lastLine = copyrightSymbol + " "; // last line of the triangle (the bottom one)

        // Set the condition for the 1st line of the triangle (spaces = lines - 1) and after that copyright symbol
        string firstLine = new string(' ', totalLines - 1) + copyrightSymbol;

        // Print the first line
        Console.WriteLine(firstLine);

        // middleLines = all symbol for the triangle (all chars)
        // this way we get the necessary number of symbols we need to finish the triangle
        for (int middleLines = 2; middleLines < totalLines * 2; middleLines++)
        {
            // Print the all the necessary symbols + spaces after the firstLine and before the lastLine
            if (middleLines < totalLines)
            {
                Console.WriteLine(new string(' ', leftSpace) + copyrightSymbol + new string(' ', middleSpace) + copyrightSymbol);
                middleSpace += 2;
                leftSpace--;
            }
            else
            {
                // Print the last line
                Console.Write(lastLine);
            }
        }
        Console.WriteLine();
    }
}