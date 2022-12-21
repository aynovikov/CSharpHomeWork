/*Задача №10 Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input three-digit number");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine() ?? "");
string stringNumber = Convert.ToString(ThreeDigitNumber);
Console.WriteLine ("Second digit of this number is " +stringNumber[1]);
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Input a number");
int anyNumber = Convert.ToInt32(Console.Readline() ??"");
string anyNumber = Convert.ToInt32(Console.Readline());
if (anyNumber.Lenght > 2)
{
    Console.WriteLine("Third digit is" + AnyNumber[2]);
}
else
{
    Console.WriteLine(" There is no thirg digit");
}
