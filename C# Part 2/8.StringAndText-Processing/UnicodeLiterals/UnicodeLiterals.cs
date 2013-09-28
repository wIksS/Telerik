//  Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//		Expected output:


using System;

class UnicodeLiterals
{
    static void Main()
    {
        Console.Write("Enter the string : ");
        string text = Console.ReadLine();
        foreach (char ch in text)
        {
                  Console.Write("\\u{1:x4}", ch, (int)ch, (int)ch);
        }
        Console.WriteLine();
    }
}

