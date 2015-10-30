using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    public class Player
    {
        public int gold, score, hp, hp_max, damage, armor, lvl, head_hp, head_arm, head_dam, body_hp, body_arm, body_dam, pant_hp, pant_arm, pant_dam, weapon_hp, weapon_arm, weapon_dam, hand_hp, hand_arm, hand_dam, boot_hp, boot_arm, boot_dam, exp, hpot, hpot_max, v0,v1, v2, v3, v4, v5, sale;
        public string name, head_name, body_name, pant_name, weapon_name, hand_name, boot_name, amul;
        public bool trader;
        public string TraderName,Way;
        public void GameOver()
        {
            score = exp + hp_max + damage + armor;
            Console.WriteLine("Игра окончена, вы проиграли. Ваш счет: " + score + "\n\n\n" + "Для начала новой игры нажмите любую клавишу...");
            Console.ReadKey();
            Start();
        }
        public void ShowStat()
        {
            lvl = exp / 100 + 1;
            Console.WriteLine("\nХарактеристики:\t\t\tЭкипировка:\nУровень: " + lvl + " (опыт: " + exp + "/" + (lvl * 100) + ")" + "\tОружие: " + weapon_name + " (+ " + weapon_hp + " здоровья/+ " + weapon_dam + " урона/+ " + weapon_arm + " брони)" + "\nЗолото: " + gold + "\t\t\tГолова: " + head_name + " (+ " + head_hp + " здоровья/+ " + head_dam + " урона/+ " + head_arm + " брони)" + "\nЗдоровье: " + hp + "/" + hp_max + "\t\tТело: " + body_name + " (+ " + body_hp + " здоровья/+ " + body_dam + " урона/+ " + body_arm + " брони)" + "\nУрон: " + damage + " \t\t\tРуки: " + hand_name + " (+ " + hand_hp + " здоровья/+ " + hand_dam + " урона/+ " + hand_arm + " брони)" + "\nБроня: " + armor + "\t\t\tНоги: " + pant_name + " (+ " + pant_hp + " здоровья/+ " + pant_dam + " урона/+ " + pant_arm + " брони)" + "\nЛечебных зелий: " + hpot + "/" + hpot_max + "\t\tСтупни: " + boot_name + " (+ " + boot_hp + " здоровья/+ " + boot_dam + " урона/+ " + boot_arm + " брони)\n"+"Амулет: "+amul);
        }
        public void Start()
        {
            head_hp = head_arm = head_dam = body_hp = body_arm = body_dam = pant_hp = pant_arm = pant_dam = weapon_hp = weapon_arm = weapon_dam = hand_hp = hand_arm = hand_dam = boot_hp = boot_arm = boot_dam = 0;
            head_name = body_name = pant_name = weapon_name = hand_name = boot_name = amul = "ничего";
            trader = false;
            TraderName = "Таинственный торговец";
            gold = 100;
            hpot = 0;
            hpot_max = 5;
            exp = 0;
            score = 0;
            hp = 100;
            hp_max = 100;
            damage = 5;
            armor = 0;
            lvl = 1;
            v1 = 0;
            v2 = 0;
            v3 = 0;
            v4 = 0;
            v5 = 0;
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Для вызова справки напишите помощь,-h,/help. Если вы играете в первый раз, предлагаем ознакомиться с игрой(команда - инструкция).Приятной игры.\n\nВы оказываетесь на улице города. Вас только что выгнали из трактира.\nК вам подходит незнакомец, отдает вам свиток.\nНезнакомец: Воспользуйся этим, если заваляются лишние монеты.\nСтранствующий торговец гласит надпись на обороте свитка.\nНезнакомец уходит в даль, скрываясь в темноте переулков.\nВы идете к выходу из города, потому как держите путь в крепость Гвисад.\nХозяин трактира обещал убить если еще раз увидит.");
            
        }
        static public void EquipItem(Player player1, Item itm1)
        {
            if (itm1.slt == 1)
            {
                Console.WriteLine("Вы надеваете: " + itm1.name);
                player1.hp_max = player1.hp_max - player1.pant_hp;
                player1.armor = player1.armor - player1.pant_arm;
                player1.damage = player1.damage - player1.pant_dam;
                player1.pant_hp = 0; player1.pant_arm = 0; player1.pant_dam = 0;
                player1.pant_name = itm1.name; player1.pant_hp = itm1.hp_bns; player1.pant_arm = itm1.arm_bns; player1.pant_dam = itm1.dam_bns;
                player1.hp_max = player1.hp_max + player1.pant_hp;
                player1.armor = player1.armor + player1.pant_arm;
                player1.damage = player1.damage + player1.pant_dam;
                itm1.name = "ничего";
            };
            if (itm1.slt == 2)
            {
                player1.hp_max = player1.hp_max - player1.body_hp;
                player1.armor = player1.armor - player1.body_arm;
                player1.damage = player1.damage - player1.body_dam;
                Console.WriteLine("Вы надеваете: " + itm1.name);
                player1.body_hp = 0; player1.body_arm = 0; player1.body_dam = 0;
                player1.body_name = itm1.name; player1.body_hp = itm1.hp_bns; player1.body_arm = itm1.arm_bns; player1.body_dam = itm1.dam_bns;
                player1.hp_max = player1.hp_max + player1.body_hp;
                player1.armor = player1.armor + player1.body_arm;
                player1.damage = player1.damage + player1.body_dam;
                itm1.name = "ничего";
            };
            if (itm1.slt == 3)
            {
                player1.hp_max = player1.hp_max - player1.head_hp;
                player1.armor = player1.armor - player1.head_arm;
                player1.damage = player1.damage - player1.head_dam;
                Console.WriteLine("Вы надеваете: " + itm1.name);
                player1.head_hp = 0; player1.head_arm = 0; player1.head_dam = 0;
                player1.head_name = itm1.name; player1.head_hp = itm1.hp_bns; player1.head_arm = itm1.arm_bns; player1.head_dam = itm1.dam_bns;
                player1.hp_max = player1.hp_max + player1.head_hp;
                player1.armor = player1.armor + player1.head_arm;
                player1.damage = player1.damage + player1.head_dam;
                itm1.name = "ничего";
            };
            if (itm1.slt == 4)
            {
                player1.hp_max = player1.hp_max - player1.weapon_hp;
                player1.armor = player1.armor - player1.weapon_arm;
                player1.damage = player1.damage - player1.weapon_dam;
                Console.WriteLine("Вы надеваете: " + itm1.name);
                player1.weapon_hp = 0; player1.weapon_arm = 0; player1.weapon_dam = 0;
                player1.weapon_name = itm1.name; player1.weapon_hp = itm1.hp_bns; player1.weapon_arm = itm1.arm_bns; player1.weapon_dam = itm1.dam_bns;
                player1.hp_max = player1.hp_max + player1.weapon_hp;
                player1.armor = player1.armor + player1.weapon_arm;
                player1.damage = player1.damage + player1.weapon_dam;
                itm1.name = "ничего";
            };
            if (itm1.slt == 5)
            {
                player1.hp_max = player1.hp_max - player1.hand_hp;
                player1.armor = player1.armor - player1.hand_arm;
                player1.damage = player1.damage - player1.hand_dam;
                Console.WriteLine("Вы надеваете: " + itm1.name);
                player1.hand_hp = 0; player1.hand_arm = 0; player1.hand_dam = 0;
                player1.hand_name = itm1.name; player1.hand_hp = itm1.hp_bns; player1.hand_arm = itm1.arm_bns; player1.hand_dam = itm1.dam_bns;
                player1.hp_max = player1.hp_max + player1.hand_hp;
                player1.armor = player1.armor + player1.hand_arm;
                player1.damage = player1.damage + player1.hand_dam;
                itm1.name = "ничего";
            };
            if (itm1.slt == 6)
            {
                player1.hp_max = player1.hp_max - player1.boot_hp;
                player1.armor = player1.armor - player1.boot_arm;
                player1.damage = player1.damage - player1.boot_dam;
                Console.WriteLine("Вы надеваете: " + itm1.name);
                player1.boot_hp = 0; player1.boot_arm = 0; player1.boot_dam = 0;
                player1.boot_name = itm1.name; player1.boot_hp = itm1.hp_bns; player1.boot_arm = itm1.arm_bns; player1.boot_dam = itm1.dam_bns;
                player1.hp_max = player1.hp_max + player1.boot_hp;
                player1.armor = player1.armor + player1.boot_arm;
                player1.damage = player1.damage + player1.boot_dam;
                itm1.name = "ничего";
            };
        }
        static public void HealingPotion(Player player1)
        {
            if (player1.hpot != 0)
            {
                if (player1.hp != player1.hp_max)
                {
                    player1.hp = player1.hp + 20 + 2 * player1.lvl;
                    if (player1.hp > player1.hp_max) player1.hp = player1.hp_max;
                    Console.WriteLine("Вы использовали лечащее зелье, восстановлено " + (20 + 2 * player1.lvl) + " здоровья");
                    player1.hpot--;
                }
                else Console.WriteLine("У вас полный запас здоровья");
            }
            else Console.WriteLine("У вас нет лечащих зелий");
        }
        static public void Inspect(Mob mob1, Item itm1, Player player1)
        {
            if (mob1.name != "никого")
            {
                if (mob1.mag == true)
                {
                    mob1.DamageType = "(магический)"; 
                }
                if (mob1.mag == false)
                {
                    mob1.DamageType = "(физический)";
                }
                Console.WriteLine("\n" + mob1.name + " - " + mob1.describe + "\nЗдоровье: " + mob1.hp + "\nУрон: " + mob1.dam + mob1.DamageType + "\n");
            }
            if (itm1.name != "ничего")
            {
                if (itm1.slt == 1) 
                { 
                    itm1.TempName = player1.pant_name; itm1.TempHp = player1.pant_hp; itm1.TempDamage = player1.pant_dam; itm1.TempArmor = player1.pant_arm;
                };
                if (itm1.slt == 2)
                {
                    itm1.TempName = player1.body_name; itm1.TempHp = player1.body_hp; itm1.TempDamage = player1.body_dam; itm1.TempArmor = player1.body_arm;
                };
                if (itm1.slt == 3)
                {
                    itm1.TempName = player1.head_name; itm1.TempHp = player1.head_hp; itm1.TempDamage = player1.head_dam; itm1.TempArmor = player1.head_arm;
                };
                if (itm1.slt == 4)
                {
                    itm1.TempName = player1.weapon_name; itm1.TempHp = player1.weapon_hp; itm1.TempDamage = player1.weapon_dam; itm1.TempArmor = player1.weapon_arm;
                };
                if (itm1.slt == 5)
                {
                    itm1.TempName = player1.hand_name; itm1.TempHp = player1.hand_hp; itm1.TempDamage = player1.hand_dam; itm1.TempArmor = player1.hand_arm;
                };
                if (itm1.slt == 6)
                {
                    itm1.TempName = player1.boot_name; itm1.TempHp = player1.boot_hp; itm1.TempDamage = player1.boot_dam; itm1.TempArmor = player1.boot_arm;
                };
                Console.WriteLine("\n\t\t\t\t\tЭкипировано:\n" + itm1.name +"\t\t\t" +itm1.TempName +  "\nБонус здоровья: " + itm1.hp_bns +"\t\t\t"+itm1.TempHp+ "\nБонус урона: " + itm1.dam_bns +"\t\t\t\t"+itm1.TempDamage +"\nБонус брони: " + itm1.arm_bns +"\t\t\t\t"+itm1.TempArmor +"\n" + itm1.describe + "\n");
            }
            if (mob1.name == "никого" && itm1.name == "ничего")
            {
                Console.WriteLine("Вокруг ничего интересного.");
            }
        }
        static public void Look(Mob mob1, Item itm1, Location loc1)
        {
            Console.WriteLine("\nВы находитесь " + loc1.name + ".");
            if (mob1.name != "никого") Console.WriteLine("Рядом находится: " + mob1.name);
            if (itm1.name != "ничего") Console.WriteLine("На полу валяется: " + itm1.name);
        }
        static public void Attack(Mob mob1, Player player1)
        {
            if (mob1.name == "никого") Console.WriteLine("Некого атаковать.");
            if (player1.lvl == 19)
            {
                int crit1;
                bool CritBonus1 = false;
                if (player1.amul == "Зачарованный амулет удачи")
                {
                    Random x = new Random();
                    crit1 = x.Next(100);
                    if (crit1 < 25) CritBonus1 = true;
                }
                if (player1.amul == "Амулет удачи")
                {
                    Random x = new Random();
                    crit1 = x.Next(100);
                    if (crit1 < 10) CritBonus1 = true;
                }
                if (CritBonus1 == true) { Console.WriteLine("\nВы атакуете, наносите " + (player1.damage * 2) + " урона(критическая атака) " + mob1.name); mob1.hp = mob1.hp - (2 * player1.damage); }
                if (CritBonus1 == false) { Console.WriteLine("\nВы атакуете, наносите " + player1.damage + " урона " + mob1.name); mob1.hp = mob1.hp - player1.damage; }
                if (mob1.mag == true) mob1.dam = mob1.dam + player1.armor;
                if (mob1.dam <= player1.armor)
                {
                    player1.hp = player1.hp - 1;
                    Console.WriteLine(mob1.name + " атакует вас, вы получаете 1 урона");
                }
                if (mob1.dam > player1.armor)
                {
                    if (player1.amul == "Амулет защиты")
                    {
                        player1.hp = player1.hp - 4 * (mob1.dam - player1.armor) / 5;
                        Console.WriteLine(mob1.name + " атакует вас, вы получаете " + 4 * (mob1.dam - player1.armor) / 5 + " урона");
                    }
                    if (player1.amul != "Амулет защиты")
                    {
                        player1.hp = player1.hp - (mob1.dam - player1.armor);
                        Console.WriteLine(mob1.name + " атакует вас, вы получаете " + (mob1.dam - player1.armor) + " урона");
                    }
                }
                if (mob1.mag == true) mob1.dam = mob1.dam - player1.armor;
                if (player1.hp <= 0)
                {
                    Console.WriteLine(mob1.name + " побеждает, вы умираете и начинаете гнить.");
                    player1.GameOver();
                    mob1.name = "никого";
                    mob1.mag = false;
                }
                if (mob1.hp <= 0)
                {
                    int chance, oldlvl, golddrop;
                    Console.WriteLine("Вы побеждаете " + mob1.name + " и получаете " + mob1.exp + " опыта.");
                    player1.exp = player1.exp + mob1.exp;
                    oldlvl = player1.lvl;
                    player1.lvl = player1.exp / 100 + 1;
                    if (oldlvl != player1.lvl)
                    {
                        player1.hp_max = player1.hp_max + 3;
                        player1.damage = player1.damage + 1;
                        player1.hpot_max++;
                        Console.WriteLine("Поздравляем! Вы достигли " + player1.lvl + " уровня. Максимальный запас здоровья увеличен на 3. Урон увеличен на 1. Максимальное количество зелий увеличено до " + player1.hpot_max + ".");
                    }
                }
            }
            if (player1.lvl != 19)
            {
            while (player1.hp > 0 && mob1.hp > 0)
            {
                int crit = 0;
                bool CritBonus = false;
                if (player1.amul == "Зачарованный амулет удачи")
                {
                    Random x = new Random();
                    crit = x.Next(100);
                    if (crit < 25) CritBonus = true;
                }
                if (player1.amul == "Амулет удачи")
                {
                    Random x = new Random();
                    crit = x.Next(100);
                    if (crit < 10) CritBonus = true;
                }
                if (CritBonus == true) { Console.WriteLine("\nВы атакуете, наносите " + (player1.damage * 2) + " урона(критическая атака) " + mob1.name); mob1.hp = mob1.hp - (2 * player1.damage); }
                if (CritBonus == false) { Console.WriteLine("\nВы атакуете, наносите " + player1.damage + " урона " + mob1.name); mob1.hp = mob1.hp - player1.damage; }
                if (mob1.mag == true) mob1.dam = mob1.dam + player1.armor;
                if (mob1.dam <= player1.armor)
                {
                    player1.hp = player1.hp - 1;
                    Console.WriteLine(mob1.name + " атакует вас, вы получаете 1 урона");
                }
                if (mob1.dam > player1.armor)
                {
                    if (player1.amul == "Амулет защиты")
                    {
                        player1.hp = player1.hp - 4 * (mob1.dam - player1.armor) / 5;
                        Console.WriteLine(mob1.name + " атакует вас, вы получаете " + 4 * (mob1.dam - player1.armor) / 5 + " урона");
                    }
                    if (player1.amul != "Амулет защиты")
                    {
                        player1.hp = player1.hp - (mob1.dam - player1.armor);
                        Console.WriteLine(mob1.name + " атакует вас, вы получаете " + (mob1.dam - player1.armor) + " урона");
                    }
                }
                if (mob1.mag == true) mob1.dam = mob1.dam - player1.armor;
                if (player1.hp <= 0)
                {
                    Console.WriteLine(mob1.name + " побеждает, вы умираете и начинаете гнить.");
                    player1.GameOver();
                    mob1.name = "никого";
                    mob1.mag = false;
                }
                if (mob1.hp <= 0)
                {
                    int chance, oldlvl, golddrop;
                    Console.WriteLine("Вы побеждаете " + mob1.name + " и получаете " + mob1.exp + " опыта.");
                    player1.exp = player1.exp + mob1.exp;
                    oldlvl = player1.lvl;
                    player1.lvl = player1.exp / 100 + 1;
                    if (oldlvl != player1.lvl)
                    {
                        player1.hp_max = player1.hp_max + 3;
                        player1.damage = player1.damage + 1;
                        player1.hpot_max++;
                        Console.WriteLine("Поздравляем! Вы достигли " + player1.lvl + " уровня. Максимальный запас здоровья увеличен на 3. Урон увеличен на 1. Максимальное количество зелий увеличено до " + player1.hpot_max + ".");
                    }
                    mob1.name = "никого";
                    mob1.mag = false;
                    Random rnd = new Random();
                    chance = rnd.Next(3);
                    if (chance == 2 && player1.hpot < player1.hpot_max)
                    {
                        Console.WriteLine("Вы получаете лечебное зелье");
                        player1.hpot++;
                    }
                    golddrop = rnd.Next(1, 11);
                    player1.gold = player1.gold + (golddrop * player1.lvl);
                    Console.WriteLine("Вы получаете " + (golddrop * player1.lvl) + " золота.");
                    if (player1.v1 == 2)
                    {
                        player1.v1 = 1; player1.hp = player1.hp_max;
                        Console.WriteLine("Вы чувствуете облегчение, ваши силы восстановлены. Можно продолжать путь.");
                    }
                    if (player1.v1 == 5)
                    {
                        player1.v1 = 6; player1.hp = player1.hp_max;
                        Dialog.Dialog10_2(player1.name, player1.TraderName);
                        player1.TraderName = "Деребин";
                        player1.lvl = 11;
                        player1.exp = 1000;
                        Console.WriteLine("Поздравляем! Вы достигли " + player1.lvl + " уровня. Максимальный запас здоровья увеличен на 3. Урон увеличен на 1. Максимальное количество зелий увеличено до " + player1.hpot_max + ".");
                    }
                }
            }
        }
        }
        static public void Move(Player player1, Mob mob1, Item itm1, Location loc1)
        {
            {
                if (player1.lvl == 1)
                {
                    loc1.move_low();
                    mob1.Spawn_low1();
                    itm1.Generate_low();
                    player1.v0 = 0;
                }
                if (player1.lvl == 2)
                {
                    if (player1.v0 == 0)
                    {
                        Dialog.Dialog2(player1.name);
                        player1.v0 = 1;
                    }
                    loc1.name = " в темном лесу";
                    mob1.Spawn_low2();
                    itm1.Generate_low();
                }
                if (player1.lvl == 3)
                {
                    if (player1.v0 == 1)
                    {
                        Dialog.Dialog3(player1.name);
                        player1.v0 = 2;
                    }
                    loc1.move_norm();
                    switch (loc1.id)
                    {
                        case 0:
                            mob1.Spawn_norm1();
                            itm1.Generate_norm();
                            break;
                        case 1:
                            mob1.Spawn_norm2();
                            itm1.Generate_norm();
                            break;
                    }
                }
                if (player1.lvl == 4)
                {
                    if (player1.v0 == 2)
                    {
                        Dialog.Dialog4(player1.name);
                        player1.v0 = 3;
                    }
                    loc1.name = " у подножия горы";
                    mob1.Spawn_uncommon();
                    itm1.Generate_uncommon();
                }
                if (player1.lvl == 5)
                {
                    loc1.move_boss1();
                    mob1.Spawn_boss1();
                    itm1.Generate_boss1();
                }
                if (player1.lvl == 6)
                {
                    if (player1.v0 == 3)
                    {
                        Dialog.Dialog6(player1.name);
                        player1.v0 = 4;
                    }
                    loc1.move_1();
                    mob1.Spawn_1();
                    itm1.Generate_1();
                }
                if (player1.lvl == 7 || player1.lvl == 8)
                {
                    if (player1.v0 == 4)
                    {
                        Dialog.Dialog6(player1.name);
                        player1.v0 = 5;
                    }
                    loc1.move_2();
                    mob1.Spawn_2();
                    itm1.Generate_2();
                }
                if (player1.lvl == 9)
                {
                    Console.WriteLine("Вы встречаете человека в белых одеяниях.\nОкрикнув его, он поворачивается, его глаза светятся синим.\nНезнакомец: приходи ко мне снова, когда узнаешь вопрос который я должен тебе задать.\nМожешь просить помощи, но врядли это поможет.");
                    string answer = Console.ReadLine();
                    if (answer == "куда светит солнце")
                    {
                        player1.lvl = player1.lvl + 1; Console.WriteLine("Незнакомец смеется в ответ и исчезает в ярком свете, вы чувствуете прилив сил."); player1.hp_max = player1.hp_max + 25; player1.hp = player1.hp_max;
                        answer = ""; player1.lvl = 10; player1.exp += 100;
                    };
                }
                if (player1.lvl == 10)
                {
                    loc1.name = " в темноте";
                    if (player1.v1 == 0)
                    {
                        Console.WriteLine("Вы попадаете в зал, окутанный темнотой.\nКажется что темнота становится материальна и тянется за вами.\nС трудом можно разглядеть распахнутую дверь, из которой еле виден свет.\nГде-то вдалеке слышится крик, зовущий на помощь.\n1.Пойти на крик\n2.Пойти в дверь");
                        player1.v1 = 3;
                    }
                    while (player1.v1 == 3)
                    {
                        string answ = Console.ReadLine();
                        if (answ == "1") { player1.v1 = 1; };
                        if (answ == "2") { player1.v1 = 2; };
                    }
                    if (player1.v1 == 1)
                    {
                        Console.WriteLine("Вы движетесь на звуки крика, доносящиеся откуда то из темноты.");
                        Console.WriteLine("Внезапно из темноты вырываются когти, которые хватают вас и вы теряете сознание.");
                        player1.v1 = 4;
                    }
                    if (player1.v1 == 2)
                    {
                        Console.WriteLine("Подойдя к двери, вы обнаруживаете там горящий факел, который весит над ботинками. \nЛучшему воину- гласит надпись на ботинках, рассматривая их, вы слышите, как за вами захлапывается дверь.\nВас окружает толпа существ похожих на тени.");
                        itm1.name = "Ботинки лучшего воина"; itm1.describe = "Докажи, что ты способен их носить."; itm1.hp_bns = 15; itm1.dam_bns = 10; itm1.arm_bns = 10; itm1.slt = 6;
                        mob1.name = "Толпа теней"; mob1.describe = "Неосязаемые, но оружие их отпугивает. Долго находиться с ними нельзя."; mob1.hp = 120; mob1.dam = 30; mob1.exp = 0;
                    }
                    if (player1.v1 == 4)
                    {

                        Dialog.Dialog10_1(player1.name);
                        player1.hp = player1.hp_max;
                        player1.v1 = 5;
                    }
                    if (player1.v1 == 5)
                    {
                        mob1.name = "Ящероволк"; mob1.describe = "Двуногая тварь, с острыми когтями, головой ящерицы и телом волка."; mob1.hp = 150; mob1.dam = 35; mob1.exp = 0;
                    }
                }
                if (player1.lvl == 11)
                {
                    itm1.Generate_11();
                    loc1.name = " в катакомбах";
                    mob1.Spawn_11();
                }
                if (player1.lvl == 12)
                {
                    itm1.Generate_12();
                    loc1.name = " выход из коридоров";
                    mob1.Spawn_12();
                }
                if (player1.lvl == 13)
                {
                    if (player1.v2 == 0)
                    {
                        Dialog.Dialog13(player1.name, player1.TraderName);
                        player1.v2 = 1;
                    }
                    loc1.name = " на пути в Гвисад";
                    //itm1.Generate_13();
                    mob1.Spawn_13();
                }
                if (player1.lvl == 14)
                {
                    if (player1.v2 == 1)
                    {
                        Dialog.Dialog14(player1.name, player1.TraderName);
                        player1.v2 = 2;
                    }
                    loc1.name = " возле стен Гвисада";
                    itm1.Generate_14();
                    mob1.Spawn_14();
                }
                if (player1.lvl == 15)
                {
                    if (player1.v2 == 2)
                    {
                        Dialog.Dialog15(player1.name, player1.TraderName);
                        player1.v2 = 3;
                        player1.hpot = player1.hpot_max;
                    }

                    loc1.name = "";
                    itm1.Generate_15();
                    mob1.Spawn_15();
                }
                if (player1.lvl == 16)
                {
                    if (player1.v2 == 3)
                    {
                        Dialog.Dialog16_1(player1.name, player1.TraderName);
                        player1.v2 = 4;
                    }
                    if (player1.v2 == 4)
                    {
                        Dialog.Dialog16_2(player1.name, player1.TraderName);
                        player1.v2 = 5;
                    }
                    while (player1.v2 == 5)
                    {
                        string Answer;
                        Answer = Console.ReadLine();
                        if (Answer == "Гвисад") { Console.WriteLine("Старик: Да, ты именно тот, кто мне нужен.\nСтарик: Встретимся возле цитадели, а сейчас мне пора идти."); player1.v2 = 6; };
                    }
                    if (player1.v2 == 6)
                    {
                        Dialog.Dialog16_3(player1.name, player1.TraderName);
                        player1.v2 = 7;
                    }
                    if (player1.v2 == 7)
                    {
                        loc1.name = " в Гвисаде";
                        itm1.Generate_16();
                        mob1.Spawn_16();
                    }
                }
                if (player1.lvl == 17)
                {
                    if (player1.v3 == 0)
                    {
                        Dialog.Dialog17(player1.name, player1.TraderName);
                        player1.v3 = 1;
                    }
                    if (player1.v3 == 1)
                    {
                        loc1.name = " возле ворот цитадели";
                        while (player1.v4 < 100)
                        {
                            int CountLeft = 0, CountCenter = 0, CountRight = 0;
                            string Answer;
                            Console.WriteLine("К вам приближается новая волна противников.\nС какой стороны отбиваться?\n1.Левый фланг\n2.Центр\n3.Правый фланг");
                            Answer = Console.ReadLine();
                            if (Answer == "1") { player1.v4 += 10; CountLeft++; Console.WriteLine("Атака с левого фланга отбита"); };
                            if (Answer == "2") { player1.v4 += 15; CountCenter++; Console.WriteLine("Атака с центра отбита"); };
                            if (Answer == "3") { player1.v4 += 10; CountRight++; Console.WriteLine("Атака с правого фланга отбита"); };
                            if (CountLeft > 4) { Console.WriteLine("Вы не уследили за правым флангом, вас и старика убивают."); player1.GameOver(); };
                            if (CountRight > 4) { Console.WriteLine("Вы не уследили за левым флангом, вас и старика убивают."); player1.GameOver(); };
                            if (CountCenter > 3) { Console.WriteLine("Вы не уследили за флангами, вас и старика убивают."); player1.GameOver(); };
                        }
                        if (player1.v4 >= 100)
                        {
                            player1.v3 = 2;
                        }
                    }
                    if (player1.v3 == 2)
                    {
                        Console.WriteLine("Старик заканчивает чтение заклинания, магическая защита снята с ворот.");
                        Console.WriteLine("Старик: скоро магическая защита вернется на ворота, мы должны продержаться.");
                        player1.v3 = 3;
                    }
                    if (player1.v3 == 3)
                    {
                        loc1.name = " за воротами цитадели";
                        mob1.Spawn_17();

                    }

                }
                if (player1.lvl == 18)
                {
                    if (player1.v3 == 3)
                    {
                        Dialog.Dialog18_1(player1.name, player1.TraderName);
                        player1.v3 = 4;
                    }
                    if (player1.v3 == 4)
                    {
                        Dialog.Dialog18_2(player1.name, player1.TraderName);
                        player1.v3 = 5;
                    }
                    if (player1.v3 == 5)
                    {
                        Dialog.Dialog18_3(player1.name, player1.TraderName);
                        player1.v3 = 6;
                    }
                    if (player1.v3 == 6)
                    {
                        Dialog.Dialog18_4(player1.name, player1.TraderName);
                        player1.v3 = 7;
                    }
                    if (player1.v3 == 7)
                    {
                        Dialog.Dialog18_5(player1.name, player1.TraderName);
                        player1.v3 = 8;
                    }
                    if (player1.v3 == 8)
                    {
                        while (player1.Way != "1" && player1.Way != "2")
                        {player1.Way = Console.ReadLine();}
                        player1.v3 = 9;
                    }
                    if (player1.v3 == 9 && player1.Way == "1")
                    {
                        Dialog.Dialog18a(player1.name, player1.TraderName);
                        mob1.Spawn_18a();
                        loc1.name = " в цитадели темного культа";
                    }
                    if (player1.v3 == 9 && player1.Way == "2")
                    {
                        Dialog.Dialog18b(player1.name, player1.TraderName);
                        mob1.Spawn_18b();
                        loc1.name = " в цитадели темного культа";
                    }

                }
                if (player1.lvl == 19)
                {
                    if (player1.v5 == 0 && player1.Way == "1")
                    {
                        Dialog.Dialog19a(player1.name, player1.TraderName);
                        player1.v5 = 1;
                    }
                    if (player1.v5 == 0 && player1.Way == "2")
                    {
                        Dialog.Dialog19b(player1.name, player1.TraderName);
                        player1.v5 = 1;
                    }
                    if (player1.v5 == 1 && player1.Way == "1")
                    {
                        mob1.FinalA();
                        player1.v5 = 2;
                    }
                    if (player1.v5 == 1 && player1.Way == "2")
                    {
                        mob1.FinalB();
                        player1.v5 = 2;
                    }
                    
                }
                if (player1.lvl == 20)    //заглушка
                {
                    if (player1.v5 == 2) { Dialog.Dialog20(player1.name, player1.TraderName); player1.v5 = 3; };
                    player1.score = player1.exp + player1.hp_max + player1.damage + player1.armor;
                    Console.WriteLine("Вы пришли к концу игры. \nПродолжение следует...\nВаш счет: " + player1.score);
                    Console.ReadKey();
                    player1.Start();
                }


                Console.WriteLine("\n\nВы находитесь " + loc1.name + " на полу валяется " + itm1.name + ".\nК вам приближается " + mob1.name);

            }
        }
    }
}
