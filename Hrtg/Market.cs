using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    class Market
    {
        
        static public void Trader(Player player1)
        {
            int PriceHpot = 30, PriceScroll = 100, PriceAmul = 1000, PriceNewAmul = 2500;
            string trade = "10";
            if (player1.trader == false)
            {
                Console.WriteLine("Вы достаете свиток незнакомца из города, пытаясь разобрать надписи.\nТаинственный торговец: Эй, что ты уставился в эти листы, не меня ищешь?\nВы поднимаете голову, перед вами тот самый человек, который вручил эти свитки.");
                player1.trader = true;
            }
            Console.WriteLine("\n" + player1.TraderName + ": Чего желаешь?");
            Console.WriteLine("Товары: " + "\t\t\t\t\t\t\t\t Ваше золото: " + player1.gold);
            Console.WriteLine("1.Зелье лечения(восстанавливает здоровье)\t\t\t\t 30 золотых");
            Console.WriteLine("2.Свиток силы(увеличивает урон на 1)\t\t\t\t\t 100 золотых");
            Console.WriteLine("3.Свиток брони(увеличивает броню на 1)\t\t\t\t\t 100 золотых");
            if (player1.lvl > 5) Console.WriteLine("4.Амулет удачи(10% шанс нанести критический урон)\t\t\t 1000 золотых");
            if (player1.lvl > 7) Console.WriteLine("5.Амулет защиты(уменьшает получаемый в бою урон на 20%)\t\t\t 1000 золотых");
            if (player1.lvl > 13) Console.WriteLine("6.Зачарованный амулет удачи(25% шанс нанести критический урон)\t\t 2500 золотых");
            Console.WriteLine("0.Уйти");
            while (trade != "0")
            {
                trade = Console.ReadLine();
                if (trade == "1")
                {
                    if (player1.gold >= PriceHpot)
                    {
                        if (player1.hpot < player1.hpot_max)
                        {
                            if (player1.sale == 10)
                            {
                                Console.WriteLine(player1.TraderName + ": Ты стал моим постоянным клиентом, в этот раз я отдам товар бесплатно.");
                                player1.sale = 0;
                                player1.hpot++;
                            }
                            else
                            {
                                player1.gold -= PriceHpot;
                                player1.hpot++;
                                player1.sale++;
                            }
                            Console.WriteLine("Вы покупаете зелье лечения.");
                        }
                        else Console.WriteLine("У вас нет свободного места.");
                    }
                    else Console.WriteLine(player1.TraderName + ": У тебя не хватает золота.");
                }

                if (trade == "2")
                {
                    if (player1.gold >= PriceScroll)
                    {
                        if (player1.sale == 10)
                        {
                            Console.WriteLine(player1.TraderName + ": Ты стал моим постоянным клиентом, в этот раз я отдам товар бесплатно.");
                            player1.sale = 0;
                            player1.damage++;
                        }
                        else
                        {
                            player1.gold -= PriceScroll;
                            player1.damage++;
                            player1.sale++;
                        }
                        Console.WriteLine("Вы покупаете свиток силы, ваш урон увеличивается на 1.");
                    }
                    else Console.WriteLine(player1.TraderName + ": У тебя не хватает золота");
                }

                if (trade == "3")
                {
                    if (player1.gold >= PriceScroll)
                    {
                        if (player1.sale == 10)
                        {
                            Console.WriteLine(player1.TraderName + ": Ты стал моим постоянным клиентом, в этот раз я отдам товар бесплатно.");
                            player1.sale = 0;
                            player1.armor++;
                        }
                        else
                        {
                            player1.gold -= PriceScroll;
                            player1.armor++;
                            player1.sale++;
                        }
                        Console.WriteLine("Вы покупаете свиток брони, ваша броня увеличивается на 1.");

                    }
                    else Console.WriteLine(player1.TraderName + ": У тебя не хватает золота");
                }
                if (player1.lvl > 5 && trade == "4")
                {
                    if (player1.gold >= PriceAmul)
                    {
                        player1.gold -= PriceAmul;
                        Console.WriteLine("Вы покупаете амулет удачи, шанс нанести критический урон возрастает на 10%");
                        player1.amul = "Амулет удачи";
                        player1.sale = 10;
                    }
                    else Console.WriteLine(player1.TraderName + ": У тебя не хватает золота");
                }
                if (player1.lvl > 7 && trade == "5")
                {
                    if (player1.gold >= PriceAmul)
                    {
                        player1.gold -= PriceAmul;
                        Console.WriteLine("Вы покупаете амулет защиты, получаемый урон уменьшен на 20%");
                        player1.amul = "Амулет защиты";
                        player1.sale = 10;
                    }
                    else Console.WriteLine(player1.TraderName + ": У тебя не хватает золота");
                }
                if (player1.lvl > 13 && trade == "6")
                {
                    if (player1.gold >= PriceNewAmul)
                    {
                        player1.gold -= PriceNewAmul;
                        Console.WriteLine("Вы покупаете зачарованный амулет удачи, шанс нанести критический урон возрастает до 25%");
                        player1.amul = "Зачарованный амулет удачи";
                        player1.sale = 10;
                    }
                    else Console.WriteLine(player1.TraderName + ": У тебя не хватает золота");
                }


            }
            Console.WriteLine(player1.TraderName + ": Возвращайся, как заработаешь еще.\n");
        }
    }
}
