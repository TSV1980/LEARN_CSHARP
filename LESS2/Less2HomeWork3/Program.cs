/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


Console.Write("Введите число:");
string? num1str = Console.ReadLine();

int num1 = 0;

if (int.TryParse(num1str, out num1) && num1 >= 1 && num1 <= 7)
{
    if (num1  == 6 || num1 == 7)
    {
        Console.WriteLine("Введенный номер дня - выходной.");
    }
    else
    {
        Console.WriteLine("Введенный номер дня - НЕ выходной.");
    }
}
else
{
    Console.WriteLine("Ошибка ввода дня недели.");
}