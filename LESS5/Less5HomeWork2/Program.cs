/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/


Random rnd = new Random();
int L = rnd.Next(4,12);
Console.WriteLine($"L={L}");
int[] ints = new int[L];

for (int i = 0; i < L; i++)
{
    ints[i] = rnd.Next(1,99);
}
ARRToScreen(ref ints);

int summ = 0;
for (int i = 1; i < L; i+=2)
{
    summ += ints[i];
}
Console.WriteLine($"Сумау элементов, стоящих на нечётных позициях равна  {summ}");






static string ARRToScreen(ref int[] array)
{
        string res = "[";
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString();
            if (i < array.Length-1) res += ", ";
        }
        res += "]";
        Console.WriteLine(res);
        return res;
}

