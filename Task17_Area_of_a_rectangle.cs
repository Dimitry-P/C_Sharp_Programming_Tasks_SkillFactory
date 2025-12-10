using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите высоту и ширину прямоугольника");
        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int area = width * height;

        Console.WriteLine("Площадь равна: " + area);

        Console.ReadLine();
    }
}