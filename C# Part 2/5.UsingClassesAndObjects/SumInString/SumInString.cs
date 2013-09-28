//  You are given a sequence of positive integer values written into a string, separated by spaces.
//  Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

using System;
using System.Numerics;
using System.Text;

namespace SumInString
{
    class SumInString
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers : ");
            string numbers = Console.ReadLine();
            StringBuilder nums = new StringBuilder();
            int counter = 0;
            BigInteger sum = 0;
            bool isUsed = false;
            // the program works even with 1000 spaces
            while (counter < numbers.Length)
            {
                while (numbers[counter]!=' ')
                {
                    isUsed = true;
                    nums.Append(numbers[counter].ToString());
                    counter++;
                    if (counter==numbers.Length)
                    {
                        break;
                    }
                }
                if (isUsed)
                {
                    sum += BigInteger.Parse(nums.ToString());
                    isUsed = false;
                }
                else
                {
                    counter++;
                }
                nums = new StringBuilder();
            }
            Console.WriteLine("The sum is : {0}",sum);
        }
    }
}
