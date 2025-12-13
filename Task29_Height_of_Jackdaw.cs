using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите высоту галки:");
        int height = int.Parse(Console.ReadLine());
        Console.Clear();
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(i, i);
            Console.WriteLine("*");
            Console.SetCursorPosition(height + i, height - i - 1);
            Console.WriteLine("*");
        }
        Console.ReadLine();
    }
}