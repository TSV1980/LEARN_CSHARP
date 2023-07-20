/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


Console.WriteLine("Введите размерность матрицы:");
int N = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = new int[N, N];

FillMatrix(resMatrix);

Console.WriteLine("Результат:");
PrintMatrix(resMatrix);

void FillMatrix(int[,] matrix)
{
    int startvalue = 1;
    int i = 0;
    int j = 0;

    while (startvalue <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = startvalue;
        startvalue++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}



void PrintMatrix(int[,] matrixparam)
{
    int M = matrixparam.GetLength(0);
    int N = matrixparam.GetLength(1);

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write($"{matrixparam[i, j]:D2}");
            Console.Write($"   ");
        }
        Console.WriteLine();
    }
}