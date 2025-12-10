using System;

class Program
{
    static void Main()
    {
        string password = "Unity2020";
        string bob = "";

        while (bob != password)
        {
            Console.WriteLine("введите пароль");
            bob = Console.ReadLine();
        }

        Console.WriteLine("вы вошли в систему");
        Console.ReadLine();
    }
}