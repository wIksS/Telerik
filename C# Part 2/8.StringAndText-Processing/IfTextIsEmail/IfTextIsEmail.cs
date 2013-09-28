//  Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;

class IfTextIsEmail
{
    static void Main(string[] args)
    {
        Console.Write("Enter the email : ");
        string email = Console.ReadLine();
        if (email.IndexOf('@') != -1 && email.IndexOf('@') != 0 && email.IndexOf('@') != email.Length)
        {
            int start = email.IndexOf('@');
            if (email.IndexOf('.',start + 2) != -1 && email.IndexOf('.',start + 2) != email.Length)
            {
                Console.WriteLine("The text is an email !");
            }
        }
        else
        {
            Console.WriteLine("Whrong format for an email !");
        }
    }
}

