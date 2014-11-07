using System;

class ExchangeVariableValues
{
    static void Main()
    {
        // Declare 2 integer variables
        int a = 5;
        int b = 10;

        // Print the 'result'
        Console.WriteLine("Integer values before exchange:\na = {0}\nb = {1}\n", a, b);

        // Exchange their values
        a ^= b;
        b ^= a;
        a ^= b;

        // Print the new result
        Console.WriteLine("Integer values after exchange:\na = {0}\nb = {1}\n", a, b);
    }
}