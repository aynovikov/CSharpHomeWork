﻿//Task 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int A, B;
int result = 1;

Console.WriteLine ("Enter base number: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter exponent: ");
B = int.Parse(Console.ReadLine());

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine("Result: " +result);