using System;

class EnglishPronunciation
{
    static void Main()
    {
        string[] fromElevenToTwenty = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eigteen", "nineteen" };
        string[] edinici = new String[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] desetici = new String[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] stotici = new String[] { "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };
        int digitHundred;
        int digitTen;
        int digitOne;
        int n = int.Parse(Console.ReadLine());
        
        while (n<1 || n > 999)
        {
            Console.WriteLine("The data you have entered is incorrect !");
            Console.WriteLine("Try again");
            n = int.Parse(Console.ReadLine());
        }

        if (n > 99)
        {
            digitHundred = (n / 100);
            digitTen = ((n / 10) % 10);
            digitOne = n % 10;


            if ((digitTen == 0) && (digitOne == 0))
            {
                Console.WriteLine("{0}", stotici[digitHundred - 1]);
            }
            else if (digitTen == 0)
            {
                Console.WriteLine("{0} and {1}", stotici[digitHundred - 1], edinici[digitOne]);
            }
            else if (digitOne == 0 && digitTen >= 2)
            {
                Console.WriteLine("{0} and {1}", stotici[digitHundred - 1], desetici[digitTen - 2]);
            }
            else if (digitTen < 2)
            {
                Console.WriteLine("{0} and {1}", stotici[digitHundred - 1], fromElevenToTwenty[digitOne]);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", stotici[digitHundred - 1], desetici[digitTen - 2], edinici[digitOne]);
            }

        }


        if (n < 100)
        {
            digitHundred = (n / 100);
            digitTen = ((n / 10) % 10);
            digitOne = n % 10;
            if (n > 19)
            {
                if (digitOne == 0)
                {
                    Console.WriteLine("{0}", desetici[digitTen - 2]);
                }
                else
                {
                    Console.WriteLine("{0} {1}", desetici[digitTen - 2], edinici[digitOne]);
                }

            }
            if (n < 20 && n > 9)
            {
                digitOne = n % 10;
                Console.WriteLine("{0}", fromElevenToTwenty[digitOne]);
            }
            else if (n < 10)
            {
                digitOne = n % 10;
                Console.WriteLine("{0}", edinici[digitOne]);
            }
        }
    }
}



