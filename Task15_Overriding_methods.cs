using System;

public class Animal
{
    public string Name;
    public virtual void Say()
    {
        Console.Write("Базовый метод Animal ");
    }
}

public class Cat : Animal
{
    public override void Say()
    {
        Console.WriteLine("Переопределённый метод КЭТ");
    }
}

public class Dog : Animal
{
    public override void Say()
    {
        Console.WriteLine("Переопределённый метод ДОГ");
    }
}

class Program
{
    static void Main()
    {
        Animal[] allAnimals = new Animal[2];

        allAnimals[0] = new Cat();
        allAnimals[0].Name = "Lyusya";

        allAnimals[1] = new Dog();
        allAnimals[1].Name = "Bobik";

        for (int i = 0; i < allAnimals.Length; i++)
        {
            // Вызываться будут переопределённые методы 
            allAnimals[i].Say();
        }
        Console.ReadLine();
    }
}