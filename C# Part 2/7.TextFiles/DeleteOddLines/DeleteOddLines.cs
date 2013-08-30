//  Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader text = new StreamReader("../../text.txt");
        List<string> lines = new List<string>();
        using (text)
        {
            int row = 0;
            string curLine = text.ReadLine();
            while (curLine != null)
            {
                if (row % 2 == 0)
                {
                    lines.Add(curLine);
                }
                row++;
                curLine = text.ReadLine();
            }            
        }

        StreamWriter removedLines = new StreamWriter("../../text.txt");
        using (removedLines)
        {
            foreach (var item in lines)
            {
                removedLines.WriteLine(item);
            }
        }
    }
}

