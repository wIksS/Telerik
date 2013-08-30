//  Write a program that reads an integer number and calculates and prints its square root. 
//  If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter integer num : ");
                int num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    throw new ArgumentException();
                }
                double squareNum = Math.Sqrt(num);
                Console.WriteLine("The new square rooted num is : {0}",squareNum);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The number must be postivie!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of the number you have entered!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big for the integer type!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
