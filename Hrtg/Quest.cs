using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    class Quest
    {
        string QuestName, QuestDescription, QuestGiver,Answer;
        int ReqLvl, Exp, Gold, Condition;
        public void NewQuest(Player player1)
        {
            if (player1.lvl == ReqLvl)
            {
                Console.WriteLine("Задание " + QuestName + "\n" + QuestGiver + ": " + QuestDescription);
                Condition = 0;
                Console.WriteLine("Принять задание?");
                while (Answer != "да" || Answer !="нет")
                Answer = Console.ReadLine();
                if (Answer == "да") Console.WriteLine("Вы принимаете задание "+QuestName);
                if (Answer == "нет") Console.WriteLine("Вы отказались от задания "+QuestName);
            }
        }
        public void CompleteQuest(Player player1)
        {
            if (Condition == 1)
            {
                Console.WriteLine("Вы выполнили задание " + QuestName);
                Console.WriteLine("Вы получаете " + Exp + " опыта и " + Gold + " золота");
                player1.exp += Exp;
                player1.gold += Gold;
            }
        }
        public void FailQuest()
        {
            Console.WriteLine("Вы не справились с заданием "+QuestName);
        }
    }
}
