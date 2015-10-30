using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Hrtg
{
    public class Game
    {
        static public int CheatArmor()
        {
            Console.WriteLine("God mode: on.\nEnjoy!");
            return 1000;
        }
        static public int CheatDamage()
        {
            Console.WriteLine("Terminator mode: on.\nEnjoy!");
            return 1000;
        }
        static public int CheatLevel()
        {
            int x;
            Console.WriteLine("Set level");
            x = Console.Read();
            Console.WriteLine("Level upped.\nEnjoy!");
            return x;
            
        }
        static public void ShowHelp()
        {
            Console.WriteLine("\n########################################\n\n\t Основные команды: \nпомощь\t\t\t\t/hlp\nидти\t\t\t\t/mov\nосмотреть\t\t\t/lkk\nизучить\t\t\t\t/ins\nсостояние\t\t\t/stt\nатака\t\t\t\t/att\nнадеть\t\t\t\t/eqp\nлечение\t\t\t\t/hup\nторговец\t\t\t/trd\nсохранить\t\t\t/sav\nзагрузить\t\t\t/lod \n\n########################################\n");
        }
        static public void ShowInstruction()
        {
            Console.WriteLine("\n########################################\n\t\t Основные команды: \nинструкция\nпомощь\t\t/hlp\nидти\t\t/mov\nосмотреть\t/lkk\nизучить\t\t/ins\nсостояние\t/stt\nатака\t\t/att\nнадеть\t\t/eqp\nлечение\t\t/hup\nторговец\t/trd\nсохранить\t/sav\nзагрузить\t/lod\n\t\t//aboutdev \n########################################\nИгровой процесс заключается в том, чтобы продвигаться из одной локации в другую, убивая монстров и собирая различные вещи.\nТак же вы можете изучать вещи и монстров которых видите(команда - изучить /ins), не забывайте следить за состоянием.\nПри увеличении уровня будут открываться новые локации.\nКоманды можно вводить как на русском, так и сокращенной форме(указаны рядом). Команды можно вводить первой буквой в английском написании, символ / ставить не обязательно\n########################################\n");
        }
        static public void ShowDev()
        {
            Console.WriteLine("\n****************************************\nThis game made by Scray.\n2nd March 2015 - Hrtg v0.93 - Beta\nFeedback and bugreports - scrayer@mail.ru\n\nЭта игра создана Scray.\n2 марта 2015 года - Hrtg v0.93 - бета версия\nОбратная связь и багрепорты - scrayer@mail.ru\n****************************************\n");
        }
        static public Player SaveGame(Player player1)
        {
            using (Stream writer = new FileStream("save.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Player));
                serializer.Serialize(writer, player1);
            }
            Console.WriteLine("Игра сохранена.");
            return player1;
        }
        static public Player LoadGame(Player player1)
        {
            using (Stream stream = new FileStream("save.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Player));
                player1 = (Player)serializer.Deserialize(stream);
            }
            Console.Clear();
            Console.WriteLine("Игра загружена.");
            return player1;
        }
        public void NewGame()
        {
            Player player1 = new Player();
            Location loc1 = new Location();
            Mob mob1 = new Mob();
            Item itm1 = new Item();
            player1.Start();                //перенести содержимое функции сюда же
            loc1.name = "на грязных улицах города";
            mob1.name = "никого";
            itm1.name = "ничего";
        }

    }
}
