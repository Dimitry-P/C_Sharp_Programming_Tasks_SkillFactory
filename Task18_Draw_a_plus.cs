using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите высоту плюса:");
        int num = int.Parse(Console.ReadLine());
        Console.Clear();

        for (int i = 0; i < num; i++)
        {
            Console.SetCursorPosition(num / 2, i);
            Console.Write("*");
            Console.SetCursorPosition(i, num / 2);
            Console.Write("*");
        }
        Console.ReadLine();
    }
}