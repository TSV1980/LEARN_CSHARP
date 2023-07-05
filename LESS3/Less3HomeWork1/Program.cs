/*
Урок 3. Базовые алгоритмы. Продолжение
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/





Console
.Write("Введите число:");
string? num1str = Console.ReadLine();

int num1 = 0, dig = 0, rev = 0, temp = 0;
if (int.TryParse(num1str, out num1))
{
    temp = num1;
    while (num1 > 0)
    {
        dig = num1 % 10;         // берем последнюю цифру числа
        rev = rev * 10 + dig; // формируем число, где последняя цифра формируется с начала
        num1 = num1 / 10;           // уменьшаем на это число
        Console.WriteLine($"dig = {dig} rev = {rev} n = {num1}"); 
    }

    if (temp == rev)
        Console.WriteLine("Это палиндром!"); 
    else
       Console.WriteLine("Это не палиндром!");
}
else
Console.WriteLine("Ошибка преобразования");
