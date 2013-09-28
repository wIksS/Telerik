//  You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//  The expected result:

using System;
using System.Text;

class ToUpperCase
{
    static void Main()
    {
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        int start = 0;
        int curStart = 0;
        int curEnd = 0;

        while (text.IndexOf("<upcase>",start)!= -1)
        {
            curStart = text.IndexOf("<upcase>", start) + 8;
            if (start == 0)
            {
                result.Append(text.Substring(start, curStart - start - 8));
                curEnd = text.IndexOf("</upcase>", start);
                result.Append(text.Substring(curStart, curEnd - curStart).ToUpper());
            }
            else
            {
                result.Append(text.Substring(start , curStart - start - 8));
                curEnd = text.IndexOf("</upcase>", start);
                result.Append(text.Substring(curStart, curEnd - curStart).ToUpper());
            }
           
            start = curEnd + 9;
        }

        result.Append(text.Substring(start, text.Length - start));
        Console.WriteLine("The new sentence : ");
        Console.WriteLine(result);
    }
    // We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

}

