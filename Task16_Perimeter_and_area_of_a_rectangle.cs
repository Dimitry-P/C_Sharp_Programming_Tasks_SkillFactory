using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ширину прямоугольника: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите высоту прямоугольника: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Площадь прямоугольника равна: " + x * y);
        Console.WriteLine("Периметр прямоугольника равен: " + 2 * (x + y));
        Console.ReadLine();
    }
}