//  Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;

class RemovePrefixTest
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../text.txt");
        int index = -1;
        string text;

        using (input)
        {
            text = input.ReadToEnd();
        }

        Console.WriteLine("Old text : \n{0}", text);

        do
        {
            index = text.IndexOf("test", index + 1);
            int end = text.IndexOf(" ", index + 1);
            if (end < 0 || index < 0)
            {
                end = text.IndexOf("\r", index + 1);
                if (end < 0)
                {
                    continue;
                }
                if (index<0)
                {
                    continue;
                }
            }
            text = text.Remove(index, end - index);
        } while (index >= 0);

        Console.WriteLine("New text : ");
        Console.WriteLine(text);
    }
}

