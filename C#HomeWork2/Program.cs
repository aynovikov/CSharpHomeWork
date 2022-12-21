//Задача №10 Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input three-digit number");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine() ?? "");
string stringNumber = Convert.ToString(ThreeDigitNumber);
Console.WriteLine ("Second digit of this number is " +stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Input a number ");
int a = Convert.ToInt32(Console.ReadLine() ?? "");

if ((a >= 100) && (a <= 999))
{
    Console.WriteLine($"Third digit is {a % 10} ");
}
else if (a < 100)
{
    Console.WriteLine("There is no third digit");
}
else if (a > 999)
{
    Console.WriteLine("It is not a three-digit number");
}

// Задача 15:__
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
 
 

int NumberWeek(string message)
{ 
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 8)
        {
            return result; 
        }
        else
        {
            Console.WriteLine("Wrong input. Please input a number from 1 to 7");
        }
    }

}

void numberWeek1(int NumWeek)
{
    if (Math.Abs(NumWeek) <= 5)
    {
        Console.Write("This is a Weekday");
    }
    else if ((NumWeek == 6) || (NumWeek == 7))
    {
        Console.WriteLine("This is a Day Off");
    }
}
int number = NumberWeek("Enter number of the Weekday");
numberWeek1(number);