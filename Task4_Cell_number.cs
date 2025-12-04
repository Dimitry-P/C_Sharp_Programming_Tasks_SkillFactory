using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер клетки, на которой находится враг: ");
        int kletka = int.Parse(Console.ReadLine());

        if (kletka > 0 && kletka < 29)
        {
            Console.WriteLine("Введите X и Y клетки, которую хотите проверить: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (!(x > 0 && x < 8) || !(y > 0 && y < 5))
            {
                Console.WriteLine("Таких координат быть не может!");
            }
            else
            {
                if (y == 1) x = x;
                if (y == 3) x += 14;
                if (y == 2) x = 15 - x;
                if (y == 4) x = 29 - x;
                Console.WriteLine(x);
                if (kletka >= x) Console.WriteLine("враг достиг клетки");
                else
                {
                    Console.WriteLine("враг НЕ достиг клетки");
                }
            }
        }
        else
        {
            Console.WriteLine("Вы ввели недопустимое значение");
        }
        Console.ReadKey();
    }
}