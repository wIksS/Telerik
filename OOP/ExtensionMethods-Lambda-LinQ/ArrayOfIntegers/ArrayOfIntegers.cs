using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfIntegers
{
    class ArrayOfIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array : ");
            int length = int.Parse(Console.ReadLine());
            int[] nums = new int[length];
            // reading the length of the array from the console

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} element : ",i);
                nums[i] = int.Parse(Console.ReadLine());
                // reading each element in the array from the console
            }

            Console.WriteLine("\nUsing LinQ : ");
            PrintDivisilbeNumsLinQ(nums);
            // printing all the divisible nums using LinQ

            Console.WriteLine("\nUsing Lambda :");
            PrintDivisilbeNumsLambda(nums);
            // printing all the divisible nums using Lambda
        }

        static void PrintDivisilbeNumsLinQ(int[] nums)
        {
            var divisibleNums = from num in nums
                                where num % 7 == 0 || num % 3 == 0
                                select num;

            Console.WriteLine("Nums divisible by 3 and 7 : ");

            foreach (var item in divisibleNums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintDivisilbeNumsLambda(int[] nums)
        {
            var divisibleNums = nums.Where(num => num % 3 == 0 || num % 7 == 0).Select(num => num);

            Console.WriteLine("Nums divisible by 3 and 7 : ");

            foreach (var item in divisibleNums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
