using System;

class NullValuesArithmetic
{
    static void Main()
    {
        // The proper way to declare int, double, etc values to Null is to add ? after the type
        int? nullInteger = null;
        double? nullDouble = null;

        // Print the null integer with Null and 5 values
        Console.WriteLine("This is the integer with Null value -> " + nullInteger);

        // Add some number to the nullInteger
        nullInteger += 5;
        Console.WriteLine("This is the integer with value 5 -> " + nullInteger);

        // Print the null double with Null and 5 values
        Console.WriteLine("This is the double with Null value -> " + nullDouble);

        // Add some number to the nullDouble
        nullDouble += 7.5;
        Console.WriteLine("This is the double with value 7.5 -> " + nullDouble);

    }
}