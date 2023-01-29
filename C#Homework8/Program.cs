//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

/*
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int[] row = new int[arr.GetLength(1)];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                row[j] = arr[i, j];
            }
            Array.Sort(row);
            Array.Reverse(row);
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = row[j];
            }
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
using System;
class MainClass 
{
  public static void Main (string[] args) 
  {
    int[,] arr = { {1, 4, 7, 2},
                  {5, 9, 2, 3},
                  {8, 4, 2, 4},
                  {5, 2, 6, 7} };

    int minRow = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < arr.GetLength(0); i++) 
    {
      int sum = 0;
      for (int j = 0; j < arr.GetLength(1); j++) 
      {
        sum += arr[i, j];
      }

      if (sum < minSum) 
      {
        minSum = sum;
        minRow = i;
      }
    }

    Console.WriteLine("The row with the smallest sum is row " + minRow + " with a sum of " + minSum);
  }
}

