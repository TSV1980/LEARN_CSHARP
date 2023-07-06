/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*/

Random rnd = new Random();
int L = rnd.Next(4,12);
Console.WriteLine($"L={L}");
int[] ints = new int[L];
int numofodd = 0;
for (int i = 0; i < L; i++)
{
    ints[i] = rnd.Next(100,999);
    if (ints[i] % 2 == 0)
        numofodd ++;
}
ARRToScreen(ref ints);
Console.WriteLine($"Количество чётных чисел равно {numofodd}");





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
