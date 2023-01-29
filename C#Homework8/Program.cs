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



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
*/
int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };

int rows1 = matrix1.GetLength(0);
int cols1 = matrix1.GetLength(1);
int rows2 = matrix2.GetLength(0);
int cols2 = matrix2.GetLength(1);

if (cols1 != rows2)
{
    Console.WriteLine("Error: The number of columns of the first matrix must be equal to the number of rows of the second matrix.");
    return;
}

int[,] resultMatrix = new int[rows1, cols2];

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        int sum = 0;
        for (int k = 0; k < cols1; k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }
        resultMatrix[i, j] = sum;
    }
}

Console.WriteLine("Result matrix:");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(resultMatrix[i, j] + " ");
    }
    Console.WriteLine();
}
