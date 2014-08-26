using System;

class BankAccountExample
{
    static void Main()
    {  // Print information for a single bank account.
        string firstName, middName, lastName, bankName, ibanNumber, bicCode;
        decimal moneyBalance;
        ulong card1, card2, card3;
        firstName = "Ivan";
        middName = "Ivanov";
        lastName = "Petrov";
        bankName = "First Investment bank";
        ibanNumber = "BG80BNBG96611020345678";
        bicCode = "FINVBGSF";
        moneyBalance = 10000.45m;
        card1 = 1237478932434578;
        card2 = 7647328479487334;
        card3 = 8967874355890098;
        Console.WriteLine(" First name: {0}", firstName);
        Console.WriteLine(" Middle name: {0}", middName);
        Console.WriteLine(" Last name: {0}", lastName);
        Console.WriteLine(" Bank name: {0}", bankName);
        Console.WriteLine(" Iban number: {0}", ibanNumber);
        Console.WriteLine(" BIC code: {0}", bicCode);
        Console.WriteLine(" Money balance: {0}EUR", moneyBalance);
        Console.WriteLine(" Number of credit card1: {0}", card1);
        Console.WriteLine(" Number of credit card2: {0}", card2);
        Console.WriteLine(" Number of credit card3: {0}", card3);
    }
}
