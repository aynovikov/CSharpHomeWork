//Task 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

/*int A, B;
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

Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int num;
int sum =0;

Console.WriteLine ("Enter a number: ");
num = int.Parse( Console.ReadLine());

while (num > 0)
{
    sum += num % 10;
    num /= 10;
}

Console.WriteLine ("Sum of digits: " + sum);