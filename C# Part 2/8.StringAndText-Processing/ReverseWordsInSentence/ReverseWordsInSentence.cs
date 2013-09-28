//  Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Text;

class ReverseWordsInSentence
{
    static void Main()
    {
        Console.Write("Enter the url adress : ");
        string sentence = Console.ReadLine();
        Console.WriteLine(ReverseWords(sentence));
    }

    static string ReverseWords(string text)
    {
        StringBuilder result = new StringBuilder();
        bool isOnce = true;
        string[] words = text.Split(' ');
        char sign = text[text.Length-1];
        for (int i = 0; i < words.Length; i++)
        {           
            result.Append(words[words.Length - i - 1] + " ");
            if (isOnce)
            {
                result.Remove(result.Length - 2,1);
                isOnce = false;
            }
        }

        result.Remove(result.Length - 1, 1);
        result.Append(sign.ToString());
        return result.ToString();
    }
}

