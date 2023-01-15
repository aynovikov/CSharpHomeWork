//Task 25 Напишите цикл для C#, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int A, B;
int result = 1;

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine(result);