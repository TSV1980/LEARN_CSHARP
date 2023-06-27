/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число N:");
string? num1str = Console.ReadLine();

int num1 = 0;
if (int.TryParse(num1str, out num1))
{
    if (num1 >= 2)
    {
        for (int i = 2; i <= num1; i+=2)
        {
            Console.Write($" {i}");
        }
    }
}