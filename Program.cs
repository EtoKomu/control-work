// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program  
{
    static void Main()
    {
        string[] array = ["peepo", "135", "rebyata", "9", "che"];
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