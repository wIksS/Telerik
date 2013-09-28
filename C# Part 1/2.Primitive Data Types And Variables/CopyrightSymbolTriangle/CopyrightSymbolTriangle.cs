using System;
using System.Text; // We must use this library so we can use the ENCODING property

class CopyRightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Enter how many rolls you want : ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the symbol you want : ");
        char symbol=char.Parse(Console.ReadLine());
        int cells = rows;
        int i = 0;
        string blankCells = new String(' ', rows--);
        string symbolCells = new String(symbol, 2 * i + 1);
        for (; i < rows; i++,cells--)
        {
            Console.Write(new String(' ', cells-1));
            Console.Write(new String(symbol, 2 * i + 1));
            Console.WriteLine(new String(' ', cells-1));
        }
        //char copyRight = '©';
        //Console.WriteLine("  {0}",copyRight);
        //Console.WriteLine(" {0}{0}{0}",copyRight);
        //Console.WriteLine("{0}{0}{0}{0}{0}",copyRight);
        
    }
}
