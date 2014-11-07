using System;

class EmployeeData
{
    static void Main()
    {
        // Declare the necessary variables
        // Use strings, because it is perfect for names
        string firstName = "Georgi";
        string lastName = "Nedyalkov";
        byte age = 24; // Use byte, because we need only positive values from 0 to 100, byte is up to 255
        char gender = 'm'; // Use char type, because gender must be represented by only 1 character
        ulong personalIDNumber = 8306112507; // Use ulong instead of long, because this number can't be negative
        ulong uniqueEmployeeNum = 2756000027569999; // Use ulong, because need to store very large and positive number

        // Print 'head' message before print all the info
        Console.WriteLine("Employee Data:");

        // Use placeholders just because don't need to use more than one Console.WriteLine
        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID Number: {4}\nUnique Emp. Number: {5}",
                            firstName, lastName, age, gender, personalIDNumber, uniqueEmployeeNum);
    }
}