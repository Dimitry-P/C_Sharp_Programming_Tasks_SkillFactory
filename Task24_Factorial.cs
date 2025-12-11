using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int i = number - 1;
        while (i > 0)
        {
            number = number * i;
            i--;
        }
        Console.WriteLine(number);
        Console.ReadKey();
    }
}