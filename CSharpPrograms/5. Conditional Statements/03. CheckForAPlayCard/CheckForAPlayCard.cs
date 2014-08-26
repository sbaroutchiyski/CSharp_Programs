using System;

class CheckForAPlayCard
{
    static void Main()
    {   // Prints “yes” if it is a valid card sign or “no” otherwise. 
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        Console.WriteLine("Enter a card sign (2 to A)");
        Console.Write("Card=");
        string card = Console.ReadLine();
        string result = "no";
        for (int i = 0; i < cards.Length; i++)
        {
            if (card == cards[i])
            {
                result = "yes";
                break;
            }
        }
        Console.WriteLine("Result: {0}", result);
    }
}

