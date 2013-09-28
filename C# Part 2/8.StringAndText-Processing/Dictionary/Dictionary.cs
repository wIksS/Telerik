//  A dictionary is stored as a sequence of text lines containing words and their explanations. 
//  Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

using System;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes",
                              "Java - object-oriented programming language, similar to C#",
                              "Javascript - web programming language"};
        Console.Write("Enter the word you want explanation for : ");
        string word = Console.ReadLine();

        foreach (string line in dictionary)
        {
            if (line.IndexOf(word + " -", StringComparison.OrdinalIgnoreCase) == 0)
            {
                Console.Write(line.Substring(word.Length + 1,line.Length - word.Length -1));
            }
        }
        Console.WriteLine();
    }
}