//03. Write a method that returns the last digit of given
//integer as an English word. Examples: 512 "two",
//1024 "four", 12309 "nine".


using System;

class LastIntegerMethod

{
    private static void LastInteger(int number)
    {
        string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", };
        int lastDigit = Math.Abs(number % 10);
        Console.WriteLine(digitNames[lastDigit]);
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        LastInteger(number);
    }

}

