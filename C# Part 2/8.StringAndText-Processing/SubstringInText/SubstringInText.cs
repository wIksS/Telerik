//  Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
//	The result is: 9.

using System;

class SubstringInText
{
    static void Main(string[] args)
    {
        Console.Write("Enter the substring : ");
        string substring = Console.ReadLine();
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        int times = 0;
        int start = -1;
        while (text.IndexOf(substring, start + 1) != -1)
        {
            start = text.IndexOf(substring, start + 1);
            times++;
        }

        Console.WriteLine(times);
    }
}

