﻿//06. Write a method that returns the index of the first
//element in array that is bigger than its neighbors, or
//-1, if there’s no such element.
// Use the method from the previous exercise.

using System;

class IndexOfBiggerThanNeighbors
{
    static bool IsInside(int[] arr, int i)
    {
        return 0 <= i && i < arr.Length;
    }

    static bool IsBigger(int[] arr, int i, int j)
    {
        return IsInside(arr, j) ? arr[i] > arr[j] : true;
    }

    static bool IsBiggerThanNeighbours(int[] arr, int i)
    {
        return IsBigger(arr, i, i - 1) && IsBigger(arr, i, i + 1);
    }

    // Linear scan
    static int GetElementBiggerThanNeighbours(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            if (IsBiggerThanNeighbours(arr, i)) return i;

        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 2, 2, 9, 2, 2, 2 };

        Console.WriteLine(GetElementBiggerThanNeighbours(arr));
    }
}