using System;

class FloatOrDouble
{
    static void Main()
    {
        // Declare variables choosing the most appropriate type (float or double) 
        double numberA = 34.567839023d;
        float numberB = 12.345f;
        double numberC = 8923.1234857d;
        float numberD = 3456.091f;

        // Print the result
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", numberA, numberB, numberC, numberD);
    }
}