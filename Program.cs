using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DarkSoulsUltra
{
    class Program
    {   
        static void Main()
        {
            Random rnd = new Random();
            
            int playerHealth = 200;
            int enemyHealth = 0;
            int heal = 70;
            int healCount = 3;
            int CountKill = 0;
            int chek;
            int gold = 0;
            bool fight1;
            int lvlOfPower = 1;
            int pokupka;
            int maxPlayerAttak = 5;
            int minPlayerAttak = 35;
            int minEnemyAttak = 5;
            int maxEnemyAttak = 10;
            int progress;
            int rekord = 0 ;
            void getEnemyAttak()
            {
                if (CountKill >= 5)
                {
                    minEnemyAttak = 5;
                    maxEnemyAttak = 10;
                }
                if (CountKill >= 10)
                {
                    minEnemyAttak = 12;
                    maxEnemyAttak = 19;
                }
                if (CountKill >= 15)
                {
                    minEnemyAttak = 20;
                    maxEnemyAttak = 26;
                }
                if (CountKill >= 20)
                {
                    minEnemyAttak = 30;
                    maxEnemyAttak = 32;

                }
            }
            void getAttak()
            {
                if (lvlOfPower == 1)
                {
                    maxPlayerAttak = 35;
                    minPlayerAttak = 5;
                }
                if (lvlOfPower == 2)
                {
                    maxPlayerAttak = 40;
                    minPlayerAttak = 10;
                }
                if (lvlOfPower == 3)
                {
                    maxPlayerAttak = 45;
                    minPlayerAttak = 15;
                }
                if (lvlOfPower == 4)
                {
                    maxPlayerAttak = 50;
                    minPlayerAttak = 20;
                }
                if (lvlOfPower == 5)
                {
                    maxPlayerAttak = 55;
                    minPlayerAttak = 25;
                }
                if (lvlOfPower == 6)
                {
                    maxPlayerAttak = 60;
                    minPlayerAttak = 30;
                }
                if (lvlOfPower == 7)
                {
                    maxPlayerAttak = 65;
                    minPlayerAttak = 35;
                }
                if (lvlOfPower == 8)
                {
                    maxPlayerAttak = 75;
                    minPlayerAttak = 45;
                }
                if (lvlOfPower == 9)
                {
                    maxPlayerAttak = 85;
                    minPlayerAttak = 55;
                }
                if (lvlOfPower == 10)
                {
                    maxPlayerAttak = 95;
                    minPlayerAttak = 55;
                }
                if (lvlOfPower == 11)
                {
                    maxPlayerAttak = 115;
                    minPlayerAttak = 70;
                }
            }
            void enemyAtaka()
            {
                getEnemyAttak();
                int enemyDamage = rnd.Next(minEnemyAttak, maxEnemyAttak);
                playerHealth -= enemyDamage;
                Console.WriteLine($"Вас ударил монстр на {enemyDamage}, ваше хп: {playerHealth}  ");
            }
            void shop()
            {
                Console.Clear();
                Console.WriteLine($"Привет,это волшебный магазин,тут ты можешь улучшить оружие и купить аптечки\n" +
                                  $"Купить аптечку - 1 / Улучшить оружие  - 2\n");
                int status = Convert.ToInt32(Console.ReadLine());
                switch (status)
                {
                    case 1:
                        Console.WriteLine($"Аптечка стоит 30 золотых , купить : \n 1- да / 2 - нет");
                        pokupka = Convert.ToInt32(Console.ReadLine());
                        if (pokupka == 1)
                        {
                            if (gold >= 30)
                            {
                                healCount += 1;
                                gold -= 30;
                                Console.WriteLine("Вы купили аптечку");
                            }
                            else
                            {
                                Console.WriteLine("У вас нехватает золота\n");
                            }
                        }
                        if (pokupka == 2)
                        {
                            Console.WriteLine("Заходи в другой раз\n");
                        }
                        pokupka = 0;
                        break;
                    case 2:
                        Console.WriteLine($"Улучшить оружие стоит 50 золотых. \n" +
                                          $"Каждое улучшение твоего оружия даёт тебе +10 к возможному урон. \n" +
                                          $"Твой текущий уровень оружия: {lvlOfPower} \n Купить : 1- да / 2 - нет");
                        pokupka = Convert.ToInt32(Console.ReadLine());
                        if (pokupka == 1)
                        {
                            if (gold >= 50)
                            {
                                lvlOfPower += 1;
                                gold -= 50;
                            }
                            else
                            {
                                Console.WriteLine("У вас нехватает золота");
                            }
                        }
                        if (pokupka == 2)
                        {
                            Console.WriteLine("Заходи в другой раз");
                        }
                        pokupka = 0;
                        break;
                }
               
            }
            void deistvie()
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Вступить в бой с монстром\n" +
                                  "2 - Посмотреть счет убитых монстров\n" +
                                  "3 - Зайти в магазин\n" +
                                  "4 - Посмотреть количество аптечек \n" +
                                  "5 - Проверить карманы на наличие золота \n" +
                                  "6 - Узнать характеристики оружия\n" +
                                  "7 - Посмотреть мой рекорд\n\n");
                chek = Convert.ToInt32(Console.ReadLine());
            }
            void result()
            {
                if (CountKill >= 20)
                {
                    progress = 1;
                }
                else progress = 2;

            }
            void lvlOfEnemy()
            {
                if (CountKill < 5)
                { enemyHealth = 100; } 
                if (CountKill >= 5)
                { enemyHealth = 150; }
                if (CountKill >= 10)
                { enemyHealth = 200; }
                if (CountKill >= 15)
                { enemyHealth = 250; }
                if (CountKill >= 20)
                { enemyHealth = 300; }
            }
            void rules()
            {
                Console.WriteLine
                    (
                    "Привет! Нам нужна помощь с монстрами, можешь ли помочь нам? \n" +
                    "Я знал, что ты согласишься, поэтому вот тебе 3 аптечки - они помогут тебе в бою. \n" +
                    "Между битвами, ты можешь зайти в магазин и улучшить свой меч или докупить аптечки.\n" +
                    "За каждого убитого монстра ты будешь получать от 15 до 90 золотых.\n" +
                    "Потрать их с умом, удачи!\n" +
                    "P.S. Если ты умрешь, то потеряешь все золото и твой счетчик убитых монстров обнулится :( .\n" +
                    "Что бы победть в этой битве, тебе нужно справиться с 20-ю монстрами!\n\n"
                    );
            }
            void fight()
            {
                Console.Clear();
                lvlOfEnemy();
                fight1 = true;
                while (fight1)
                {
                    Console.WriteLine("Выберите действие :");
                    Console.WriteLine("1 - Ударить\n" +
                                      "2 - Бежать\n" +
                                      "3 - Использовать аптечку\n\n");
                    int choise = Convert.ToInt32(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            if (CountKill >= rekord)
                            {
                                rekord = CountKill;
                            }

                            Console.Clear();
                            getAttak();
                            int playerDamage = rnd.Next(minPlayerAttak, maxPlayerAttak);
                            enemyHealth -= playerDamage;
                            Console.WriteLine($"Вы нанесли урона: {playerDamage}\n" +
                                              $"У монстра осталось: {enemyHealth} ХП");
                            enemyAtaka();
                            break;

                        case 2:
                            Console.Clear();
                            int proverkaUdachi = rnd.Next(1, 10);
                            if (proverkaUdachi <= 7)
                            {
                                Console.WriteLine($"Вы убежали \n\n");
                            }
                            else
                            {
                                gold = 0;
                                healCount = 3;
                                Console.WriteLine("Сегодня удача не на вашей строне, монстр вас догнал :(\n\n");
                                Console.WriteLine($"Твой рекород Убитых монстров: {rekord} !");
                            }
                            fight1 = false;
                            break;

                        case 3:
                            Console.Clear();
                            if (healCount <= 0)
                            {
                                Console.WriteLine("Аптечек больше нет,надо будет зайти в магазин");
                            }
                            else
                            {
                                healCount -= 1;
                                Console.WriteLine($"У вас осталось аптечек: {healCount} ");
                                playerHealth += heal;
                                if (playerHealth >= 200)
                                {
                                    playerHealth = 200;
                                }
                                Console.WriteLine($"Теперь у вас {playerHealth} здоровья\n\n");
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Выбирите корректное действие\n\n");
                            break;
                    }
                    if (enemyHealth <= 0)
                    {
                        Console.WriteLine("Вы победили монстра !\n");
                        CountKill += 1;
                        int GoldNow = rnd.Next(20, 100);
                        gold += GoldNow;
                        Console.WriteLine($"Вы получили с него {GoldNow} золота");
                        break;
                    }
                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("Монстр вас победил :(\n\n");
                        Console.WriteLine($"Твой рекород Убитых монстров: {rekord} !");

                        healCount = 3;
                        CountKill = 0;
                        gold = 0;
                        fight1 = false;
                        playerHealth = 200;
                        break;
                    }
                }
            }
            void startGame()
            {

                while (true)
                {
                    result();
                    if (progress == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Поздравляю,ты прошел игру и спас деревню!!!");
                        Console.ReadKey();
                        break;
                    }

                    deistvie();
                    switch (chek)
                    {
                        case 1:
                            Console.Clear();
                            fight();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine($"Вы победили {CountKill} монстров\n\n");
                            break;

                        case 3:
                            Console.Clear();
                            shop();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine($"У вас аптечек: {healCount} ! \n\n ");
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine($"У вас Золота: {gold} ! \n\n ");
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine($"Уровень вашего оружия: {lvlOfPower} ! \n" +
                                              $"Наносимый урон: от {minPlayerAttak} до {maxPlayerAttak}\n\n ");
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine($"Твой рекорд убитых монстров: {rekord} ! \n" );
                            break;
                    }
                }
            }
            rules();
            startGame();
        }
    }
}