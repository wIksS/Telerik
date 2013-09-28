//Write a program that parses an URL address given in the format:

	//	and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
	//	[protocol] = "http"
    //	[server] = "www.devbg.org"
	//	[resource] = "/forum/index.php"

using System;

class ParseAnUrlAdress
{
    static void Main()
    {
        Console.Write("Enter the url adress : ");
        string urlAdress = Console.ReadLine();
        int start = 0;
        int end = 0;
        start = urlAdress.IndexOf("://");
        string protocol = urlAdress.Substring(0, start);
        end = urlAdress.IndexOf("/",start + 3);
        string server = urlAdress.Substring(start + 3, end - start);
        string resuourse = urlAdress.Substring(end, urlAdress.Length - end);
        Console.WriteLine("[protocol] = {0}", protocol );
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resuourse);
    }
}

