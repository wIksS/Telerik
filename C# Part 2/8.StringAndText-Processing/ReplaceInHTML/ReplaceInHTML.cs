//  Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
//  Sample HTML fragment:

using System;
using System.Text;

class ReplaceInHTML
{
    static void Main()
    {
        Console.Write("Enter the document : ");
        string document = Console.ReadLine();     
        StringBuilder text = new StringBuilder(document);
        int start = 0;
        start = text.ToString().IndexOf("<a href=",start);
        text.Replace("<a href=\"", "[URL=");
        while (text.ToString().IndexOf("\">") != -1)
        {
            start = text.ToString().IndexOf("\">", start);
            text.Remove(start, 1);
            text[start] = ']';
        }

        text.Replace("</a>", "[/URL]");        
        Console.WriteLine();
        Console.WriteLine(text);
    }
}

