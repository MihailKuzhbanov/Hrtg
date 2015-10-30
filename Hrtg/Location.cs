using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    public class Location
    {
        public int id;
        public string name, describe;
        public void move_low()
        {
            Random rnd = new Random();
            id = rnd.Next(3);
            switch (id)
            {
                case 0: name = "возле далекой опушки";
                    break;
                case 1: name = "на тихом озере";
                    break;
                case 2: name = "в заброшенной деревне";
                    break;
            }
        }
        public void move_norm()
        {
            Random rnd = new Random();
            id = rnd.Next(3);
            switch (id)
            {
                case 0: name = "в дремучих лесах";
                    break;
                case 1: name = "под большим деревом";
                    break;
                case 2: name = "на лугу";
                    break;
            }
        }
        public void move_boss1()
        {
            name = "в горящем подвале";
            describe = "Вокруг все забрызгано кровью. На стенах непонятные рисунки. На теле главы культистов прилеплены 2 банки наполненные кровью.\nГлава культистов: только достойный испить кровь может сражаться со мной на равных!";
        }
        public void move_1()
        {
            Random rnd = new Random();
            id = rnd.Next(1);
            switch (id)
            {
                case 0: name = "на первый этаж подземелья";
                    break;
                case 1: name = "на первый этаж подземелья";
                    break;

            }
        }
        public void move_2()
        {
            Random rnd = new Random();
            id = rnd.Next(1);
            switch (id)
            {
                case 0: name = "на второй этаж подземелья";
                    break;
                case 1: name = "на второй этаж подземелья";
                    break;

            }
        }
    }
}
