//  Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class RemoveAllWordsInATextFile
{
    static string RemoveEmptySpaces(string text)
    {
        while (text[0] == ' ')
        {
            text = text.Remove(0, 1);
        }
        int counter = 1;
        for (int i = 1; i < text.Length; i++)
        {
            counter = 1;
            if (text[i] == ' ' && i + counter < text.Length)
            {
                while (text[i + counter] == ' ')
                {
                    counter++;
                }
                if (i + counter < text.Length)
                {
                    text = text.Remove(i, counter);
                    text = text.Insert(i, " ");
                }
                i++;
            }
        }
        return text;
    }

    static void Main()
    {
        try
        {
            StreamReader test = new StreamReader("../../test.txt");
            StreamReader words = new StreamReader("../../words.txt");
            StreamWriter result = new StreamWriter("result.txt");
            Console.WriteLine("The old text is : ");
            Console.WriteLine(test.ReadToEnd());
            test = new StreamReader("../../test.txt");

            using (test)
            {
                string text = test.ReadToEnd();
                using (words)
                {
                    string[] word = words.ReadToEnd().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in word)
                    {
                        text = text.Replace(item, string.Empty);
                    }
                    using (result)
                    {
                        text = RemoveEmptySpaces(text);
                        Console.WriteLine("The new text is : ");
                        Console.WriteLine(text);
                        result.WriteLine(text);
                    }
                }
            }
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}

