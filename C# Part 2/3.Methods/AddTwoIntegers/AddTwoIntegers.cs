//  Write a method that adds two positive integer numbers represented as arrays of digits 
//  (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first num : ");
            string firstNum = Console.ReadLine();
            Console.Write("Enter the second num : ");
            string secondNum = Console.ReadLine();
            Console.WriteLine(AddDigits(firstNum, secondNum));
        }
        
        static string AddDigits(string firstNum, string secondNum)
        {
            int[] firstArray = new int[firstNum.Length];
            int[] secondArray = new int[secondNum.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = firstNum[i] - 48;
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = secondNum[i] - 48;
            }
            int max = firstArray.Length;
            if (max < secondArray.Length)
            {
                max = secondArray.Length;
            }
            int[] addedDigits = new int[max + 1];
            int counter1 = 1;
            int counter2 = 1;
            int minus1 = addedDigits.Length - 1;
            int minus2 = addedDigits.Length - 1;
            for (int i = addedDigits.Length - 1; i > 0; i--)
            {
                while (minus1 > firstArray.Length)
                {
                    counter1++;
                    minus1--;
                }
                while (minus2 > secondArray.Length)
                {
                    counter2++;
                    minus2--;
                }
                if (i - counter1 < 0)
                {
                    addedDigits[i] += secondArray[i - counter2];
                    if (addedDigits[i] > 9)
                    {
                        addedDigits[i] -= 10;
                        addedDigits[i - 1] += 1;
                    }
                    continue;
                }
                if (i - counter2 < 0)
                {
                    addedDigits[i] += firstArray[i - counter1];
                    if (addedDigits[i]>9)
                    {
                        addedDigits[i] -= 10;
                        addedDigits[i - 1] += 1;
                    }
                    continue;
                }
                if (firstArray[i - counter1] + secondArray[i - counter2] > 9)
                {
                    addedDigits[i] += (firstArray[i - counter1] + secondArray[i - counter2]) % 10;
                    addedDigits[i - 1] += 1;
                }
                else
                {
                    addedDigits[i] += firstArray[i - counter1] + secondArray[i - counter2];
                }
            }
            string result = string.Join("", addedDigits);
            if (result[0]=='0')
            {
                result = result.Remove(0, 1);
            }
            return result;
        }
    }
}
