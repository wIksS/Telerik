//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. 
//Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

namespace ReadAFileFromTheComputer
{
    class ReadAFileFromTheComputer
    {
        static void Main(string[] args)
        {
            try
            {
                string textFile = File.ReadAllText(@"C:\WINDOWS\win.ini");
                Console.WriteLine(textFile);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is null (it doesnt contain anything)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The problem can be : ");
                Console.WriteLine("A zero lenght string");
                Console.WriteLine("Contains only white spaces");
                Console.WriteLine("Contains one or more invalid characters");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path or the file name exeed the maximum lenght which is 248 or 260 !");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The path is invalid (there is not such file) !");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in the path is not found !");
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("You dont have the required permision !");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The problem can be : ");
                Console.WriteLine("The file is read - only");
                Console.WriteLine("The operation is not supported on the current platform!");
                Console.WriteLine("The path leads to a directory");
                Console.WriteLine("You dont have the required permision");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The path is in invalid format !");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occured !");
            }
        }
    }
}
