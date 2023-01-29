using System;
using System.Linq;

class Program
{
static void Main()
{
int m = 3, n = 4;
var rand = new Random();
double[,] arr = new double[m, n];

css
Copy code
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.NextDouble();
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
