using System;

class Program
{
    static void Main()
    {
        // мой вариант
        int[,] a = new int[4, 4];

        for (int i = 0; i < a.GetLongLength(0); i++)
        {
            for (int j = 0; j < a.GetLongLength(1); j++)
            {
                if (i % 3 == 0 && j % 3 == 0) a[i, j] = 1;
                if (i % 3 != 0 && j % 3 != 0) a[i, j] = 1;
            }
        }

        for (int i = 0; i < a.GetLongLength(0); i++)
        {
            for (int j = 0; j < a.GetLongLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}