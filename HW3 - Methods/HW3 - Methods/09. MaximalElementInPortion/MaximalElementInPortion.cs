﻿//09. Write a method that return the maximal element in
//a portion of array of integers starting at given index.
//Using it write another method that sorts an array in
//ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaximalElementInPortion
{
    static void Main()
    {
        int[] array = new int[] { 1, 5, 2, 5, 6, 77, 8, 3, 2, 10, -50, 6, 0 };
        int portionStartIndex = 5;
        int portionLength = 4;

        int maximalInThePortion = FindMaxInPortion(array, portionStartIndex, portionLength);
        Console.WriteLine(maximalInThePortion);
        SortDescending(array);
        PrintArray(array);
    }

    static int FindMaxInPortion(int[] arr, int start, int len)
    {
        int maximal = int.MinValue;
        int maximalIndex = 0;
        for (int i = start; i < start + len; i++)
        {
            if (arr[i] > maximal)
            {
                maximal = arr[i];
                maximalIndex = i;
            }
        }
        int temp = arr[maximalIndex];
        arr[maximalIndex] = arr[start];
        arr[start] = temp;
        return maximal;
    }

    static int[] SortDescending(int[] arr)
    {
        int maximalElement = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            maximalElement = FindMaxInPortion(arr, i, arr.Length - i);
            arr[i] = maximalElement;
            maximalElement = int.MinValue;
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}