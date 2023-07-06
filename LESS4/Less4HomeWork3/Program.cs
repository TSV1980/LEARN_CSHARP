/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


MyArray array = new MyArray();
array.AddString("1, 2, 5, 7, 19");
Console.WriteLine(array.ToScreen());


array.AddString("6, 1, 33");
Console.WriteLine(array.ToScreen());

MyArray array2 = new MyArray();
array2.AddString("6, 1, 33");
Console.WriteLine(array2.ToScreen());








public class MyArray
{
    public int[] array;

    public MyArray()
    {
        array = new int[0];
    }

    public void AddElement(int value)
    {
        Array.Resize(ref array, array.Length+1);
        array[array.Length-1] = value;
    }

    public void AddString(string values)
    {
        string[] vals = values.Split(',');
        for (int i = 0; i < vals.Length; i++)
        {
            if (int.TryParse(vals[i], out int arrayelement))
                AddElement(arrayelement);
        } 
    }

    public string ToScreen()
    {
        string res = "[";
        for (int i = 0; i < array.Length; i++)
        {
            res += array[i].ToString();
            if (i < array.Length-1) res += ", ";
        }
        res += "]";
        return res;
    }
}