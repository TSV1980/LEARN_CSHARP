using System;
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


Console.WriteLine("Введите количество рядов и колонок:");
int M = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GenerateMatrix(M, M);

Console.WriteLine();



Console.WriteLine("РЕЗУЛЬТАТ:");

//PrintMatrix(matrix);

SumRow(matrix);



int[,] GenerateMatrix(int M, int N)
{
    Random rnd = new Random();
    int[,] matrix = new int[M, N];

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            matrix[i, j] = rnd.Next(1,20);
            Console.Write($"{matrix[i, j]:D2}");
            Console.Write($"   ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintMatrix(int[,] matrixparam)
{
    int M = matrixparam.GetLength(0);
    int N = matrixparam.GetLength(1);

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write($"{matrix[i, j]:D2}");
            Console.Write($"   ");
        }
        Console.WriteLine();
    }
}

void SumRow(int[,] matrixparam)
{
    int numOfMinRow = -1;
    int minSumOfRows = 99;

    int M = matrixparam.GetLength(0);
    int N = matrixparam.GetLength(1);

    int[] sums = new int[M];

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            sums[i] += matrixparam[i, j];
        }
        if (sums[i] < minSumOfRows)
        {
            minSumOfRows = sums[i];
            numOfMinRow = i + 1;
        }
    }

    Console.WriteLine("Суммы Строк:");
    for (int i = 0;i < M; i ++ )
    {
        Console.WriteLine($"{sums[i]:D2}   ");
    }

    Console.WriteLine($"Строка с минимальной суммой: {numOfMinRow}");
}
