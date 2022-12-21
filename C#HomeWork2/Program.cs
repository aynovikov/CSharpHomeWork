//Задача №10 Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input three-digit number");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine() ?? "");
string stringNumber = Convert.ToString(ThreeDigitNumber);
Console.WriteLine ("Second digit of this number is " +stringNumber[1]);