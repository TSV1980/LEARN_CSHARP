/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Write("Введите число:");
string? num1str = Console.ReadLine();

int num1, div1 = 0;
int result = -1;
if (int.TryParse(num1str, out num1))
{
    while (num1 > 10)
    {
        div1 = num1 % 10;
        Console.WriteLine($"{div1}");
        num1 = num1 / 10;
        Console.WriteLine($"{num1}");

        if (num1 >= 11 && num1 <= 99)
        {
            result = div1;
        }
    }

    if (result >= 0)
    {
        Console.WriteLine($"Третья цифра = {result}");
    }
    else
    {
        Console.WriteLine($"Третьей цифры нет.");
    }
}
