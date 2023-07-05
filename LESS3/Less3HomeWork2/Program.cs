/*

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

    Point A = new Point(3,6,8);
    Point B = new Point(2,1,-7);
    Line line= new Line(A,B);
    line.GetLength();
    Console.WriteLine($"Point A - {A}. Point B - {B}. Length 1 = {line.ToString()}");

    A.x = 7; A.y = -5; A.z = 0;
    B.x = 1; B.y = -1; B.z = 9;
    Line line2= new Line(A,B); line2.GetLength();
    Console.WriteLine($"Point A - {A}. Point B - {B}. Length 2 = {line2.ToString()}");


public class Line
{
    public Point A { get; set; }
    public Point B { get; set; }

    public double Length { get; set; }
    
    public Line(Point a, Point b)
    {
        this.A = a;
        this.B = b;
    }

    public double GetLength()
    {
        Length = Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2) + Math.Pow(A.z - B.z, 2));
        return Length;
    }

    public override string ToString()
    {
        return $"Длина = {Length:F3}";
    }
}




public class Point
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
    public Point(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public override string ToString()
    {
        return $"({x},{y},{z})";
    }
}
