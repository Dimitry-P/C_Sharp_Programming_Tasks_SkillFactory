using System;

class Program
{
    static void Main()
    {
        int first, second, sum, raz, proiz, chast;

        Console.Write("Введите первое число: ");
        first = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        second = int.Parse(Console.ReadLine());
        sum = first + second;
        raz = first - second;
        proiz = second * first;
        chast = first / second;
        Console.WriteLine($"{first} + {second} = {sum}");
        Console.WriteLine($"{first} - {second} = {raz}");
        Console.WriteLine($"{first} * {second} = {proiz}");
        Console.WriteLine($"{first} / {second} = {chast}");

        Console.ReadKey();
    }
}