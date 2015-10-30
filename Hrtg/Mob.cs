using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    public class Mob
    {
        public int id, hp, dam, exp;
        public bool mag;
        public string DamageType;
        public string name, describe;
        public void Spawn_low1()
        {
            Random rnd = new Random();
            id = rnd.Next(2);
            switch (id)
            {
                case 0: name = "Собака"; describe = "На вид не очень дружелюбная собака"; hp = 5; dam = 2; exp = 10;
                    break;
                case 1: name = "Волк"; describe = "Выглядит устрашающе, но большой угрозы не представляет"; hp = 10; dam = 5; exp = 20;
                    break;

            }
        }
        public void Spawn_low2()
        {
            Random rnd = new Random();
            id = rnd.Next(2);
            switch (id)
            {
                case 1: name = "Волк"; describe = "Выглядит устрашающе, но большой угрозы не представляет"; hp = 10; dam = 5; exp = 20;
                    break;
                case 0: name = "Пьяный рабочий"; describe = "Вилы в его руках не внушают доверия, не думаю, что он собирается предложить вместе покидать сено"; hp = 30; dam = 10; exp = 30;
                    break;
            }
        }
        public void Spawn_norm1()
        {
            Random rnd = new Random();
            id = rnd.Next(3);
            switch (id)
            {
                case 1: name = "Бешенная лиса"; describe = "По ее глазам видно, что она голодна"; hp = 10; dam = 5; exp = 20;
                    break;
                case 2: name = "Сумасшедший культист"; describe = "В руках нож. В глазах сумасшествие."; hp = 30; dam = 20; exp = 50;
                    break;
                case 0: name = "Волк"; describe = "Выглядит устрашающе, но большой угрозы не представляет"; hp = 10; dam = 5; exp = 20;
                    break;
            }
        }
        public void Spawn_norm2()
        {
            Random rnd = new Random();
            id = rnd.Next(3);
            switch (id)
            {
                case 1: name = "Волк"; describe = "Выглядит устрашающе, но большой угрозы не представляет"; hp = 10; dam = 5; exp = 20;
                    break;
                case 2: name = "Темный силуэт"; describe = "Невозможно разглядеть кто это, слишком большой для человека. Взгляд на него вселяет ужас."; hp = 100; dam = 30; exp = 100;
                    break;
                case 0: name = "Огромная крыса"; describe = "Передвигается быстро, но едва ли способна прокусить одежду."; hp = 10; dam = 3; exp = 10;
                    break;
            }
        }
        public void Spawn_uncommon()
        {
            Random rnd = new Random();
            id = rnd.Next(5);
            switch (id)
            {
                case 1: name = "Служитель культа"; describe = "Бродят обычно толпами, этот видимо откололся от толпы"; hp = 60; dam = 10; exp = 20;
                    break;
                case 2: name = "Служитель культа"; describe = "Бродят обычно толпами, этот видимо откололся от толпы"; hp = 60; dam = 10; exp = 20;
                    break;
                case 0: name = "Призрак"; describe = "Выглядит неосязаемым, но его удары чувствуются сполна"; hp = 40; dam = 15; exp = 20;
                    break;
                case 3: name = "Маленький черт"; describe = "Довольно безобидный среди чертей"; hp = 50; dam = 15; exp = 20;
                    break;
                case 4: name = "Летучая мышь"; describe = "Обычный летучий грызун, ничего примечательного"; hp = 20; dam = 5; exp = 5;
                    break;

            }
        }
        public void Spawn_boss1()
        {
            Console.WriteLine("На пути стоит глава культистов.\nГлава культстов: Ты сможешь попасть в подземелье только через мой труп!");
            name = "Глава культистов"; hp = 100; dam = 150; exp = 100;
            describe = "В руке топор, выглядит злым, пускать не собирается. Придется дать ему то, что он требует - его труп.";
            Console.WriteLine("Необходимо ослабить противника. Думаю что-то может помочь в этом деле.");
        }
        public void Spawn_1()
        {
            Random rnd = new Random();
            id = rnd.Next(5);
            switch (id)
            {
                case 1: name = "Сатанист"; describe = "Произносит какие то заклинания, в руках светящаяся палка"; hp = 60; dam = 15; exp = 20; mag = true;
                    break;
                case 2: name = "Скелет меченосец"; describe = "Громко бренчит костями"; hp = 40; dam = 20; exp = 15;
                    break;
                case 0: name = "Скелет копейщик"; describe = "Громко бренчит костями"; hp = 40; dam = 25; exp = 15;
                    break;
                case 3: name = "Скелет лучник"; describe = "Громко бренчит костями"; hp = 40; dam = 30; exp = 20;
                    break;
                case 4: name = "Безоружный скелет"; describe = "Скелет неудачник, ему не досталось оружия, однако получать костями тоже не очень приятно"; hp = 40; dam = 10; exp = 10;
                    break;

            }
        }
        public void Spawn_2()
        {
            Random rnd = new Random();
            id = rnd.Next(5);
            switch (id)
            {
                case 1: name = "Скелет в железных доспехах"; describe = "Опасный противник"; hp = 65; dam = 20; exp = 15;
                    break;
                case 2: name = "Скелет меченосец"; describe = "Громко бренчит костями"; hp = 40; dam = 20; exp = 10;
                    break;
                case 0: name = "Скелет копейщик"; describe = "Громко бренчит костями"; hp = 40; dam = 25; exp = 10;
                    break;
                case 3: name = "Скелет лучник"; describe = "Громко бренчит костями"; hp = 40; dam = 30; exp = 15;
                    break;
                case 4: name = "Двухголовый черт"; describe = "Мелкий, но в руках держит что-то похожее на огненные шары. Не думаю, что моя броня меня спасет от огня."; hp = 50; dam = 15; exp = 20; mag = true;
                    break;

            }
        }
        public void Spawn_11()
        {
            Random rnd = new Random();
            id = rnd.Next(3);
            switch (id)
            {
                case 1: name = "Темный дух"; describe = "Кидается темными сгустками"; hp = 70; dam = 15; exp = 20; mag = true;
                    break;
                case 2: name = "Двухголовый волк"; describe = "Огромная пасть, глаза горят, буквально"; hp = 40; dam = 25; exp = 20;
                    break;
                case 0: name = "Живой огонь"; describe = "Непонятно как оно движется и живое ли вообще"; hp = 30; dam = 30; exp = 15; mag = true;
                    break;

            }
        }
        public void Spawn_12()
        {
            Random rnd = new Random();
            id = rnd.Next(4);
            switch (id)
            {
                case 1: name = "Живой мертвец"; describe = "Совсем недавно восстал из мертвых"; hp = 90; dam = 25; exp = 20; 
                    break;
                case 2: name = "Огненный элементаль"; describe = "Полыхает огнем, находиться рядом очень жарко"; hp = 70; dam = 45; exp = 20; mag = true;
                    break;
                case 0: name = "Темный маг"; describe = "Говорит что-то неразборчивое и махает руками, все не безрезультатно, огонь и лед летят во все стороны"; hp = 50; dam = 50; exp = 15; mag = true;
                    break;
                case 3: name = "Железный голем"; describe = "Огромная махина, которую тяжело убить доступными мне средставми"; hp = 100; dam = 50; exp = 25; 
                    break;

            }
        }
        public void Spawn_13()
        {
            Random rnd = new Random();
            id = rnd.Next(3);
            switch (id)
            {
                case 1: name = "Бешенный вепрь"; describe = "Чем-то явно напуган"; hp = 90; dam = 25; exp = 20;
                    break;
                case 2: name = "Разбойник с дороги"; describe = "Ничего хорошего не сулит встречу с разбойником"; hp = 80; dam = 35; exp = 20; 
                    break;
                case 0: name = "Заклинатель"; describe = "Промышляет тем же, что и разбойники, но не использует для этого нож"; hp = 70; dam = 50; exp = 25; mag = true;
                    break;
            }
        }
        public void Spawn_14()
        {
            Random rnd = new Random();
            id = rnd.Next(4);
            switch (id)
            {
                case 1: name = "Порабощенный солдат Гвисада"; describe = "Разум захвачен темными силами"; hp = 100; dam = 35; exp = 20;
                    break;
                case 2: name = "Порабощенный житель Гвисада"; describe = "Мирных жителей поработили и отправили работать"; hp = 40; dam = 15; exp = 5;
                    break;
                case 0: name = "Солдат темного легиона"; describe = "Один из захватчиков"; hp = 120; dam = 45; exp = 25;
                    break;
                case 3: name = "Маг темного легиона"; describe = "Занимается порабощением населением Гвисада"; hp = 80; dam = 60; exp = 25; mag = true;
                    break;
            }
        }
        public void Spawn_15()
        {
            Random rnd = new Random();
            id = rnd.Next(2);
            switch (id)
            {
                case 1: name = "Боевой маг темного легиона"; describe = "Крайне опасный противник, умеет не только сжигать, но и обладает хорошей защитой."; hp = 150; dam = 40; exp = 25; mag = true;
                    break;
                case 0: name = "Солдат темного легиона"; describe = "Один из захватчиков"; hp = 120; dam = 45; exp = 25;
                    break;

            }
        }
        public void Spawn_16()
        {
            Random rnd = new Random();
            id = rnd.Next(4);
            switch (id)
            {
                case 0: name = "Боевой маг темного легиона"; describe = "Крайне опасный противник, умеет не только сжигать, но и обладает хорошей защитой."; hp = 170; dam = 40; exp = 15; mag = true;
                    break;
                case 1: name = "Солдат темного легиона"; describe = "Один из захватчиков"; hp = 160; dam = 60; exp = 10;
                    break;
                case 2: name = "Жрец тьмы"; describe = "Может призывать на свою сторону различных демонов, сам драться не умеет"; hp = 220; dam = 45; exp = 15;
                    break;
                case 3: name = "Сверкающая тень"; describe = "Вселяет ужас"; hp = 100; dam = 65; exp = 20; mag = true;
                    break;
            }
        }
        public void Spawn_17()
        {
            Random rnd = new Random();
            id = rnd.Next(2);
            switch (id)
            {
                case 0: name = "Боевой маг темного легиона"; describe = "Крайне опасный противник, умеет не только сжигать, но и обладает хорошей защитой."; hp = 170; dam = 40; exp = 15; mag = true;
                    break;
                case 1: name = "Солдат темного легиона"; describe = "Один из захватчиков"; hp = 160; dam = 60; exp = 10;
                    break;

            }
        }
        public void Spawn_18a()
        {
            Random rnd = new Random();
            id = rnd.Next(1);
            switch (id)
            {
                case 0: name = "Прислужник Лиатины"; describe = "Одет в тяжелую броню."; hp = 120; dam = 70; exp = 15; 
                    break;
            }
        }
        public void Spawn_18b()
        {
            Random rnd = new Random();
            id = rnd.Next(2);
            switch (id)
            {
                case 0: name = "Убийца из темного культа"; describe = "Острые ножи и умение быстро двигаться это опасное сочетание."; hp = 140; dam = 80; exp = 20;
                    break;
                case 1: name = "Теневая гончая"; describe = "Внешне напоминает собаку, но из нее тянутся щупальца, которые выглядят магическими."; hp = 100; dam = 50; exp = 25; mag = true;
                    break;

            }
        }
        public void FinalA()
        {
            name = "Старик"; describe = "Вел двойную игру, использовал нас, чтобы прикрыть свою задницу."; hp = 650; dam = 80; exp = 100; mag = true;
        }
        public void FinalB()
        {
            name = "Лиатина"; describe = "Набрав достаточное количество темной магии в свое тело стала весьма сильной."; hp = 570; dam = 90; exp = 100; mag = true;
        }
    }
}
