//  Write a program that reads a string from the console and lists all different 
//  words in the string along with information how many times each word is found.

using System;
using System.Linq;

class AllWordsInString
{
    static void Main()
    {
        Console.Write("Enter the text : ");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        int[] times = new int[text.Length];
        string[] neededWord = new string[text.Length];
        int counter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (!neededWord.Contains(words[i]))
            {
                neededWord[counter] = words[i];
                times[counter]++;
                counter++;
            }
            else
            {
                int index = Array.IndexOf(neededWord, words[i]);
                times[index]++;
            }
        }
        for (int i = 0; i < neededWord.Length; i++)
        {
            if (times[i] == 0)
            {
                return;
            }
            Console.WriteLine("word : {0} - times : {1}", neededWord[i], times[i]);
        }
    }
}

