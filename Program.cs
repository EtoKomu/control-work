using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program  
{
    static void Main()
    {
        
    }

    static string[] filterArray(string[] array)
    {
        List<string> filteredList = new List<string> {};
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                filteredList.Add(array[i]);
            }
        }
        string[] filteredArray = filteredList.ToArray<string>();
        return filteredArray;
    }
    static void printArray(string[] array)
    {
        System.Console.Write("[");
        for (int i = 0; i < array.Length-1; i++)
        {
            System.Console.Write($"{array[i]}, ");
        }
        System.Console.Write($"{array[array.Length-1]}]");
    }
}