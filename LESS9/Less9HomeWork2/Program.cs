/*
Задача 2:
Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.

Пример 1:
Исходный массив: [1, 2, 1, 1, 4]
Результат: 12115 (целое число).
Объяснение: если мы пройдем по элементам массива слева-направо, то последовательность элементов представляет из себя число 12004. Дальше мы плюсуем к этому числу 1 и получаем 12115

Пример 2:
Исходный массив: [1, 1, 2, 9]
Результат: 1130
Объяснение: если мы пройдем по массиву слева-направо, то получим число 1129. Прибавляем к данному числу 1 и получаем 1130.

Пример 3:
Исходный массив: [9]
Результат: 10.

*/

Console.WriteLine("Введите количество элементов:");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray();

PrintArray(array);

long val = CreateValue(array);

Console.WriteLine($"Число = {val}");
Console.ReadKey();



int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = rnd.Next(1, 9);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine($"]");
}

long CreateValue(int[] array)
{
    double res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] * Math.Pow(10, array.Length - i - 1);
    }

    res++;
    return Convert.ToInt64(res);
}
