using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите левую границу отрезка");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите правую границу отрезка");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите насколько выстрелила пушка");
        int n = int.Parse(Console.ReadLine());

        if (n >= a && n <= b)
        { Console.WriteLine("Попадание"); }
        else { Console.WriteLine("Промах"); }

        Console.ReadLine();
    }
}