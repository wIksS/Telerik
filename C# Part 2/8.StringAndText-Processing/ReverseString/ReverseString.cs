//  Write a program that reads a string, reverses it and prints the result at the console.
//  Example: "sample"  "elpmas".

using System;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        Console.WriteLine(ReverseText(text));
    }

    static string ReverseText(string text)
    {
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}

