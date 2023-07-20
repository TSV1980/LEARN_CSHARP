/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine("Введите количество рядов и колонок:");
int num = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = GenerateMatrix(num);
int[,] matrix2 = GenerateMatrix(num);

Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);

Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

int[,] result = MultiplyMatrix(matrix1, matrix2);

Console.WriteLine("Результат умножения двух матриц:");
PrintMatrix(result);

int[,] GenerateMatrix(int M)
{
    Random rnd = new Random();
    int[,] matrix = new int[M, M];

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < M; j++)
        {
            matrix[i, j] = rnd.Next(1,10);
            //Console.Write($"{matrix[i, j]:D2}");
            //Console.Write($"   ");
        }
        //Console.WriteLine();
    }
    return matrix;
}

int[,] MultiplyMatrix(int[,] m1, int[,] m2)
{
    if (m1.GetLength(1) == m1.GetLength(0) && m2.GetLength(0) == m2.GetLength(1) && m1.GetLength(1) == m2.GetLength(1))
    {
        int[,] res = new int[m1.GetLength(0), m1.GetLength(0)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < m2.GetLength(1); j++)
            {
                for (int k = 0; k < m2.GetLength(0); k++)
                {
                    res[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }
        return res;
    }
    else
    {
        throw new Exception("Матрицы нельзя перемножить");
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
