using System;

class ASCIITable
{
    static void Main()
    {
        for (int i = 0, b = 0; i < 128; i++, b++)
        {
            Console.Write("{1} : {0}\n", (char)i, b);
        }
        Console.WriteLine();

        //int x = 5;
        //int i = 0;
        //int b = 0;
        //int z = 10;
        //int a = 15;
        //int w = 20;
        //int r = 25;
        //int y = Console.CursorTop;
        //int f = Console.CursorTop;
        //int q = Console.CursorTop;
        //int t = Console.CursorTop;
        //int h = Console.CursorTop;
        //for (i=0; i < 15; i++,b++)
        //{
        //    Console.Write("{1}:{0}\n", (char)i, b);
        //}

        //    for (int c = 0; c < 15; c++,y++,b++,i++)
        //    {
        //        Console.SetCursorPosition(x, y);
        //        Console.Write("{1}:{0}\n", (char)i, b);

        //    }
        //    for (int k = 0; k < 15; k++,f++,b++,i++)
        //    {
        //        Console.SetCursorPosition(z, f);
        //        Console.Write("{1}:{0}\n", (char)i, b);
        //    }
        //    for (int e = 0; e < 15; e++, q++,b++,i++)
        //    {
        //        Console.SetCursorPosition(a, q);
        //        Console.Write("{1}:{0}\n", (char)i, b);
        //    }
        //    for (int l = 0; l < 15; l++, t++, b++, i++)
        //    {
        //        Console.SetCursorPosition(w, q);
        //        Console.Write("{1}:{0}\n", (char)i, b);
        //    }
        //    for (int s = 0; s < 15; s++, h++, b++, i++)
        //    {
        //        Console.SetCursorPosition(r, q);
        //        Console.Write("{1}:{0}\n", (char)i, b);
        //    }
        

    }
}

