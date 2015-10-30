using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{

        public class Item
        {
            public int id, hp_bns, dam_bns, arm_bns, slt, TempHp, TempDamage, TempArmor;
            public string name, describe, TempName;      
            public void Generate_low()
            {
                Random rnd = new Random();
                id = rnd.Next(6);
                switch (id)
                {
                    case 0:
                        {
                            name = "Плохие штаны"; describe = "Ничем не примечательные штаны, такие сейчас есть у каждого."; hp_bns = 1; dam_bns = 0; arm_bns = 0; slt = 1;
                            break;
                        }
                    case 1:
                        {
                            name = "Плохая накидка"; describe = "Ничем не примечательная накидка, сшитая за углом."; hp_bns = 1; dam_bns = 0; arm_bns = 1; slt = 2;
                        }
                        break;
                    case 2:
                        {
                            name = "Дырявая шляпа"; describe = "Потасканная шляпа. Источает не очень приятный запах"; hp_bns = 1; dam_bns = 0; arm_bns = 0; slt = 3;
                            break;
                        }
                    case 3:
                        {
                            name = "Деревянный меч"; describe = "Не более чем игрушка, к тому же, местами сломан и перемотан веревкой."; hp_bns = 0; dam_bns = 1; arm_bns = 0; slt = 4;
                            break;
                        }
                    case 4:
                        {
                            name = "Кожанные перчатки"; describe = "Достаточно прилично выглядят, но давно вышли из моды и еще не успели войти заново."; hp_bns = 1; dam_bns = 0; arm_bns = 0; slt = 5;
                            break;
                        }
                    case 5:
                        {
                            name = "Простые лапти"; describe = "Неудобная обувь, но на первое время сойдет."; hp_bns = 1; dam_bns = 0; arm_bns = 0; slt = 6;
                            break;
                        }
                }
            }
            public void Generate_norm()
            {
                Random rnd = new Random();
                id = rnd.Next(6);
                switch (id)
                {
                    case 0:
                        {
                            name = "Обычные штаны"; describe = "Толстые штаны, весьма удобны."; hp_bns = 1; dam_bns = 0; arm_bns = 1; slt = 1;
                            break;
                        }
                    case 1:
                        {
                            name = "Обычный плащ"; describe = "Плащ, хорошо защищает от укусов диких животных."; hp_bns = 1; dam_bns = 0; arm_bns = 2; slt = 2;
                        }
                        break;
                    case 2:
                        {
                            name = "Кожанный наголовник"; describe = "Зимой не греет, но от дождя укрывает."; hp_bns = 1; dam_bns = 0; arm_bns = 1; slt = 3;
                            break;
                        }
                    case 3:
                        {
                            name = "Затупившийся меч"; describe = "Таким проще забить до смерти, чем порезать."; hp_bns = 0; dam_bns = 3; arm_bns = 0; slt = 4;
                            break;
                        }
                    case 4:
                        {
                            name = "Плотные перчатки"; describe = "Перчатки плотника."; hp_bns = 1; dam_bns = 0; arm_bns = 1; slt = 5;
                            break;
                        }
                    case 5:
                        {
                            name = "Ботинки"; describe = "Удобно, но не очень надежно."; hp_bns = 1; dam_bns = 0; arm_bns = 1; slt = 6;
                            break;
                        }
                }
            }
            public void Generate_uncommon()
            {
                Random rnd = new Random();
                id = rnd.Next(6);
                switch (id)
                {
                    case 0:
                        {
                            name = "Расписные штаны"; describe = "Довольно редки, стоят неплохих денег."; hp_bns = 5; dam_bns = 0; arm_bns = 3; slt = 1;
                            break;
                        }
                    case 1:
                        {
                            name = "Куртка вора"; describe = "Каждый вор считает своим долгом раздобыть подобную."; hp_bns = 3; dam_bns = 2; arm_bns = 2; slt = 2;
                        }
                        break;
                    case 2:
                        {
                            name = "Клепанный шлем"; describe = "Хорошо защищает, по заверению продавца."; hp_bns = 3; dam_bns = 0; arm_bns = 3; slt = 3;
                            break;
                        }
                    case 3:
                        {
                            name = "Острый нож"; describe = "Отлично заточенное лезвие, несмотря на маленький размер выглядит опасным."; hp_bns = 0; dam_bns = 8; arm_bns = 0; slt = 4;
                            break;
                        }
                    case 4:
                        {
                            name = "Перчатки с клепками"; describe = "Отлично защищают руки, однако движения в них не очень резвы."; hp_bns = 0; dam_bns = 0; arm_bns = 3; slt = 5;
                            break;
                        }
                    case 5:
                        {
                            name = "Клепанные ботинки"; describe = "Тепло, удобно, относительно надежно, но ужасно тяжелые."; hp_bns = 0; dam_bns = 0; arm_bns = 3; slt = 6;
                            break;
                        }
                }
            }
            public void Generate_boss1()
            {
                name = "Окровавленный топор"; describe = "Топор главы культистов, выглядит внушающе"; hp_bns = 0; dam_bns = 12; arm_bns = 0; slt = 4;
            }
            public void Generate_1()
            {
                Random rnd = new Random();
                id = rnd.Next(6);
                switch (id)
                {
                    case 0:
                        {
                            name = "Штаны с меткой скелета"; describe = "Скелеты слабо защищены, однако достаточно живучи."; hp_bns = 10; dam_bns = 0; arm_bns = 1; slt = 1;
                            break;
                        }
                    case 1:
                        {
                            name = "Доспех путешественника"; describe = "Путешественник уже мертв, не думаю, что ему могут пригодиться доспехи."; hp_bns = 5; dam_bns = 0; arm_bns = 5; slt = 2;
                        }
                        break;
                    case 2:
                        {
                            name = "Шлем из толстой кожи"; describe = "Качественно сшит, видны царапины, видимо тот, кто его потерял умер после того как остался без шлема."; hp_bns = 5; dam_bns = 0; arm_bns = 3; slt = 3;
                            break;
                        }
                    case 3:
                        {
                            name = "Зачарованный меч"; describe = "Меч отдает странным свечением, не выглядит грозно, но взяв его в руки чувствуешь себя лучше."; hp_bns = 15; dam_bns = 5; arm_bns = 0; slt = 4;
                            break;
                        }
                    case 4:
                        {
                            name = "Перчатки канонира"; describe = "Позволяют быстро махать оружием, но слабо защищают."; hp_bns = 0; dam_bns = 3; arm_bns = 1; slt = 5;
                            break;
                        }
                    case 5:
                        {
                            name = "Зачарованные ботинки"; describe = "На удачу - гласит надпись на ботинках."; hp_bns = 15; dam_bns = 0; arm_bns = 1; slt = 6;
                            break;
                        }
                }
            }
            public void Generate_2()
            {
                Random rnd = new Random();
                id = rnd.Next(12);
                if (id < 6)
                {
                    switch (id)
                    {
                        case 0:
                            {
                                name = "Штаны с меткой скелета"; describe = "Скелеты слабо защищены, однако достаточно живучи."; hp_bns = 10; dam_bns = 0; arm_bns = 1; slt = 1;
                                break;
                            }
                        case 1:
                            {
                                name = "Доспех путешественника"; describe = "Путешественник уже мертв, не думаю, что ему могут пригодиться доспехи."; hp_bns = 5; dam_bns = 0; arm_bns = 5; slt = 2;
                            }
                            break;
                        case 2:
                            {
                                name = "Шлем из толстой кожи"; describe = "Качественно сшит, видны царапины, видимо тот, кто его потерял умер после того как остался без шлема."; hp_bns = 5; dam_bns = 0; arm_bns = 3; slt = 3;
                                break;
                            }
                        case 3:
                            {
                                name = "Зачарованный меч"; describe = "Меч отдает странным свечением, не выглядит грозно, но взяв его в руки чувствуешь себя лучше."; hp_bns = 15; dam_bns = 2; arm_bns = 0; slt = 4;
                                break;
                            }
                        case 4:
                            {
                                name = "Перчатки канонира"; describe = "Позволяют быстро махать оружием, но слабо защищают."; hp_bns = 0; dam_bns = 3; arm_bns = 1; slt = 5;
                                break;
                            }
                        case 5:
                            {
                                name = "Зачарованные ботинки"; describe = "На удачу - гласит надпись на ботинках."; hp_bns = 15; dam_bns = 0; arm_bns = 1; slt = 6;
                                break;
                            }
                    }
                }
            }
            public void Generate_11()
            {
                Random rnd = new Random();
                id = rnd.Next(12);
                if (id < 6)
                {
                    switch (id)
                    {
                        case 0:
                            {
                                name = "Кольчужные штаны"; describe = "Хорошо защищают, не сковывают движения."; hp_bns = 10; dam_bns = 5; arm_bns = 5; slt = 1;
                                break;
                            }
                        case 1:
                            {
                                name = "Кольчужный нагрудник"; describe = "Хорошо защищает, не сковывает движения."; hp_bns = 10; dam_bns = 5; arm_bns = 10; slt = 2;
                            }
                            break;
                        case 2:
                            {
                                name = "Шлем из кольчуги"; describe = "Хороший обзор, малый вес."; hp_bns = 5; dam_bns = 0; arm_bns = 5; slt = 3;
                                break;
                            }
                        case 3:
                            {
                                name = "Меч с гравировкой щита"; describe = "Опасное оружие в умелых руках."; hp_bns = 0; dam_bns = 15; arm_bns = 2; slt = 4;
                                break;
                            }
                        case 4:
                            {
                                name = "Кольчужные перчатки"; describe = "Позволяют быстро махать оружием, хорошо защищают."; hp_bns = 0; dam_bns = 2; arm_bns = 3; slt = 5;
                                break;
                            }
                        case 5:
                            {
                                name = "Кольчужные ботинки"; describe = "Легкие, защищают от всего, кроме страха."; hp_bns = 0; dam_bns = 0; arm_bns = 3; slt = 6;
                                break;
                            }
                    }
                }
            }
            public void Generate_12()
            {
                Random rnd = new Random();
                id = rnd.Next(12);
                if (id < 6)
                {
                    switch (id)
                    {
                        case 0:
                            {
                                name = "Штаны из драконьей шкуры"; describe = "Отличные показатели защиты."; hp_bns = 0; dam_bns = 0; arm_bns = 15; slt = 1;
                                break;
                            }
                        case 1:
                            {
                                name = "Кольчужный нагрудник"; describe = "Хорошо защищает, не сковывает движения."; hp_bns = 10; dam_bns = 5; arm_bns = 10; slt = 2;
                            }
                            break;
                        case 2:
                            {
                                name = "Шлем гнева"; describe = "Одев его чувствуешь ненависть ко всему, что тебя окружает."; hp_bns = 0; dam_bns = 5; arm_bns = 7; slt = 3;
                                break;
                            }
                        case 3:
                            {
                                name = "Меч с гравировкой щита"; describe = "Опасное оружие в умелых руках."; hp_bns = 0; dam_bns = 15; arm_bns = 2; slt = 4;
                                break;
                            }
                        case 4:
                            {
                                name = "Пылающие перчатки"; describe = "Горят огнем, но не обжигают владельца."; hp_bns = 0; dam_bns = 7; arm_bns = 3; slt = 5;
                                break;
                            }
                        case 5:
                            {
                                name = "Кольчужные ботинки"; describe = "Легкие, защищают от всего, кроме страха."; hp_bns = 0; dam_bns = 0; arm_bns = 3; slt = 6;
                                break;
                            }
                    }
                }
            }
            public void Generate_13()
            {
                Random rnd = new Random();
                id = rnd.Next(12);
                if (id < 6)
                {
                    switch (id)
                    {
                        case 0:
                            {
                                name = "Штаны из драконьей шкуры"; describe = "Отличные показатели защиты."; hp_bns = 0; dam_bns = 0; arm_bns = 15; slt = 1;
                                break;
                            }
                        case 1:
                            {
                                name = "Кольчужный нагрудник"; describe = "Хорошо защищает, не сковывает движения."; hp_bns = 10; dam_bns = 5; arm_bns = 10; slt = 2;
                            }
                            break;
                        case 2:
                            {
                                name = "Шлем гнева"; describe = "Одев его чувствуешь ненависть ко всему, что тебя окружает."; hp_bns = 0; dam_bns = 5; arm_bns = 7; slt = 3;
                                break;
                            }
                        case 3:
                            {
                                name = "Меч с гравировкой щита"; describe = "Опасное оружие в умелых руках."; hp_bns = 0; dam_bns = 15; arm_bns = 2; slt = 4;
                                break;
                            }
                        case 4:
                            {
                                name = "Пылающие перчатки"; describe = "Горят огнем, но не обжигают владельца."; hp_bns = 0; dam_bns = 7; arm_bns = 3; slt = 5;
                                break;
                            }
                        case 5:
                            {
                                name = "Кольчужные ботинки"; describe = "Легкие, защищают от всего, кроме страха."; hp_bns = 0; dam_bns = 0; arm_bns = 3; slt = 6;
                                break;
                            }
                    }
                }
            }
            public void Generate_14()
            {
                Random rnd = new Random();
                id = rnd.Next(12);
                if (id < 6)
                {
                    switch (id)
                    {
                        case 0:
                            {
                                name = "Кольчужные штаны"; describe = "Легкие, удобные, про показатели защиты ничего подобного не скажешь."; hp_bns = 10; dam_bns = 3; arm_bns = 5; slt = 1;
                                break;
                            }
                        case 1:
                            {
                                name = "Поломанный нагрудник Гвисада"; describe = "Если бы удалось его починить, то он определенно стал бы отличной вещью."; hp_bns = 25; dam_bns = 0; arm_bns = 10; slt = 2;
                            }
                            break;
                        case 2:
                            {
                                name = "Зачарованный шлем"; describe = "Одев его чувствуешь прилив сил."; hp_bns = 35; dam_bns = 0; arm_bns = 3; slt = 3;
                                break;
                            }
                        case 3:
                            {
                                name = "Меч Гвисада"; describe = "Такое оружие используют все солдаты в Гвисаде."; hp_bns = 0; dam_bns = 17; arm_bns = 0; slt = 4;
                                break;
                            }
                        case 4:
                            {
                                name = "Перчатки из драконьей шкуры"; describe = "Отличные показатели защиты"; hp_bns = 0; dam_bns = 0; arm_bns = 15; slt = 5;
                                break;
                            }
                        case 5:
                            {
                                name = "Кольчужные ботинки"; describe = "Легкие, защищают от всего, кроме страха."; hp_bns = 0; dam_bns = 0; arm_bns = 3; slt = 6;
                                break;
                            }
                    }
                }
            }
            public void Generate_15()
            {
                Random rnd = new Random();
                id = rnd.Next(12);
                if (id < 6)
                {
                    switch (id)
                    {
                        case 0:
                            {
                                name = "Кольчужные штаны"; describe = "Легкие, удобные, про показатели защиты ничего подобного не скажешь."; hp_bns = 10; dam_bns = 3; arm_bns = 5; slt = 1;
                                break;
                            }
                        case 1:
                            {
                                name = "Поломанный нагрудник Гвисада"; describe = "Если бы удалось его починить, то он определенно стал бы отличной вещью."; hp_bns = 25; dam_bns = 0; arm_bns = 10; slt = 2;
                            }
                            break;
                        case 2:
                            {
                                name = "Зачарованный шлем"; describe = "Одев его чувствуешь прилив сил."; hp_bns = 35; dam_bns = 0; arm_bns = 3; slt = 3;
                                break;
                            }
                        case 3:
                            {
                                name = "Меч Гвисада"; describe = "Такое оружие используют все солдаты в Гвисаде."; hp_bns = 0; dam_bns = 17; arm_bns = 0; slt = 4;
                                break;
                            }
                        case 4:
                            {
                                name = "Перчатки из драконьей шкуры"; describe = "Отличные показатели защиты"; hp_bns = 0; dam_bns = 0; arm_bns = 15; slt = 5;
                                break;
                            }
                        case 5:
                            {
                                name = "Кольчужные ботинки"; describe = "Легкие, защищают от всего, кроме страха."; hp_bns = 0; dam_bns = 0; arm_bns = 3; slt = 6;
                                break;
                            }
                    }
                }
            }
            public void Generate_16()
            {
                Random rnd = new Random();
                id = rnd.Next(12);
                if (id < 6)
                {
                    switch (id)
                    {
                        case 0:
                            {
                                name = "Штаны легиона"; describe = "Такие носят солдаты темного легиона."; hp_bns = 20; dam_bns = 6; arm_bns = 10; slt = 1;
                                break;
                            }
                        case 1:
                            {
                                name = "Нагрудник Гвисада"; describe = "Отличная вещь."; hp_bns = 50; dam_bns = 0; arm_bns = 20; slt = 2;
                            }
                            break;
                        case 2:
                            {
                                name = "Шлем Гвисада"; describe = "Шлем воинов Гвисада."; hp_bns = 45; dam_bns = 0; arm_bns = 10; slt = 3;
                                break;
                            }
                        case 3:
                            {
                                name = "Секира легиона"; describe = "Видно, что над этим оружием потрудились маги легиона."; hp_bns = 20; dam_bns = 30; arm_bns = 0; slt = 4;
                                break;
                            }
                        case 4:
                            {
                                name = "Перчатки из стали"; describe = "Такие носит Деребин"; hp_bns = 10; dam_bns = 10; arm_bns = 10; slt = 5;
                                break;
                            }
                        case 5:
                            {
                                name = "Ботинки из стали"; describe = "В таких ногам ничего не грозит."; hp_bns = 10; dam_bns = 10; arm_bns = 10; slt = 6;
                                break;
                            }
                    }
                }
            }
    }
}
