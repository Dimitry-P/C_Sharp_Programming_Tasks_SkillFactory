using System;

class Program
{
    static void Main()
    {
        int z = 0;
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        while (y > x)
        {
            int p = y - x;
            z = x - p;
            if (z == p) break;
        }
        while (y < x)
        {
            int p = x - y;
            z = y - p;
            if (z == p) break;

        }

        Console.WriteLine("НОД чисел " + x + " и " + y + " равен " + z);
        Console.ReadLine();
    }
}