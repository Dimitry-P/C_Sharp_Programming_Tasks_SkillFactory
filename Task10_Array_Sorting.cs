using System;

class Program
{
    static void Main()
    {
        int[] Array = new int[5] { 5, 1, 2, 6, 4 };

        for (int i = 0; i < Array.Length - 1; i++)
        {
            int t = Array[i];

            if (Array[i] > Array[i + 1])
            {
                Array[i] = Array[i + 1];
                Array[i + 1] = t;
            }
            for (int j = Array.Length - 1; j > 0; j--)
            {
                int tt = Array[j];
                if (Array[j] < Array[j - 1])
                {
                    Array[j] = Array[j - 1];
                    Array[j - 1] = tt;
                }
            }
        }
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write(Array[i] + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}