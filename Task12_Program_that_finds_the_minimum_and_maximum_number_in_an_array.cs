using System;

class Program
{
    static void Main()
    {
        // Напишите программу, которая находит минимальное и максимальное число в массиве.
        int[] D = new int[10] { 3, 2, 5, 1, 24, 6, 2, 8, 2, 9 };
        for (int i = 0; i < D.Length; i++)
        {
            Console.Write(D[i] + " ");
        }
        Console.WriteLine();
        int biggest = 0;
        int smallest = 0;
        for (int i = 0; i < D.Length; i++)
        {
            if (biggest < D[i]) biggest = D[i];

        }
        Console.WriteLine(biggest);
        for (int i = 0; i < D.Length; i++)
        {
            smallest = D[i];
            if (biggest > smallest) biggest = smallest;
        }
        Console.WriteLine(biggest);


        int[] J = new int[10] { 3, 2, 5, 1, 24, 6, 2, 8, 2, 9 };
        int min = J[0];
        int max = J[0];
        for (int i = 0; i < J.Length; i++)
        {

            if (J[i] < min) min = J[i];
            if (J[i] > max) max = J[i];
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}