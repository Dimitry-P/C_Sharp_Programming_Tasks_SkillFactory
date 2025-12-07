using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] A = new int[10];

        //1. Инициализация
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = rnd.Next(0, 100);
        }

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i]);
        }
        Console.WriteLine();

        // 2. Обработка данных
        // 3. Вывод результатов
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i]);
        }

        // сумму и произведение элементов массива
        int[] B = new int[10] { 3, 6, 7, 1, 2, 7, 6, 7, 1, 4 };
        int sum = 0;
        int mul = 1;
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i] + " ");
            sum += B[i];
            mul *= B[i];
        }
        Console.WriteLine();
        Console.WriteLine(sum);
        Console.WriteLine(mul);


        // Напишите программу, которая заменяет все чётные элементы массива на 0.
        int[] C = new int[10] { 4, 8, 6, 3, 4, 5, 9, 9, 4, 2 };
        for (int i = 0; i < C.Length; i++)
        {
            Console.Write(C[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < C.Length; i++)
        {
            if (C[i] % 2 == 0)
            {
                C[i] = 0;
            }
            Console.Write(C[i] + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}