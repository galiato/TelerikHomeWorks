using System;
using System.Collections.Generic;
using System.Diagnostics;

class Factoriel
{
    static List<int> AddingLists(List<int> shorter, List<int> longer)
    {

        List<int> result = new List<int>();
        shorter.Reverse();
        longer.Reverse();
        int tempNum = 0;
        // adding the lists digit by digit and saving the reminder for the next digit
        //repeating the same thing till the shorter array is over
        for (int i = 0; i < shorter.Count; i++)
        {
            result.Add((shorter[i] + longer[i] + tempNum) % 10);
            tempNum = (shorter[i] + longer[i] + tempNum) / 10;
        }

        // starting from the last element of the shorter list plus one
        //and adding it with the reminder if there is any
        for (int i = shorter.Count; i < longer.Count; i++)
        {
            result.Add((longer[i] + tempNum) % 10);
            tempNum = (longer[i] + tempNum) / 10;
        }

        //special case if we have reached the end of the longer array and we still have a reminder
        if (tempNum > 0)
        {
            result.Add(tempNum);
        }
        result.Reverse();
        return result;
    }

    static List<int> ListByNumber(int[] array, int number)
    {
        List<int> result = new List<int>();
        int temp = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            result.Add((number * array[i] + temp) % 10);
            temp = (number * array[i]) / 10;
        }

        if (temp > 0)
        {
            result.Add(temp);
        }
        result.Reverse();
        return result;
    }
    static List<int> MultiplyingArrays(int[] first, int[] second)
    {
        //doing the multiplication old school style, like you would do it on a paper
        List<int> result = new List<int>();
        List<List<int>> temp = new List<List<int>>();
        for (int i = first.Length - 1, listNum = 0; i >= 0; i--, listNum++)
        {
            temp.Add(ListByNumber(second, first[i]));
            for (int zeroes = first.Length - 1; zeroes > i; zeroes--)
            {
                temp[listNum].Add(0);
            }
        }
        if (temp.Count > 1)
        {
            for (int i = 0; i < temp.Count - 1; i++)
            {

                result = AddingLists(temp[i], temp[i + 1]);
                temp[i + 1] = result;
            }

            return result;
        }
        else
        {
            return temp[0];
        }
    }

    static int[] ToCharArray(int num)
    {
        string stringNum = num.ToString();
        int[] result = new int[stringNum.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = stringNum[i] - '0';
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a number to see it's factoriel(and preceding factoriels): ");
        int number = int.Parse(Console.ReadLine());
        Stopwatch sw = new Stopwatch();
        sw.Start();
        List<int> result = new List<int>();
        int[] temp1 = { 1 };
        for (int i = 1; i <= number; i++)
        {
            //using the method ToCharArray to convert the number to array of digits
            int[] temp2 = ToCharArray(i);
            result = MultiplyingArrays(temp2, temp1);
            temp1 = result.ToArray();
            Console.WriteLine(string.Join("", result));
        }
        sw.Stop();
        //printing the elapsed time for the program
        Console.WriteLine("The factoriel is calculated and printed for {0}", sw.Elapsed);
    }
}