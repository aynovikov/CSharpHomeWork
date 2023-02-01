//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1
/*
using System;

class Program
{
    static void CountDown(int n)
    {
        if (n == 0)
            return;

        Console.Write(n + ", ");
        CountDown(n - 1);
    }

    static void Main(string[] args)
    {
        int N = 5;
        CountDown(N);
    }
}
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;

class Program
{
    static int SumNaturalNumbers(int m, int n)
    {
        if (m > n)
            return 0;

        return m + SumNaturalNumbers(m + 1, n);
    }

    static void Main(string[] args)
    {
        int M = 1;
        int N = 15;
        Console.WriteLine(SumNaturalNumbers(M, N));
    }
}


