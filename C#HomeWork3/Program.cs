//Задача 19 Напишите программу на c#, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
/*
namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a five-digit number:");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPalindrome = IsPalindrome(num);
            if (isPalindrome)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }

        static bool IsPalindrome(int num)
        {
            // Convert the number to a string and check if it is the same forwards and backwards
            return num.ToString() == ReverseString(num.ToString());
        }

        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

*/
//Напишите программу на С#, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("\n Task #21");

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Input coordinate {coorName} point {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double DistXYZ(double x1, double x2,
               double y1, double y2,
               double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}


double distXYZ = Math.Round(DistXYZ(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Distance between point : {distXYZ}");