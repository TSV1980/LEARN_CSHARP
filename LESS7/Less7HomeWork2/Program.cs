/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите количество рядов:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок:");
int N = Convert.ToInt32(Console.ReadLine());

float[,] matrix = GenerateMatrix(M, N);

Console.WriteLine("Введите номер элемента для поиска:");
int postofind = Convert.ToInt32(Console.ReadLine());

ReturnElement(postofind, matrix);



float[,] GenerateMatrix(int M, int N)
{
    
    Random rnd = new Random();
    //float N = 



    float[,] matrix = new float[M, N];

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            matrix[i, j] = rnd.NextSingle() * 10.0f;
            Console.Write($"{matrix[i, j]:F2}");
            Console.Write($"   ");
        }
        Console.WriteLine();
    }

    return matrix;
}

float ReturnElement(int pos, float[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);

    if (pos < 0 || pos > row * col)
    {
        Console.WriteLine($"В массиве нет данного элемента");
        return 0;
    }

    pos--;
    
    int posinrow = pos % col;

    float el = matrix[pos / col, posinrow];

    Console.WriteLine($"Найденный элемент = {el:F2}");

    return el;
}