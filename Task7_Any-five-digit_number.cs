using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите любое пятизначное число: ");
        string x = Console.ReadLine();
        if (x.Length == 5)
        {
            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);
            Console.WriteLine(x[3]);
            Console.WriteLine(x[4]);
        }
        else
        {
            Console.WriteLine("Введено некорректное число");
        }
        Console.ReadKey();
    }
}