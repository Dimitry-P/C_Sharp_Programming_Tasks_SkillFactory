using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = x;
        int y = int.Parse(Console.ReadLine());
        int i = y;

        while (i > 1)
        {
            x *= z;
            i--;
        }
        Console.WriteLine($"{z} в степени {y} равно {x}");
        Console.ReadLine();
    }
}