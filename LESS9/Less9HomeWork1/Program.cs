/*

Задача 1.
Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
Ваша задача вывести на экран максимальное количество следующих друг за другом 1.

Пример 1:
Исходный массив: [1, 1, 0, 1, 1, 1]
Результат: 3
Объяснение: в данном массиве две последовательности из 1: первые две единицы в самом начале и последние три единица в конце. Максимальное количество единиц в этих последовательностях 3.

Пример 2:
Исходный массив: [1, 0, 1, 1, 0, 1]
Результат: 2

Пример 3:
Исходный массив: [1, 0, 1, 0, 0, 0, 1]
Результат: 0
Объяснение: в массиве нет следующих друг за другом единиц.

*/

Console.WriteLine("Введите количество элементов:");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray();

PrintArray(array);

List<ElementsAndPos> elements = FindOneNums(array);

PrintElements(elements);

FindMaxNums(elements);

Console.ReadKey();






void FindMaxNums(List<ElementsAndPos> elements)
{
    int maxEL = elements.Max(num => num.NumOfOnes);
    if (maxEL >= 2)
    {
        var maxNum = elements.Find(el => el.NumOfOnes == maxEL);
        Console.WriteLine($"Максимальное количество единиц - {maxNum.NumOfOnes} - находятся на позиции - {maxNum.Pos}");
    }
    else
    {
        Console.WriteLine($"В массиве нет следующих друг за другом единиц");
    }
}




List<ElementsAndPos> FindOneNums(int[] array)
{
    List<ElementsAndPos> elements = new List<ElementsAndPos>();

    ElementsAndPos newEl = new ElementsAndPos() { NumOfOnes = 0, Pos = 0, Find = false};
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 1 && !newEl.Find)
        {
            newEl.Find = true;
            newEl.Pos = i;
            newEl.NumOfOnes++;  
        }
        else if (array[i] == 1 && newEl.Find)
        {
            newEl.NumOfOnes++;

            if (array[i] == 1 && newEl.Find && i == array.Length - 1)
            {
                elements.Add(newEl);
                newEl = new ElementsAndPos() { NumOfOnes = 0, Pos = 0, Find = false };
            }
        }
        else if (array[i] == 0 && newEl.Find)
        {
            elements.Add(newEl);
            newEl = new ElementsAndPos() { NumOfOnes = 0, Pos = 0, Find = false };
        }
         


    }

    return elements;
}

void PrintElements(List<ElementsAndPos> elements)
{
    Console.WriteLine("Элементы:");
    foreach (ElementsAndPos elementsAndPos in elements)
    {
        Console.WriteLine($"El:Позиция-{elementsAndPos.Pos}.Количество-{elementsAndPos.NumOfOnes}");
    }
}



int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        if (rnd.NextSingle() < 0.5) array[i] = 0;
        else array[i] = 1;
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine($"]");
}

struct ElementsAndPos
{
    public int Pos { get; set; }

    public int NumOfOnes { get; set; }

    public bool Find { get; set; }
}