using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMCallHistoryTest 
    {
        static void Main()
        {
            GSM phone = new GSM("Galaxy-Mini", "Samsung", 300, "Pesho Peshev");
            // the model of the phone is my personal phone :D
            Console.WriteLine(phone.ToString());
            // im showing what my overriden ToString() method does
            // I know its not in the task but i really wanted to show it :))
            Console.WriteLine(new String('-', 35));
            //making a new line and dots so you can see where the price is

            phone.AddCall("088728328", 320);
            //making a call to a random number and 
            // its duration is 320 seconds
            phone.AddCall("000000000", 50673);
            phone.AddCall("099999999", 20);
            phone.AddCall("987654321", 3);
            // ading some more calls
            phone.AddCall();
            // added a phone with null fields

            int counter = 1;
            // this counter helps me show the number
            // of the current call
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine("{0} call :",counter);
                Console.WriteLine("Duration --> {0} seconds",call.Duration);
                Console.WriteLine("Date and time of the call --> {0}", call.CallTime);
                Console.WriteLine("The dialed number --> {0}", call.DialedNumber);
                counter++;
                // here i just show all my fields in the classes
            }
            Console.WriteLine(new String('-',35));
            //making a new line and dots so you can see where the price is
            Console.WriteLine("Total price is : {0:0.00} leva",phone.CalculateTotalCallPrice((decimal)0.37));
            // i m calculating the sum with price 0.37 (its said in the task)

            int index = FindLongestCall(phone);
            // in this method i go through the List<Call>
            // and I find the element with the longest duration
            // i store it in a variable max and i store its index
            // in a variable index so i can use it in my other method
            // in the GSM class (phone.DeleteCall())
            phone.DeleteCall(index);
            Console.WriteLine(new String('-', 35));
            //making a new line and dots so you can see where the price is
            Console.WriteLine("New total price is : {0:0.00} leva", phone.CalculateTotalCallPrice((decimal)0.37));

            phone.ClearCallHistory();
            counter = 0;
            Console.WriteLine(new String('-', 35));
            //making a new line and dots so you can see where the price is
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine("{0} call :", counter);
                Console.WriteLine("Duration --> {0} seconds", call.Duration);
                Console.WriteLine("Date and time of the call --> {0}", call.CallTime);
                Console.WriteLine("The dialed number --> {0}", call.DialedNumber);
                counter++;
                // here i just show all my fields in the classes
                // this time it doesnt show anything because i have cleared
                // the history
            }
        }

        static int FindLongestCall(GSM phone)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                if (phone.CallHistory[i].Duration > max)
                {
                    max = phone.CallHistory[i].Duration;
                    index = i;
                }
            }
            return index;
        }
    }
}
