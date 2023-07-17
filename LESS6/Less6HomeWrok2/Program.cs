/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.WriteLine($"Задание линии №1");
Line L1 = new Line();
L1.EnterValues();
Console.WriteLine($"Линия №1 -> {L1.ToString()}");

Console.WriteLine($"Задание линии №2");
Line L2 = new Line();
L2.EnterValues();
Console.WriteLine($"Линия №2 -> {L2.ToString()}");

Intersection intersection = new Intersection();
intersection.L1 = L1;
intersection.L2 = L2;   
intersection.FindIntersectionPoint();






public class Line
{
    /// <summary>
    /// Коэффициент К
    /// </summary>
    /// <value></value>
    public int K { get; set;}

    /// <summary>
    /// Коэффициент B
    /// </summary>
    /// <value></value>
    public int B { get; set;}

    public Line(int K, int B)
    {
        this.K = K;
        this.B = B;
    }

    public Line()
    {
        this.K = 1;
        this.B = 1;
    }


    public void EnterValues()
    {
        Console.WriteLine("Введите коэффициент К:");
        this.K = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите коэффициент B:");
        this.K = Convert.ToInt32(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"Y = {K}x + {B}";
    }
}



public class Intersection
{
    public Line L1 { get; set; }

    public Line L2 { get; set;} 

    public void FindIntersectionPoint()
    {
        float X = (L1.B - L2.B)/(L2.K - L1.K);
        float Y = (L1.B * X) + L1.B;

        Console.WriteLine($"Точка пересечени - ({X},{Y}).");
    }
}

