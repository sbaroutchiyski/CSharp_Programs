using System;
using System.Text;

class PrintAllCardsFromStandardDeck
{
    static void Main()
    {   // Print All cards from standard deck (52 cards without jockers).
        Console.OutputEncoding = Encoding.UTF8;
        char[] symbols = new char[] { '\u2660', '\u2665', '\u2666', '\u2663' }; // spades, heards, diamonds, clubs
        Console.WriteLine("Cards:\n");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 2; j < 15; j++)
            {
                switch (j)
                {
                    case 2:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 3:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 4:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 5:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 6:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 7:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 8:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 9:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 10:
                        Console.Write("{0} ", j + " " + symbols[i]);
                        break;
                    case 11:
                        Console.Write("{0} ", "J" + " " + symbols[i]);
                        break;
                    case 12:
                        Console.Write("{0} ", "D" + " " + symbols[i]);
                        break;
                    case 13:
                        Console.Write("{0} ", "K" + " " + symbols[i]);
                        break;
                    case 14:
                        Console.Write("{0} ", "A" + " " + symbols[i]);
                        break;
                }
            }
            Console.WriteLine("\n");
        }
    }
}

