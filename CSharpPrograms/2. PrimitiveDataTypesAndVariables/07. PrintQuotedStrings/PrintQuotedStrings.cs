using System;

class PrintQuotedStrings
{
    static void Main()
    {   // Print two sentences in two ways (with or without quoted string).
        string firstSentence = "The \"use\" of quotations causes difficulties.";
        string secondSentence = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstSentence);
        Console.WriteLine(secondSentence);
    }
}

