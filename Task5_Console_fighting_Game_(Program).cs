using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int playerHealth = 100;
        int playerEnergy = 100;
        int enemyHealth = 100;
        int enemyEnergy = 100;
        int action = -1;
        int action2 = -1;
        int counter = 0;
        int EnemyAction = -1;
        string NameOfEnemyAction = "";
        int Damage = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(@"       Жизни: {0}                Жизни вируса: {1}", playerHealth, enemyHealth);
            Console.WriteLine(@"       Энергия: {0}              Энергия вируса: {1}", playerEnergy, enemyEnergy);

            Console.WriteLine();

            Console.WriteLine("1. Облить водой (20 урона, -10 энергии)");
            Console.WriteLine("2. Использовать Огнемёт (30 урона, -30 энергии)");
            Console.WriteLine("3. Удар электрошокером (15 урона, -30 энергии)");
            Console.WriteLine("4. Оторвать все конечности (30 урона, -40 энергии)");
            Console.WriteLine("5. Сильная атака 1: Перерубить тело пополам  (50 урона, -50 энергии)");
            Console.WriteLine("6. Сильная атака 2: Уничтожить гранатомётом  (50 урона, -50 энергии)");
            Console.WriteLine("7. Сильная атака 3: Сжечь противника в пламени ядерного удара  (Противник теряет все силы, игрок теряет 120 энергии)");
            Console.WriteLine("8. Прокачать энергию (+20 энергии) !!!!ОПАСНО!!!! Можно потерять всё");
            Console.WriteLine("9. Трансформировать энергию в жизненные силы");
            Console.WriteLine("Сделайте ход, нанесите удар противнику, введя цифру от 1 до 9:");
            Console.WriteLine();

            // Описание победы или поражения
            if (playerHealth <= 0)
            {
                Console.WriteLine("Вирус выиграл");
                break;
            }
            if (enemyHealth <= 0)
            {
                Console.WriteLine("Ты выиграл");
                break;
            }

            //Проверка, чтобы пользователь ввёл число от 1 до 9
            if (int.TryParse(Console.ReadLine(), out action))
            {
                if (action < 1 || action > 9)
                {
                    Console.WriteLine("Введите число от 1 до 9. Сделайте ход!");
                    Console.ReadLine();
                    break;
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 9. Сделайте ход!");
                Console.ReadLine();
                break;
            }

            //Описание скиллов игрока
            if (action == 1)
            {
                counter = 0;
                if (playerEnergy >= 10)
                {
                    enemyHealth -= 20;
                    playerEnergy -= 10;
                    Console.WriteLine("Урон врагу: 20");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход");
                    Console.ReadLine();
                }
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Ты выиграл");
                    break;
                }
            }

            //Описание скиллов игрока
            if (action == 2)
            {
                counter = 0;
                if (playerEnergy >= 40)
                {
                    enemyHealth -= 30;
                    playerEnergy -= 30;
                    Console.WriteLine("Урон врагу: 30");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход");
                    Console.ReadLine();
                }
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Ты выиграл");
                    break;
                }
            }

            //Описание скиллов игрока
            if (action == 3)
            {
                counter = 0;
                if (playerEnergy >= 40)
                {
                    enemyHealth -= 15;
                    playerEnergy -= 30;
                    Console.WriteLine("Урон врагу: 15");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход");
                    Console.ReadLine();
                }
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Ты выиграл");
                    break;
                }
            }

            //Описание скиллов игрока
            if (action == 4)
            {
                counter = 0;
                Console.WriteLine("Данная атака никак не повлияет на вирус! Но ваша энергия переходит вирусу");
                Console.ReadLine();
                playerEnergy -= 40;
            }

            //Описание скиллов игрока
            if (action == 5)
            {
                counter = 0;
                playerEnergy -= 25;
                Console.WriteLine("Данная атака никак не повлияет на вирус! Но ваша энергия переходит вирусу");
                Console.ReadLine();
            }

            //Описание скиллов игрока
            if (action == 6)
            {
                counter = 0;
                if (playerEnergy >= 150)
                {
                    enemyHealth -= 50;
                    playerEnergy -= 50;
                    Console.WriteLine("Урон врагу: 50");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход");
                    Console.ReadLine();
                }
                playerEnergy -= 25;
                enemyEnergy += 25;
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Ты выиграл");
                    break;
                }
            }

            //Описание скиллов игрока
            if (action == 7)
            {
                counter = 0;
                if (playerEnergy >= 180)
                {
                    enemyHealth -= 300;
                    playerEnergy -= 120;
                    Console.WriteLine("Урон врагу: 300");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход");
                    Console.ReadLine();
                }
                playerEnergy -= 25;
                enemyEnergy += 25;
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Ты выиграл");
                    break;
                }
            }

            // Прокачка энергии игрока
            if (action == 8)
            {
                counter++;
                if (counter > 2)
                {
                    Console.WriteLine("Вы не можете пополнять силы три раза подряд, выберите другое действие!");
                    Console.ReadLine();
                }
                else
                {
                    action2 = rnd.Next(1, 10);
                    if (action2 == 7)
                    {
                        playerHealth -= 300;
                        Console.WriteLine("Выпало совсем несчастливое число! Вам КОНЕЦ!!!");
                        Console.ReadLine();
                        Console.WriteLine("Вирус выиграл");
                        break;
                    }
                    else if (action2 == 3)
                    {
                        playerHealth -= 40;
                        playerEnergy -= 10;
                        enemyEnergy += 100;
                        Console.WriteLine("Выпало несчастливое число! Вы получили 40 урона!");
                        Console.ReadLine();
                    }
                    else
                    {
                        playerEnergy += 40;
                        enemyEnergy += 40;
                        Console.WriteLine("Силы прокачались!");
                        Console.ReadLine();
                    }
                }
            }

            //Трансформировать энергию в жизненные силы
            if (action == 9)
            {
                counter = 0;
                Console.WriteLine("Какой объем энергии вы хотите трансформировать в жизненные силы?");
                int TransformEnergy = int.Parse(Console.ReadLine());
                if (TransformEnergy > playerEnergy)
                {
                    Console.WriteLine("Ваши жизненные силы меньше введённого объёма");
                    Console.ReadLine();
                }
                else
                {
                    playerEnergy -= TransformEnergy;
                    playerHealth += TransformEnergy;
                    Console.WriteLine("Ваши жизненные силы увеличились на " + TransformEnergy);
                    Console.ReadLine();
                }
            }

            // пополнение ресурса противника в случае, если его не хватает
            if (enemyEnergy <= 20)
            {
                Console.WriteLine("Вирус пополняет свою энергию на 100 единиц");
                enemyEnergy += 100;
                Console.ReadLine();
            }

            // Удар противника
            EnemyAction = rnd.Next(1, 8);

            // Описание работы скиллов противника
            if (EnemyAction == 1)
            {
                NameOfEnemyAction = "Облил вас водой";
                Damage = 20;
                playerHealth -= 20;
                enemyEnergy -= 10;
                Console.WriteLine($"Вирус {NameOfEnemyAction}. Вы получили {Damage} урона");
                Console.ReadLine();
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус выиграл");
                    break;
                }
            }

            // Описание работы скиллов противника
            if (EnemyAction == 2)
            {
                playerHealth -= 30;
                enemyEnergy -= 30;
                NameOfEnemyAction = "использовал огнемёт";
                Damage = 30;
                Console.WriteLine($"Вирус {NameOfEnemyAction}. Вы получили {Damage} урона");
                Console.ReadLine();
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус выиграл");
                    break;
                }
            }

            // Описание работы скиллов противника
            if (EnemyAction == 3)
            {
                NameOfEnemyAction = "ударил электрошокером";
                Damage = 15;
                playerHealth -= 15;
                enemyEnergy -= 30;
                Console.WriteLine($"Вирус {NameOfEnemyAction}. Вы получили {Damage} урона");
                Console.ReadLine();
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус выиграл");
                    break;
                }
            }

            // Описание работы скиллов противника
            if (EnemyAction == 4)
            {
                NameOfEnemyAction = "оторвал вам все конечности";
                Damage = 30;
                playerHealth -= 30;
                enemyEnergy -= 40;
                Console.WriteLine($"Вирус {NameOfEnemyAction}. Вы получили {Damage} урона");
                Console.ReadLine();
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус выиграл");
                    break;
                }
            }

            // Описание работы скиллов противника
            if (EnemyAction == 5)
            {
                NameOfEnemyAction = "перерубил вам тело пополам";
                Damage = 50;
                playerHealth -= 50;
                enemyEnergy -= 50;
                Console.WriteLine($"Вирус {NameOfEnemyAction}. Вы получили {Damage} урона");
                Console.ReadLine();
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус выиграл");
                    break;
                }
            }

            // Описание работы скиллов противника
            if (EnemyAction == 6)
            {
                NameOfEnemyAction = "уничтожил вас гранатомётом";
                Damage = 50;
                playerHealth -= 50;
                enemyEnergy -= 50;
                Console.WriteLine($"Вирус {NameOfEnemyAction}. Вы получили {Damage} урона");
                Console.ReadLine();
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус выиграл");
                    break;
                }
            }

            // Описание работы скиллов противника
            if (EnemyAction == 7)
            {
                NameOfEnemyAction = "не может использовать самое мощное (ЯДЕРНОЕ) оружие";
                Damage = 0;
                enemyEnergy -= 20;
                Console.WriteLine($"Вирус {NameOfEnemyAction}. Вы получили {Damage} урона");
                Console.ReadLine();
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус выиграл");
                    break;
                }
            }
        }
        Console.ReadLine();
    }
}
