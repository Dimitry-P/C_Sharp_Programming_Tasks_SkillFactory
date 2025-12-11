using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int i, j;
        int k = 0;

        for (i = 1; i <= num; i++)
        {
            for (j = 1; j <= num; j++)
            {
                int m = 1 + k;
                Console.Write($"{m * j,-5}");
            }
            Console.WriteLine();
            k = k + 1;
        }
        Console.ReadKey();
    }
}