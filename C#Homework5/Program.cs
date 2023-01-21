//Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
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

//Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        int[] nums = Enumerable.Repeat(0, 4)
                              .Select(i => random.Next(-10, 10))
                              .ToArray();
        Console.WriteLine(string.Join(",", nums));

        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += nums[i];
            }
        }
        Console.WriteLine(sum);

    }
}
//Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] nums = { 3.0, 7.0, 22.0, 2.0, 78.0 };
        Console.WriteLine(string.Join(",", nums));

        double max = nums.Max();
        double min = nums.Min();
        double diff = max - min;
        Console.WriteLine(diff);
    }
}
