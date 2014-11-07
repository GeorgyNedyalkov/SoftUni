using System;

class BankAccountData
{
    static void Main()
    {
        // Declare the necessary variables
        // Use string, because it is perfect for names
        string firstName = "Georgi";
        string middleName = "Viktorov";
        string lastName = "Nedyalkov";

        decimal availableMoney = 1459.57M; // Use decimal, because we work with money and we need best precision possible
        string bankName = "Nedyalkov Corp."; // Use string, because bankName can hold various character with spaces, etc.
        string iban = "39 FINV 9150 1003 5487 97"; // Use string, because iban is combinations between numbers and characters

        // Use ulong, because we need to hold 16 positive digits for card numbers
        ulong creditCardVisa = 4335277704041717;
        ulong creditCardMaestro = 4773252500036003;
        ulong creditCardMaster = 4121212533071555;

        // Print all the info out with several Console.WriteLine for more pretty look
        Console.WriteLine("Bank account data for: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Avaiable amount of money: {0} leva", availableMoney);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit cards numbers:\nVisa: {0}\nMaestro: {1}\nMaster Card: {2}", creditCardVisa, creditCardMaestro, creditCardMaster);
    }
}