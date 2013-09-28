//  Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class BinToHec
{
    static void Main()
    {
        Console.Write("Enter the binary number : ");
        string binary = Console.ReadLine();
        ConvertToHexadecimal(binary);
    }

    static void ConvertToHexadecimal(string binary)
    {
        StringBuilder hex= new StringBuilder();
        StringBuilder hexadecimalNum = new StringBuilder();
        int counter = 0;
        int counter1 = 4;
        for (int i = 0; i < binary.Length/4 + binary.Length%4; i++,counter+=4)
        {
            if (i==binary.Length/4-1)
            {
                counter1 = binary.Length % 4;
                if (binary.Length%4==0)
                {
                    counter1 = 4;
                }
            }
            for (int j = counter; j < counter+counter1; j++)
			{
                hex.Append(binary[binary.Length - j - 1].ToString());
			}
            StringBuilder tempHex = new StringBuilder(Reverse(hex));
            if (int.Parse(Convert.ToInt32(tempHex.ToString(), 2).ToString()) < 10)
            {
                hexadecimalNum.Append(Convert.ToInt32(tempHex.ToString(), 2).ToString());
            }
            else
            {
                hexadecimalNum.Append((char)((int.Parse(Convert.ToInt32(tempHex.ToString(), 2).ToString()) % 10 + 65))).ToString();
            }
            hex.Clear();
        }
        Console.WriteLine(Reverse(hexadecimalNum));
    }

    public static string Reverse(StringBuilder hecNum)
    {
        char[] charArray = hecNum.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

