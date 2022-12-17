/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, a = 2 b = 10 -> max = 10, a = -9 b = -3 -> max = -3
Console.Write("Input value a=");
int numA = Convert.ToInt32(Console.ReadLine() ??"");
Console.Write("Input value b=");
int numB = Convert.ToInt32(Console.ReadLine() ??"");

if (numA > numB)
{
   Console.WriteLine($"max = {numA}");
}
else if (numA == numB)
{
   Console.WriteLine($"{numA} = {numB}"); 
}
else
{
    Console.WriteLine($"max = {numB}");
}

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7, 44 5 78 -> 78, 22 3 9 -> 22

Console.WriteLine("Input number a=");
int a = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number b=");
int b = Convert.ToInt32(Console.ReadLine() ??"");
Console.WriteLine("Input number c=");
int c = Convert.ToInt32(Console.ReadLine() ??"");
int max = 0;
max = a;
if ((b>a) & (b>c))
{
    Console.WriteLine($"max={b}");
}
else if ((c > b) & (c >a ))
{
    Console.WriteLine($"max = {c}");
}
else
{
    Console.WriteLine($"max= {a}");
}

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да,-3 -> нет,
7 -> нет

Console.WriteLine("Input number a=");
int a = Convert.ToInt32(Console.ReadLine( ) ??"");
if (a % 2 == 0)
{
    Console.WriteLine($"Value ({a}) is even number. ");
}
else
{
    Console.WriteLine($"Value({a}) is odd number.");    
}

Задача 4: Напишите программу, которая на вход принимает 
число (N), а на выходе показывает все чётные числа 
от 1 до N. 5 -> 2, 4  &   8 -> 2, 4, 6, 8
*/

Console.WriteLine("Input of value N");
int n = Convert.ToInt32(Console.ReadLine() ??"");
Console.Write($"List of even numbers in between 0 .... {n}:");
for (int i = (1); i <= n; i+=1 )
if (i % 2 == 0 )
{
    Console.Write($" {i} ");
}