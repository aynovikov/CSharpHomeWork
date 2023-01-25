﻿//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3



int count = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Enter a number:");
    int num = int.Parse(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine("Number of numbers greater than 0: " + count);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1, b1, k2, b2;
Console.WriteLine("Enter the value of k1:");
k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of b1:");
b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of k2:");
k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of b2:");
b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine("The point of intersection is at: (" + x + "," + y + ")");

