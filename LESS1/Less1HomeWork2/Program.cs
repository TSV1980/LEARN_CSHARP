/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите три числа черел пробел:");
string nums = Console.ReadLine();


if (!string.IsNullOrEmpty(nums) && nums.Length > 0)
{
    string[] intnums = nums.Split(' ');
    int max = int.Parse(intnums[0]);
    for (int i = 1;i < intnums.Length; i++)
    {
        if (int.TryParse(intnums[i], out int currnum))
            if (currnum > max)
                max = currnum;
    }
    Console.Write("Максимальное число равно - " + max);
}