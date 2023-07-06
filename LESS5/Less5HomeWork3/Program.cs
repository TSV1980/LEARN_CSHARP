/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/



Random rnd = new Random();
int L = rnd.Next(4,12);
Console.WriteLine($"L={L}");
float[] floatNums = new float[L];

for (int i = 0; i < L; i++)
{
    floatNums[i] = rnd.NextSingle() * 100.0f;
}
ARRToScreen(ref floatNums);


float min = 100, max = 0, delta = 0;
for (int i = 0; i < L; i++)
{
    if (floatNums[i] > max) max = floatNums[i];
    if (floatNums[i] < min) min = floatNums[i];
    delta = max - min;
}   
Console.WriteLine($" Max = {max:F2}. Min = {min:F2}. Разница между max и min = {delta:F2}");


static string ARRToScreen(ref float[] array)
{
        string res = "[";
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString("F2");
            if (i < array.Length-1) res += "; ";
        }
        res += "]";
        Console.WriteLine(res);
        return res;
}


