using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace Hrtg
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string temp;
            Player player1 = new Player();
            Location loc1 = new Location();
            Mob mob1 = new Mob();
            Item itm1 = new Item();
            player1.Start();
            Console.Clear();
            Console.WriteLine("Для вызова справки напишите помощь,-h,/help. Если вы играете в первый раз, предлагаем ознакомиться с игрой(команда - инструкция).Приятной игры.\n\nВы оказываетесь на улице города. Вас только что выгнали из трактира.\nК вам подходит незнакомец, отдает вам свиток.\nНезнакомец: Воспользуйся этим, если заваляются лишние монеты.\nСтранствующий торговец гласит надпись на обороте свитка.\nНезнакомец уходит в даль, скрываясь в темноте переулков.\nВы идете к выходу из города, потому как держите путь в крепость Гвисад.\nХозяин трактира обещал убить если еще раз увидит.");
            loc1.name = "на грязных улицах города";
            mob1.name = "никого";
            itm1.name = "ничего";

            while (player1.name != null)
            {
                temp = Console.ReadLine();

                switch (temp)
                {
                        //sv_cheats 1
                    case "::iddqd":
                        player1.armor = Game.CheatArmor();
                        break;
                    case "::iwantpewpew":
                        player1.damage = Game.CheatDamage();
                        break;
                    case "//aboutdev":
                        Game.ShowDev();
                        break;
                    case "::setlevel":
                        player1.lvl = Game.CheatLevel();
                        player1.exp = (player1.lvl - 1) * 100;
                        break;
                        //sv_cheats 0
                    case "/sav":
                    case "/save":
                    case "сохранить":
                        player1 = Game.SaveGame(player1);
                        break;
                    case "/lod":
                    case "/load":
                    case "загрузить":
                        player1 = Game.LoadGame(player1);
                        break;
                    case "t":
                    case "/t":
                    case "/trd":
                    case "торговец":
                        {
                            Market.Trader(player1);
                        };
                        break;
                     case "m":
                     case "/m":
                     case "/mov":
                    case "/move":
                     case "идти":
                        Player.Move(player1, mob1,itm1,loc1);
                        break;
                    case "l":
                    case "/l":
                    case "/lkk":
                    case "/look":
                    case "осмотреть":
                        Player.Look( mob1, itm1, loc1);
                        break;
                    case "i":
                    case "/i":
                    case "/ins":
                    case "/inspect":
                    case "изучить":
                        if (player1.lvl == 5)
                        {
                            Console.WriteLine(loc1.describe);
                        }
                        
                        if (player1.lvl == 9)
                        {
                            Console.WriteLine("Может стоит попросить у кого то помощи");
                            break;
                        }
                        if (player1.lvl !=9 || player1.lvl !=5)
                        {
                            Player.Inspect(mob1,itm1,player1);
                        }
                        break;

                    case "s":
                    case "/s":
                    case "/stt":
                    case "/state":
                    case "состояние":
                        {
                            player1.ShowStat();
                        }
                        break;

                    case "/hlp":
                    case "/help":
                    case "помощь":
                        Game.ShowHelp();
                        if (player1.lvl == 9) Console.WriteLine("куда светит солнце");
                        break;

                    case "/instruction":
                    case "инструкция":
                        Game.ShowInstruction();
                        break;

                    case "h":
                    case "/h":
                    case "/hup":
                    case "/heal":
                    case "лечение":
                        Player.HealingPotion(player1);
                        if (mob1.name == "Глава культистов" && mob1.dam > 10)
                        {
                            Console.WriteLine("Вы выпиваете зелье и босс ослабевает");
                            mob1.dam = mob1.dam - 73;
                            mob1.hp = mob1.hp - 20;
                        }
                        break;

                    case "a":
                    case "/a":
                    case "/att":
                    case "/attack":
                    case "атака":
                        Player.Attack(mob1,player1);
                        
                        break;

                    case "e":
                    case "/e":
                    case "/eqp":
                    case "/equip":
                    case "надеть":
                        if (itm1.name == "ничего")
                        {
                            Console.WriteLine("Нечего одевать");
                            break; 
                        }
                        if ((mob1.hp == 0 || mob1.name == "никого"))
                        {
                            Player.EquipItem(player1, itm1);
                        }
                        else Console.WriteLine(mob1.name + " охраняет " + itm1.name + ", необходимо сначало убить его.");
                        break;

                        }
            }
            Console.ReadKey();
        }
    }
}
