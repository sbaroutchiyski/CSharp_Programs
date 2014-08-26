using System;

class StringConcatenation
{
    static void Main()
    {   // Concatenate strings.
        string firstWord = "Hello ";
        string secondWord = "World";
        object sentence = firstWord + secondWord;
        string thirdWord = (string)sentence;
        Console.WriteLine("{0}.", thirdWord);
    }
}

