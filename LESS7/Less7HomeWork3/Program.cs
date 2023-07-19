/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/




Console.WriteLine("Введите количество рядов:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колонок:");
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GenerateMatrix(M, N);

Console.WriteLine();
CalcAVG(matrix);


int[,] GenerateMatrix(int M, int N)
{
    Random rnd = new Random();
    int[,] matrix = new int[M, N];

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            matrix[i, j] = rnd.Next(1,10);
            Console.Write($"{matrix[i, j]:F2}");
            Console.Write($"   ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void CalcAVG(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);

    float[] avg = new float[col];

    for (int j = 0; j < col; j++)
    {
        avg[j] = 0;
        for (int i = 0; i < row; i++)
        {
            avg[j] += matrix[i, j];
        }

        avg[j] = avg[j] / (float)row;

        Console.Write($"{avg[j]:F2}");
        Console.Write($"   ");
    }
}