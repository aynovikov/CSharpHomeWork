//Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу на C#, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[4];
        Random rand = new Random();

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] =rand.Next(100, 1000);
        }

        int evenCount = nums.Count(x=> x % 2 == 0);
        Console.WriteLine("Number of even numbers in the array: " 
        +evenCount);
    }
}