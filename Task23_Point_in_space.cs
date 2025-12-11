using System;

class Program
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int Px = int.Parse(Console.ReadLine());
        int Py = int.Parse(Console.ReadLine());

        if (Px >= x1)
        {
            if (Px <= x2)
            {
                if (Py >= y1)
                {
                    if (Py <= y2)
                    {
                        Console.WriteLine("Точка принадлежит прямоугольнику!");
                    }
                    else
                        Console.WriteLine("Промах");
                }
                else
                    Console.WriteLine("Промах");
            }
            else
                Console.WriteLine("Промах");
        }
        else
            Console.WriteLine("Промах");
        Console.ReadLine();
    }
}