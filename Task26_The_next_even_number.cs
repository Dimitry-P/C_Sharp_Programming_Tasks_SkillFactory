using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int x = int.Parse(Console.ReadLine());
        int y = x % 2;

        Console.Write("следующее четное число равно: " + (x + (2 - y)));
        Console.ReadKey();
    }
}