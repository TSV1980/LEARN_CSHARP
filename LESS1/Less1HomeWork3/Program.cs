/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> не
*/

Console.Write("Введите первое число:");
string? num1str = Console.ReadLine();

int num1 = 0;
if (int.TryParse(num1str, out num1))
{
    if (num1 % 2 == 0)
    {
        Console.Write("Число чётное");
    }
    else
    {
        Console.Write("Число нечётное");
    }
}
