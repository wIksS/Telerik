using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = "1.1.1980";
            string endDate = "31.12.2013";
            InvalidRangeException<DateTime> someYear = new InvalidRangeException<DateTime>("Dates must be in range [1.1.1980 … 31.12.2013]", DateTime.Parse(startDate), DateTime.Parse(endDate));
            Console.Write("Enter 3 dates ---> ");
            for (int i = 0; i < 3; i++)
            {
                DateTime dateElement = DateTime.Parse(Console.ReadLine());

                if (dateElement.Year < someYear.Start.Year || dateElement.Year > someYear.End.Year)
                {
                    throw someYear;
                }
                else if (dateElement.Month < someYear.Start.Month || dateElement.Month > someYear.End.Month)
                {
                    throw someYear;
                }
                else if (dateElement.Day < someYear.Start.Day || dateElement.Day > someYear.End.Day)
                {
                    throw someYear;
                }
            }

            InvalidRangeException<int> someInt = new InvalidRangeException<int>("Nums must be in range [1..100]", 1, 100);
            Console.Write("Enter 3 nums ---> ");
            for (int i = 0; i < 3; i++)
            {
                int intElement = int.Parse(Console.ReadLine());

                if (intElement < someInt.Start || intElement > someInt.End)
                {
                    throw someInt;
                }
            }
        }
    }
}
