//  Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//  If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

namespace TenNumbersInCorrectFormat
{
    class TenNumbersInCorrectFormat
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the start : ");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the end : ");
                int end = int.Parse(Console.ReadLine());
                ReadNumber(start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("Your input is not a number!");                
            }
        }

        static void ReadNumber(int start, int end)
        {
            try
            {
                int temp = start;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter number {0} : ", i + 1);
                    int num = int.Parse(Console.ReadLine());
                    if (num <= temp || num < start || num > end)
                    {
                        throw new ArgumentException();
                    }
                    temp = num;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The new number must be smaller than the \"start\" \nAnd it should bigger than the \"end\"!");
                Console.WriteLine("Also, every new number must be bigger than the old one!");
            }
            
        }
    }
}
