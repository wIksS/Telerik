using System;
using System.Text; 

class HecToBin
{
    static void Main()
    {
        Console.Write("Enter the hexademical number : ");
        string hexademical = Console.ReadLine();
        StringBuilder binary = new StringBuilder();
        bool isUsed = false;
        for (int i = 0; i < hexademical.Length; i++)
        {
            if (hexademical[i]< 10 + 48)
            {
                if (isUsed)
                {
                    binary.Append(Convert.ToString(hexademical[i] - 48, 2).PadLeft(4, '0'));
                }
                else
                {
                    binary.Append(Convert.ToString(hexademical[i] - 48, 2));
                    isUsed = true;
                }
            }
            else
            {
                binary.Append(Convert.ToString(hexademical[i] - 65 + 10,2));
                isUsed = true;
            }
        }
        Console.WriteLine(binary);
    }
}

