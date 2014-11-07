using System;

class AgeAfterTenYears
{
    static void Main()
    {
        // Ask user to enter its age
        Console.WriteLine("Enter your age:");

        // Get the entered value from the Console and add it to int(integer) with name 'Age'
        int CurrentAge = int.Parse(Console.ReadLine());

        // Declare new DateTime variable and give it today's date with DateTime.Now property
        DateTime today = DateTime.Now;

        // Add 10 years to today's date
        DateTime future = today.AddYears(10);

        // Add your age to future
        DateTime futureYear = future.AddYears(CurrentAge);

        // Subtract them to get your age in 10 years from now 
        int AfterTen = futureYear.Year - today.Year;

        // Print the new value for your age
        Console.WriteLine("After 10 years you will be:");
        Console.WriteLine(AfterTen + " years old.");
    }
}