/*
Задача 4:
Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.
Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при помощи встроенной функции. Необходимо сделать это самостоятельно.

Пример 1:
Входные значения: num1 = "11", num2 = "123"
Результат: "134"

Пример 2:
Входные значения: num1="456", num2 = "77"
Результат: "533"

Пример 3:
Входные значения: num1 = "0", num2 = "0"
Результат: "0"
*/


Console.WriteLine("Введите число 1:");
string NUM1 = Console.ReadLine();

Console.WriteLine("Введите число 2:");
string NUM2 = Console.ReadLine();


long N1 = CreateValue(NUM1);
long N2 = CreateValue(NUM2);


long RES = N1 + N2;
Console.WriteLine($"Результат = {RES.ToString()}");
Console.ReadLine();







long CreateValue(string array)
{
    double res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        byte c = Convert.ToByte(array[i].ToString());
        res += c * Math.Pow(10, array.Length - i - 1);
    }
    return Convert.ToInt64(res);
}