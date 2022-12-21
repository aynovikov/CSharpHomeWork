/*Задача №10 Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input three-digit number");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine() ?? "");
string stringNumber = Convert.ToString(ThreeDigitNumber);
Console.WriteLine ("Second digit of this number is " +stringNumber[1]);
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Input number");
int a = Convert.ToInt32(Console.Readline() ?? "");

if ((a<=100) && (a<= 999))
{
    Console.Writeline($"Third digit is ( a % 10");
}
else if (a<100)
{
    Console.WriteLine("There is no third digit")
}
else if (a > 999)
{
    Console.WriteLine("It is not a three digit number")
}