//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
using System;
using System.Linq;

class Program
{
static void Main()
{
int m = 3, n = 4;
var rand = new Random();
double[,] arr = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.NextDouble();
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
}

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> числа с такими индексами в массиве нет

using System;

class Program
{
static void Main()
{
int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int m = arr.GetLength(0);
int n = arr.GetLength(1);
    Console.Write("Enter row index: ");
    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter column index: ");
    int col = int.Parse(Console.ReadLine());

    if (row < 0 || row >= m || col < 0 || col >= n)
    {
        Console.WriteLine("No such element in array.");
    }
    else
    {
        Console.WriteLine("Element at index (" + row + ", " + col + ") is: " + arr[row, col]);
    }
}
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
using System;

class Program
{
static void Main()
{
int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int m = arr.GetLength(0);
int n = arr.GetLength(1);
    for (int col = 0; col < n; col++)
    {
        double sum = 0;
        for (int row = 0; row < m; row++)
        {
            sum += arr[row, col];
        }
        double average = sum / m;
        Console.WriteLine("Column {0} average: {1:F1}", col, average);
    }
}
}