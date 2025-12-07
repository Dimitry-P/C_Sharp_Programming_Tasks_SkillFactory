using System;

class Program
{
    static void Main()
    {
        // все значения массива влево на 1
        int[] L = new int[10] { 34, 16, 85, 8, 65, 60, 16, 32, 21, 83 };
        for (int i = 0; i < L.Length; i++)
        {
            Console.Write(L[i] + " ");
        }
        Console.WriteLine();

        for (int i = 1; i < L.Length; i++)
        {
            Console.Write(L[i] + " ");
        }
        Console.Write(L[L.Length - 1] = L[0]);

        //все значения массива вправо на 1
        Console.WriteLine();

        int[] Array = new int[10] { 65, 51, 57, 40, 25, 75, 10, 55, 73, 67 };
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write(Array[i] + " ");
        }
        Console.WriteLine();

        Console.Write(Array[Array.Length - 1] + " ");
        for (int i = 0; i < Array.Length - 1; i++)
        {
            Console.Write(Array[i] + " ");
        }
    }
}