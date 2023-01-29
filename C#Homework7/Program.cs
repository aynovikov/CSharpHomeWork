﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

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
