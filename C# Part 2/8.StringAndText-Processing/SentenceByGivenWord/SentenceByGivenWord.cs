//  Write a program that extracts from a given text all sentences containing given word.
//		Example: The word is "in". The text is:


//      The expected result is:


//		Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Text;

class SentenceByGivenWord
{
    static void Main()
    {
        Console.Write("Enter the wanted word : ");
        string word = Console.ReadLine();
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        StringBuilder substring = new StringBuilder();
        int start = 0;
        int curStart = 0;
        int curEnd = 0;
        bool isUsed = false;
        while (text.IndexOf(" " + word + " ", start) != -1)
        {
            curStart = text.IndexOf('.', start + 1);
            substring.Append(text.Substring(start,curStart - start + 1));
            if (substring.ToString().IndexOf(" " + word + " ")!= -1)
            {
                result.Append(substring.ToString());
                if (isUsed)
                {
                    substring.Remove(0, 2);
                }
                isUsed = true;
                Console.WriteLine(substring);
            }
            substring.Clear();
            start = curStart;
        }
    }
    //  We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
}

