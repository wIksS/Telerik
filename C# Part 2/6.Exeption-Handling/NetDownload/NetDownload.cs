//  Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
//  Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

namespace NetDownload
{
    class NetDownload
    {
        static void Main(string[] args)
        {
            string remoteUrl = "http://www.devbg.org/img/Logo-BASD.jpg";
            string fileName = "Logo-BASD.jpg";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(remoteUrl, fileName);
        }
    }
}
