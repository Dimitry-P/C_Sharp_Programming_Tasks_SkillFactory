using System;

class Program
{
    static void Main()
    {
        int max;
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        max = a;

        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;
        if (e > max) max = e;

        Console.WriteLine("Максимальное число: " + max);
        Console.ReadKey();
    }
}