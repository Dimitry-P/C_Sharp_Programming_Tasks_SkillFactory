using System;

class Program
{
    static void Main()
    {
        int res2 = int.MinValue;
        int result;
        int amount = int.Parse(Console.ReadLine());

        for (int i = amount; i > 0; i--)
        {
            result = int.Parse(Console.ReadLine());

            if (res2 < result)
            {
                res2 = result;
            }
        }
        Console.WriteLine($"Из чисел которые вы ввели максимальное {res2}");
        Console.ReadLine();
    }
}