/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

*/

Console.Write("Введите трехзначное число:");
string? num1str = Console.ReadLine();

int num1 = 0;
if (int.TryParse(num1str, out num1) && num1 >= 100 && num1 <= 999)
{
    Console.WriteLine($"Результат = {(num1 - ((num1 / 100)*100) - (num1 % 10))/10}.");    
}
else
{
    Console.WriteLine("Ошибка ввода числа.");
}
