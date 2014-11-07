using System;

// Changed class name from hoRRiblEcoDe to ReformatCSharpCode
class ReformatCSharpCode
{
    static void Main()
    {
        // Print 2 lines of text, each at a separate line
        Console.WriteLine("Hi, I am horribly formatted program");
        Console.WriteLine("Numbers and squares:");

        //  Declare new int variable and use it to loop from 0 to 9
        for (int i = 0; i < 10; i++)
        {
            // Print the number and the square value of it, each at a separate line
            Console.WriteLine(i + " --> " + i * i);
        }
    }
}