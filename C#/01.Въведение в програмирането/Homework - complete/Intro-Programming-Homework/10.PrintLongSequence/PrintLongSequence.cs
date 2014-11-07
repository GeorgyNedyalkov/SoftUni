using System;

class PrintLongSequence
{
    static void Main()
    {
        // Declare new int variable and use it to loop from 2 to 1000
        for (int count = 2; count <= 1000; count++)
        {
            // Check if the number is even, and if it is print the positive value of it
            if (count % 2 == 0)
            {
                Console.Write(count + " ");
            }
            // else, print the negative value of that number
            else
            {
                Console.Write(-count + " ");
            }

        }
    }
}