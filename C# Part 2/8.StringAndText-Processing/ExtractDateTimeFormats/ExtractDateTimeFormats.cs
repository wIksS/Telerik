//  Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = new CultureInfo("fr-CA");
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        Console.WriteLine(text.IndexOf());
    }
}

