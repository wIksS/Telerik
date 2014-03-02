using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Lambda_Expressions_Linq
{
    static class ExtensionSubString
    {
        // making an extesion method for substring with parameter
        // for the start of the sub string and how many elements
        // does the caller want
        public static StringBuilder SubString(this StringBuilder text, int startIndex, int elementsCount)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < elementsCount; i++)
            {
                result.Append(text[i + startIndex]);
                // starting from the start index element untill
                // the elementsCount
            }

            // returning the new text
            return result;
        }

        static void Main()
        {
            Console.Write("Enter the text : ");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            Console.Write("Enter the start of the sub string : ");
            int startIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter the count of the elements in the substring : ");
            int elementsCount = int.Parse(Console.ReadLine());
            text = text.SubString(startIndex, elementsCount);
            Console.WriteLine("The substring is : {0}", text);
        }
    }
}
