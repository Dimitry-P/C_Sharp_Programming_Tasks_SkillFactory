using System;

class Program
{
    static int Fibonachi(int number)
    {
        int a = 0;
        int b = 1;
        int c = 0;

        if (number == 1) return 0;
        if (number == 2) return 1;
        if (number == 3) return 1;

        number -= 2;

        while (number != 0)
        {
            c = a + b;
            a = b;
            b = c;
            number--;
        }
        return c;
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число фибоначи под номером {number} равно " + Fibonachi(number));
        Console.ReadLine();
    }
}
