/*

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/
Console.Write("Введите число:");
string? num1str = Console.ReadLine();
if (int.TryParse(num1str, out int num2))
    Console.WriteLine($"Последовательность кубов для числа {num2} = {GetCubes(num2)}");



static string GetCubes(int num)
{
    string res = "";
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, 3);
        if (i != num)
            res += ", ";
    }
    return res;
}