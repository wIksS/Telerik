//  Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;

class AllLettersInAString
{
    static void Main()
    {
        Console.Write("Enter the text : ");
        string text = Console.ReadLine();
        int[] times = new int[text.Length];
        char[] letters = new char[text.Length];
        int counter = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (!letters.Contains(text[i]))
            {
                letters[counter] = text[i];
                times[counter]++;
                counter++;
            }
            else
            {
                int index = Array.IndexOf(letters, text[i]);
                times[index]++;
            }
        }
        for (int i = 0; i < letters.Length; i++)
        {
            if (times[i]== 0)
            {
                return;
            }
            Console.WriteLine("letter - {0} ; times - {1}",letters[i],times[i]);
        }

    }
}

