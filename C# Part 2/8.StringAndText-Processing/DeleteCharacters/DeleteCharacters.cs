//  Write a program that reads a string from the console and replaces all series of
//  consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;

class DeleteCharacters
{
    static void Main()
    {
        Console.Write("Enter the text : ");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        int counter = 0;
        result.Append(text[0].ToString());
        for (int i = 1; i < text.Length; i++)
        {
            result.Append(text[i].ToString());
            if (result[i- counter] == result[i - counter - 1 ])
            {
                result.Remove(i - counter, 1);
                counter++;
            }
        }

        Console.WriteLine(result);
    }
}

