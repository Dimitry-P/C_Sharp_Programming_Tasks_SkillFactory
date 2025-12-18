using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Weapon
{
    public int Damage;
}

class Program
{
    static void ChangeDamage(Weapon w)
    {
        w.Damage += 10;
    }
    static void Main()
    {
        Weapon mainWeapon = new Weapon();
        mainWeapon.Damage = 10;

        Weapon axe = new Weapon();
        axe.Damage = 11;
        Weapon lasergun = new Weapon();
        lasergun.Damage = 100;
        ChangeDamage(lasergun);

        Console.WriteLine(lasergun.Damage);
        Console.ReadLine();
    }
}
