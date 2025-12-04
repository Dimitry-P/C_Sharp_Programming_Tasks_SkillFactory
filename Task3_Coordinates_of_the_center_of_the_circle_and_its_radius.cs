using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты центра круга и его радиус:");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());

        for (int i = x - radius; i <= x + radius; i++)
        {
            for (int l = y - radius; l <= y + radius; l++)
            {
                if ((i - x) * (i - x) + (l - y) * (l - y) <= radius * radius)
                {
                    Console.SetCursorPosition(i, l);
                    Console.WriteLine("*");
                }
            }
        }
        Console.ReadLine();
    }
}