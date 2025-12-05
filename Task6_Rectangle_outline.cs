using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты левой верхней и нижней правой точки прямоугольника:");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        for (int x = x1; x <= x2; x++)
        {
            for (int y = y1; y <= y2; y++)
            {
                if (x == x1 || x == x2 || y == y1 || y == y2)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                }
            }
        }
        Console.ReadLine();
    }
}