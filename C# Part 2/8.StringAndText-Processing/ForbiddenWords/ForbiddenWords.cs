//  We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:
//		Words: "PHP, CLR, Microsoft"
//		The expected result:

using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter the the forbiddent words separated by \",\" and no spaces : ");
        string words = Console.ReadLine();
        Console.WriteLine("Enter the text : ");
        string text = Console.ReadLine();
        StringBuilder newText = new StringBuilder(text);
        string[] forbbidenWords = words.Split(',' , ' ');
        for (int i = 0; i < forbbidenWords.Length; i++)
        {
            if (forbbidenWords[i] == "")
            {
                continue;
            }
            while (newText.ToString().IndexOf(forbbidenWords[i]) != -1)
            {
                newText.Replace(forbbidenWords[i],new string('*',forbbidenWords[i].Length));
            }
        }
        Console.WriteLine(newText);
    }
}
