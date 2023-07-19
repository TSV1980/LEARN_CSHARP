/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Random rnd = new Random();
//float N = 

Console.WriteLine("Введите количество рядов:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок:");
int N = Convert.ToInt32(Console.ReadLine());

float[,] MATRIX = new float[M, N];

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        MATRIX[i, j] = rnd.NextSingle() * 10.0f;
        Console.Write($"{MATRIX[i, j]:F2}");
        Console.Write($"   ");
    }
    Console.WriteLine();
}