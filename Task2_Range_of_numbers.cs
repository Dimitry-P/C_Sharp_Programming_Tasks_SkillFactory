using System;

class Program
{
    static void Main()
    {
        int min, max, v1, v2, v3;

        Console.WriteLine("Введите диапозон");
        min = int.Parse(Console.ReadLine());
        max = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите три числа");
        v1 = int.Parse(Console.ReadLine());
        v2 = int.Parse(Console.ReadLine());
        v3 = int.Parse(Console.ReadLine());

        int maxV = 0;

        if (v1 >= min && v1 <= max)
        {
            maxV = v1;
        }

        if (v2 >= min && v2 <= max)
        {
            if (v2 > v1 && v2 > v3) maxV = v2;
        }

        if (v3 >= min && v3 <= max)
        {
            if (v3 > v2 && v3 > v1) maxV = v3;
        }

        if ((v1 < min || v1 > max) && (v2 < min || v2 > max) && (v3 < min || v3 > max))
        {
            Console.WriteLine("Чисел в диапазон не найдено");
        }
        else
        {
            Console.WriteLine("Максимальное число: " + maxV);
        }
        Console.ReadLine();
    }
}