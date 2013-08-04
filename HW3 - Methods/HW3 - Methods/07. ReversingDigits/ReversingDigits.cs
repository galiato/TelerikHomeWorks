//07. Write a method that reverses the digits of given
//decimal number. Example: 256 652

using System;

class ReversingDigits
{
    static void ReverseTheDigits(decimal number)
    {
        string reversed = number.ToString();

        char[] charArray = reversed.ToCharArray();
        Array.Reverse(charArray);
        new string(charArray);
        Console.WriteLine("The reversed number is:");
        Console.WriteLine(charArray);
    }


    static void Main()
    {
        Console.WriteLine("Write a decimal number for convertion:");
        decimal number = decimal.Parse(Console.ReadLine());
        ReverseTheDigits(number);
    }
}