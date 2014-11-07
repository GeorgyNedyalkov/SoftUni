using System;

class ComparingFloats
{
    static void Main()
    {
        // 'Head' message
        Console.WriteLine("Please insert 2 double values each on separate line (example: 5,3 and 6,01):");

        // Get 2 double values from console
        double numberA = Convert.ToDouble(Console.ReadLine());
        double numberB = Convert.ToDouble(Console.ReadLine());

        // Declare epsilon with precision 0.000001
        double eps = 0.000001;
        double absA = Math.Abs(numberA);
        double absB = Math.Abs(numberB);

        // Get the difference between the 2 variables
        double diff = Math.Abs(numberA - numberB);

        // Check if the difference between the 2 variables are close enough to eps
        if (diff < eps)
        {
            Console.WriteLine("Are {0} and {1} equal? - True", numberA, numberB);
        }
        else
        {
            Console.WriteLine("Are {0} and {1} equal? - False", numberA, numberB);
        }
    }
}