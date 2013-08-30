//  Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. 
//  The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. 
//  Handle all possible exceptions in your methods.

using System;
using System.IO;

class HowManyTimesAWordIsInAFile
{
    static void Main()
    {
        StreamReader words = new StreamReader("../../words.txt");
        Console.WriteLine("words.txt file contains : ");
        Console.WriteLine(words.ReadToEnd());
        words = new StreamReader("../../words.txt");
        StreamReader test = new StreamReader("../../test.txt");
        Console.WriteLine("test.txt file contains : ");
        Console.WriteLine(test.ReadToEnd());
        test = new StreamReader("../../test.txt");
        StreamWriter result = new StreamWriter("result.txt");
        string[] word;
        string text;

        using (words)
        {
            word = words.ReadToEnd().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] times = new int[word.Length]; 
            using (test)
            {
                text = test.ReadToEnd();
                for (int i = 0; i < word.Length; i++)
                {
                    int index = -1;
                    do
                    {
                        index = text.IndexOf(word[i], index + 1);
                        times[i]++;
                    } while (index >= 0);
                }

                int max = int.MinValue;
                int old = int.MaxValue;
                int curValue = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < times.Length; j++)
                    {
                        if (times[j] > max && times[j] < old)
                        {
                            max = times[j];
                            curValue = j;
                        }
                    }
                    Console.WriteLine("word -- > {0} ; times -- > {1}", word[curValue], times[curValue]);
                }
            }
        }
    }
}

