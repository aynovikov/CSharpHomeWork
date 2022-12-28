//Задача 19 Напишите программу на c#, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

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