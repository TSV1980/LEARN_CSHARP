/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число:");
string? num1str = Console.ReadLine();

 

if (int.TryParse(num1str, out int num2))
{
    int[] ints= new int[num1str.Length];

    int rest = 0, index = 0;
    while (num2 > 0)
    {
        rest = num2 % 10;
        ints[index] = rest; index ++;

        num2 = num2 / 10;
        Console.WriteLine($" Цифра {index} = {rest}");
    } 

    int summ = 0;
    for (int i = 0;i < ints.Length;i++)
    {
        summ += ints[i];
    }
    Console.WriteLine($" Сумма цифр равна {summ}.");

}
