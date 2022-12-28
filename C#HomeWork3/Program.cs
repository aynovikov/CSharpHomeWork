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
Напишите программу на С#, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

namespace DistanceCalculator
{
class Program
{
static void Main(string[] args)
{
// Define the coordinates of the two points
Point A = new Point(3, 6, 8);
Point B = new Point(2, 1, -7);
        // Calculate the distance between the two points
        double distance = CalculateDistance(A, B);
        Console.WriteLine("The distance between A and B is " + distance);
    }

    static double CalculateDistance(Point a, Point b)
    {
        // Calculate the distance using the distance formula
        double dx = a.X - b.X;
        double dy = a.Y - b.Y;
        double dz = a.Z - b.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}

// Define a Point class to represent the coordinates of a point in 3D space
class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
}
