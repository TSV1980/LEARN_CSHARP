/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

bool workAlways = true;

while (workAlways)
{
    Console.WriteLine("Введите два целых числа через пробел: A и B. Или нажмите Q для выхода.");
    string str = Console.ReadLine();
    if (!string.IsNullOrEmpty(str))
    {
        if (str != "Q")
        {
            string[] res = str.Split();
            if (res.Length == 2 && int.TryParse(res[0], out int A) && int.TryParse(res[1], out int B))
            {
                Console.WriteLine($"Возводим {A} в степень {B}. Результат = {Math.Pow(A,B)}");
            }
        }
        else
        {
            Console.WriteLine($"Работа программы завершена.");
            workAlways = false;
            break;
        }
    } 
}
