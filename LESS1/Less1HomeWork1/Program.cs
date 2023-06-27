/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число:");
string? num1str = Console.ReadLine();
Console.Write("Введите второе число:");
string? num2str = Console.ReadLine();

int num1, num2 = 0;
if (int.TryParse(num1str, out num1) && int.TryParse(num2str,out num2))
{
    if (num1 > num2)
        Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
    else if (num1 < num2)
        Console.WriteLine($"Первое число {num1} меньше второго числа {num2}");        
    else if (num1 == num2)
        Console.WriteLine($"Первое число {num1} равно второму числу {num2}");     
}




