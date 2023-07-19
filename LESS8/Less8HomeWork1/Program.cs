/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Console.WriteLine("Введите количество рядов:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок:");
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GenerateMatrix(M, N);

Console.WriteLine();

SortMatrix(matrix);

Console.WriteLine("РЕЗУЛЬТАТ:");

PrintMatrix(matrix);



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


void SortMatrix(int[,] matrixparam)
{
    if (matrixparam == null) throw new ArgumentNullException(nameof(matrixparam));

    if (matrixparam.Length == 0)
        throw new ArgumentException("Value cannot be an empty collection.", nameof(matrixparam));

    int row = matrixparam.GetLength(0);
    int col = matrixparam.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        bool sort = false;
        while (!sort)
        {
            bool change = false;
            for (int j = 0; j < col - 1; j++)
            {
                if (matrixparam[i, j] < matrixparam[i, j + 1])
                {
                    (matrixparam[i, j], matrixparam[i, j + 1]) = (matrixparam[i, j + 1], matrixparam[i, j]);
                    change = true;
                }
            }
            if (!change) sort = true;
        }
    }
}
