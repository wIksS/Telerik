//  Write a program that extracts from given XML file all the text without the tags. Example:

using System;
using System.IO;
using System.Text;

class TextWithoutTheTags
{
    static void Main()
    {
        StreamReader text = new StreamReader("../../text.txt");
        string file = text.ReadToEnd();
        StringBuilder extractedFile = new StringBuilder();
        int index = 0;
        while (index >= 0)
        {
            index = file.IndexOf(">",index + 1);
            if (file[index+1] != '<')
            {
                int nextIndex = file.IndexOf("<",index + 1);
                if (nextIndex == -1)
                {
                    break;
                }
                extractedFile.AppendLine(file.Substring(index + 1, nextIndex - index - 1));                
            }
        }
        Console.Write(extractedFile);
    }
}

