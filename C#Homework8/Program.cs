//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
/*
int[,] array = new int[3,4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
for (int i = 0; i < array.GetLength(0); i++)
{
    Array.Sort(array, i * array.GetLength(1), array.GetLength(1), new Comparison<int>((a, b) => b.CompareTo(a)));
}
*/
int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

for (int i = 0; i < array.GetLength(0); i++)
{
    Array.Sort(array, i * array.GetLength(1), array.GetLength(1), Comparer<int>.Create((x, y) => y - x));
}
