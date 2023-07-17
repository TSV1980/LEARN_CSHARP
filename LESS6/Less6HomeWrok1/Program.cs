/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int EnterNumOfDigits()
{
    Console.WriteLine("Введите количество чисел:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] EnterDigits(int num)
{
    int[] digits = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число №{i+1}:");
        digits[i] = Convert.ToInt32(Console.ReadLine());
    }
    return digits;
}

int FindNumOfPositive(int[] digits)
{
    int posnum = 0;
    for (int i = 0;i < digits.Length;i++)
    {
        if (digits[i] > 0) 
            posnum ++;
    }
    return posnum;
}

int M = EnterNumOfDigits();
int[] NUMS = EnterDigits(M);
Console.WriteLine($"Число положительных чисел = {FindNumOfPositive(NUMS)}");