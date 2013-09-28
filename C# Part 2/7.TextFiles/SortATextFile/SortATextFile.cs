//  Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:

using System;
using System.IO;

class SortATextFile
{
    static void Main()
    {
        StreamReader text = new StreamReader("../../text.txt");
        StreamWriter sortedText = new StreamWriter("sortedText.txt");
        using (text)
        {
            string[] names = text.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(names);
            using (sortedText) 
            {
                foreach (var item in names)
                {
                    sortedText.Write(item);
                }
            }
        }
    }
}

