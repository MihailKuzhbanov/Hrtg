using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrtg
{
    class Dialog
    {
        static public void Dialog2(string PlayerName)
        {
            Console.WriteLine(PlayerName+": Утратив работу в армии, мне некуда идти.");
            Console.WriteLine(PlayerName+": Придется вернуться домой и работать где попало.");
        }
        static public void Dialog3(string PlayerName)
        {
            Console.WriteLine(PlayerName+": Здесь достаточно небезопасно и начинает холодать.");
            Console.WriteLine(PlayerName+": Было бы хорошо успеть домой до заката.");
        }
        static public void Dialog4(string PlayerName)
        {
            Console.WriteLine(PlayerName + ": Дорога домой лежит через тоннель в горе.");
            Console.WriteLine(PlayerName + ": Это место сильно изменилось с тех пор, когда я был здесь в последний раз.");
            Console.WriteLine(PlayerName+": Здесь ходит много людей, одетые в одинаковую одежду, большинство из них измазаны кровью, ведут себя не очень дружелюбно.");
        }
        static public void Dialog6(string PlayerName)
        {
            Console.WriteLine(PlayerName + ": Повезло, что этот больной ублюдок оказался один.");
            Console.WriteLine(PlayerName + ": Чтобы пройти на ту сторону горы придется спускаться вниз.");
        }
        static public void Dialog7(string PlayerName)
        {
            Console.WriteLine(PlayerName+ ": Чем ниже спускаюсь, тем темнее становится.");
        }
        static public void Dialog10_1( string PlayerName)
        {
            
            Console.WriteLine("Вы висите вверх ногами, слыша лязгание металла.");
            Console.WriteLine("Шепот из тени: ты живой? я не опоздал?");
            Console.WriteLine("Повернув голову вы обнаруживаете таинственного торговца.");
            Console.WriteLine(PlayerName + ": вытащи меня отсюда, где я нахожусь, что это была за тварь?");
            Console.WriteLine("Таинственный торговец: не знаю как тебя сюда занесло, но спасти твою задницу в моих интересах, без тебя моих клиентов поубавится.");
            Console.WriteLine("Раздается громкий вой, слышатся шаги приближающиеся к двери.");
            Console.WriteLine(PlayerName + ": поторопись!");
            Console.WriteLine("Таинственный торговец: еще пара мгновений...");
            Console.WriteLine("В дверь раздается сильный удар, несколько досок отлетают от двери.");
            Console.WriteLine("Таинственный торговец: я закрыл дверь, когда пришел сюда, на случай если нам не хватит времени.");
            Console.WriteLine(PlayerName + ": я смотрю ты не зря это сделал, однако дверь долго не протянет, поэтому лучше бы ты поторопился.");
            Console.WriteLine("Таинственный торговец: готово!");
            Console.WriteLine("Вы падаете на пол. Быстро хватаете свое оружие и замираете, глядя на дверь.");
            Console.WriteLine("Еще один удар и дверь не выдерживает и разлетается на куски, перед вами стоит огромная тварь, похожая на волка с головой ящерицы.");
                                    
        }
        static public void Dialog10_2(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nЯщероволк повержен, вы сильно измотаны.");
            Console.WriteLine(TraderName + ": Ты спас нас обоих, хоть я бы и не попал в эту передрягу, не последуй я за тобой. Вот возьми зелье, оно восстановит твои силы, за счет заведения.");
            Console.WriteLine(TraderName + ": Ладно, мне пора, больше не попадайся на уловки с криками о помощи.");
            Console.WriteLine(PlayerName + ": Спасибо, что спас мою задницу.");
            Console.WriteLine(PlayerName + ": Как тебя зовут?.");
            Console.WriteLine(TraderName + ": моё имя не имеет значения. Куда ты держишь путь?");
            Console.WriteLine(PlayerName + ": Я иду в город, куда всегда светит солнце.");
            Console.WriteLine(TraderName + ": Гвисад?");
            Console.WriteLine(PlayerName + ": Да.");
            Console.WriteLine(TraderName + ": До встречи.");
            Console.WriteLine(PlayerName + ": Стой! Не могу же я тебя называть -Эй ты, слышь как тебя там");
            Console.WriteLine(TraderName + ": Называй меня Деребин");
            TraderName = "Деребин";
            Console.WriteLine(TraderName + ": В гвисаде уже давно не светит солнце, но если ты туда направляешься, то сам скоро все увидишь");
            Console.WriteLine(TraderName + " исчезает в тенях.");
        }
        static public void Dialog13(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nВы выбираетесь из темных катакомб.");
            Console.WriteLine("До Гвисада осталось совсем немного.");
            Console.WriteLine("О чем говорил "+TraderName + "?");
            Console.WriteLine("Я должен узнать что случилось с городом, в котором я родился.");
        }
        static public void Dialog14(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nГвисад уже не похож на тот город в котором я родился.");
            Console.WriteLine("Стены местами развалены, над городом сгущается тьма, судя по всему город долго оборонялся.");
            Console.WriteLine(TraderName + ": Темный легион вторгся сюда полгода назад.");
            Console.WriteLine("Рядом неожиданно появляется "+TraderName+".");
            Console.WriteLine(PlayerName+": Опять ты? сюда ведет только одна дорога и она лежит через те подземелья, где мы оба чуть не сдохли. Я не видел тебя, как ты сюда добрался?");
            Console.WriteLine(TraderName+": Я знаю эти места хорошо и есть люди способные помочь мне с тем, чтобы я добрался сюда живым.");
            Console.WriteLine(TraderName+": Зачем ты идешь в Гвисад?");
            Console.WriteLine(PlayerName + ": Тут я родился и несколько недель назад меня выгнали из армии, без объяснения причин, мне ничего не оставалось, как вернуться домой.");
            Console.WriteLine(TraderName+": У меня появилось кое - что новенькое для тебя, обращайся, если не будешь справляться, а сейчас мне пора идти.");
            Console.WriteLine("Вы прощаетесь с "+TraderName+".");
            Console.WriteLine("Вы стоите на площади перед Гвисадом, кругом разруха и мирные жители сами на себя не похожи.");
            Console.WriteLine(PlayerName + ": Вряд ли я в одиночку смогу справиться с темным легионом, но хотя бы узнать, что здесь произошло не помешает.");
        }
        static public void Dialog15(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nПрорвавшись за стены Гвисада вы ищете место, где можно скрыться от толп солдат темного легиона.");
            Console.WriteLine("Увидев оружейную вы бежите к ней.");
            Console.WriteLine("Заперев дверь, вы удерживаете ее от напора солдат легиона.");
            Console.WriteLine("Вы чувствуете как дверь начинает нагреваться, напор на дверь ослаб.");
            Console.WriteLine("Из под двери начинает валить дым. Видимо они решили поджечь дверь.");
            Console.WriteLine("Вы отходите от двери и видите, как она загорается.");
            Console.WriteLine("В панике вы начинаете обыскивать оружейную.");
            Console.WriteLine("Найдя бочку с порохом, вы подкатываете ее к двери.");
            Console.WriteLine("Дверь сгорает, раздается взрыв бочки с порохом, несколько солдат отлетают");
            Console.WriteLine("Выиграв время, вы продолжаете поиски, но находите только зелье восстановления здоровья, зато целую коробку.");
            Console.WriteLine("Оказавшись в западне, вам предстоит принять бой. Бежать некуда.");
        }
        static public void Dialog16_1(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nКрик произнесенного заклинания и крышу оружейной срывает.");
            Console.WriteLine("Еще один крик и мгновенно сгорают стены.");
            Console.WriteLine("Вас окружили со всех сторон.");
            Console.WriteLine("Можно было бы попытаться побежать напролом, но бежать некуда.");
            Console.WriteLine("Враги подходят все ближе.");
            Console.WriteLine("Яркая вспышка!");
            Console.WriteLine("Вы падаете, ничего не в состоянии разглядеть что-либо.");
            Console.WriteLine("Вы теряете сознание...");
        }
        static public void Dialog16_2(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nОчнувшись вы начинаете оглядываться по сторонам.");
            Console.WriteLine("Хижина.Рядом старик.");
            Console.WriteLine(PlayerName+": Где я?");
            Console.WriteLine("Старик: Ты уже очнулся?");
            Console.WriteLine("Старик: Здесь нельзя долго оставаться.");
            Console.WriteLine("Старик: Я должен задать тебе всего один вопрос, чтобы знать тот ли кто мне нужен.");
            Console.WriteLine("Старик: Куда светит солнце?");
        }
        static public void Dialog16_3(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nСобрав свои вещи вы выходите на улицу.");
            Console.WriteLine("Кругом разруха и солдаты легиона.");
            Console.WriteLine(PlayerName + ": Видимо теперь пути обратно нет.");
            Console.WriteLine(PlayerName + ": Зачем я нужен тому старику? Его ли я встретил в подземельях?");
            Console.WriteLine(PlayerName + ": Что бы он делал, если бы я не смог добраться до сюда?");
            Console.WriteLine(PlayerName + ": Необходимо добраться до цитадели.");
        }
        static public void Dialog17(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nВы подходите к воротам цитадели.");
            Console.WriteLine("Старик в белых одеяниях уже ждет вас.");
            Console.WriteLine(PlayerName + ": Для вас видимо вообще нет сложностей пробираться через толпы легиона.");
            Console.WriteLine("Старик: Нам некогда разговаривать, скоро они начнут ритуал, и если мы не успеем до конца, то Гвисад станет дорогой в ад, по которой они войдут в наш мир.");
            Console.WriteLine(PlayerName + ": Хорошо. Но все же, у меня есть несколько вопросов. Кто вы такой? Что за ритуал они собираются провести? И кто они?");
            Console.WriteLine("Старик: Я запомнил вопросы, все ответы потом. Я зарядил твой меч, теперь твои удары станут сокрушительнее, но это не на долго.");
            Console.WriteLine("Старик начинает читать заклинания, необходимо оборонять его, от приближающихся толп врагов.");
        }
        static public void Dialog18_1(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nМагическая защита цитадели начала восстанавливаться.");
            Console.WriteLine("Старик взмахивает посохом и всех солдат темного легиона сбивает с ног и откидывает за пределы ворот.");
            Console.WriteLine(PlayerName + ": Почему сразу нельзя было так сделать?");
            Console.WriteLine("Старик падает на землю.");
            Console.WriteLine(PlayerName + ": Ты в порядке? Что с тобой?");
            Console.WriteLine("Старик: Все... все...");
            Console.WriteLine(PlayerName+": Что все? Все кончено? Скажи куда мне идти?");
            Console.WriteLine("Старик: Все нормально, надо просто немного отдохнуть.");
            Console.WriteLine("Старик: Переждем здесь до ночи, скоро придет Деребин.");
            Console.WriteLine(PlayerName+": Ты знаешь Деребина?");
            Console.WriteLine("Старик: Конечно знаю, нас обоих отправили прикрывать твою задницу.");
            Console.WriteLine(PlayerName+": Что значит отправили? Кто отправил?");
            Console.WriteLine("Старик: Слишком много вопросов, я должен отдохнуть.");
            Console.WriteLine("Старик засыпает");
            Console.WriteLine("Что происходит? Почему именно я? Зачем они меня сопровождают? Кому это все нужно?");
            Console.WriteLine(PlayerName+": Все выглядит так, как будто я попал в чью-то игру, при том без моего на то согласия.");
        }
        static public void Dialog18_2(string PlayerName, string TraderName)
        {
            Console.WriteLine("\nСтемнело, "+TraderName+" все еще не было.");
            Console.WriteLine("Старик просыпается, потягивается, достав бутыль воды отпивает и предлагает "+PlayerName);
            Console.WriteLine(PlayerName + ": Спасибо, я не хочу. Ты собирался рассказать мне кое-что.");
            Console.WriteLine("Старик: Да, помню. Напомни, что ты спрашивал?.");
            Console.WriteLine(PlayerName + ": Ты говорил, что запомнил мои вопросы...");
            Console.WriteLine("Старик: Хорошо, сейчас я все расскажу.");
            Console.WriteLine("Старик: Я сенатор этих земель в светлом братстве.");
            Console.WriteLine(PlayerName+": Братстве?");
            Console.WriteLine("Старик: Ну легионе, мы называем себя светлым братством, все знают нас как светлый легион, разницы никакой.");
            Console.WriteLine("Старик: Несколько лет назад Гвисад стал меняться, сначало мы не придавали этому значения, но когда над ним перестало светить солнце...");
        }
        static public void Dialog18_3(string PlayerName, string TraderName)
        {
            Console.WriteLine("Старик: Тогда было уже поздно, мы отправили войска сюда, в надежде, что они смогут подавить темный легион.");
            Console.WriteLine(PlayerName+": Я был тогда в армии, я не мог не знать, что кто-то направляется в мой родной город.");
            Console.WriteLine("Старик: Это не предавалось огласке, мы планировали провернуть все за одну ночь. Темный легион не должен был знать о наших планах.");
            Console.WriteLine("Старик: Но войска были разбиты еще на подходе к городу, после чего темный легион оккупировал проход в скале.");
            Console.WriteLine("Старик: Мы знали, что у них много ушей по всему королевству, но не представляли, что настолько.");
            Console.WriteLine(PlayerName+": Это как то связано с тем, что меня выгнали из армии?");
            Console.WriteLine("Старик: Да, отличника службы просто так бы не стали выгонять.");
            Console.WriteLine("Старик: Мы знали, что ты первым делом отправишься сюда.");
            Console.WriteLine("Старик: Отправить тебя сюда официально было бы слишком рискованно.");
            Console.WriteLine("Старик: Темный легион собирается открыть портал. Если это им удастся, то лишь вопрос времени сколько нам осталось жить.");
        }
        static public void Dialog18_4(string PlayerName, string TraderName)
        {
            Console.WriteLine("Вдалеке показался Деребин.");
            Console.WriteLine(TraderName+": Скоро можно начинать.");
            Console.WriteLine("Старик: Где остальные солдаты?");
            Console.WriteLine(TraderName+": Они не уцелели, кто-то узнал о том, что мы собираемся сделать, они все попали в засаду.");
            Console.WriteLine("Старик: Это очень плохо, втроем нам придется не легко.");
            Console.WriteLine(PlayerName + ": Остальных вы отправили так же, как и меня?");
            Console.WriteLine(TraderName+": 14 отличников службы были выгнаны, под различными предлогами, ты был первым.");
            Console.WriteLine(TraderName+": Но им в отличии от тебя пришлось объяснить куда им стоит пойти.");
            Console.WriteLine(TraderName+": Ладно, пора действовать.");
        }
        static public void Dialog18_5(string PlayerName, string TraderName)
        {
            Console.WriteLine("Деребин развел костер, достал бумагу, на которой была изображена цитадель.");
            Console.WriteLine(TraderName + ": Днем охраны слишком много, чтобы ломиться втроем.");
            Console.WriteLine("Старик: Тогда очевидно, что нам придется дождаться ночи.");
            Console.WriteLine(TraderName + ": Ночью остается всего несколько часовых, но включается магическая защита, которая оповестит всех, если кто-то попадет под ее влияние.");
            Console.WriteLine(TraderName+": Ты не сможешь пойти ночью, тебя защита учует еще на подходе.");
            Console.WriteLine("Старик: Но без магии я бесполезен, быть вам абузой не лучший вариант, потому как без магии я буду скорее живым мертвецом, она поддерживает силы во мне последние 130 лет.");
            Console.WriteLine(TraderName + ": "+PlayerName+" тебе придется сделать выбор, пойти ночью, но тогда в нашем арсенале будут лишь ножи и мечи или дождаться утра и идти вам без меня, так как я не выдержу столь большие толпы, у меня нет ни защиты ни подходящего оружия.");
            Console.WriteLine("\n1.Пойти с Деребиным");
            Console.WriteLine("\n2. Пойти со стариком");
 
        }
        static public void Dialog18a(string PlayerName, string TraderName)
        {
            Console.WriteLine(PlayerName+": Мы с Деребиным попробуем пробраться.");
            Console.WriteLine("Старик: Вот камень, который необходимо будет кинуть в портал, ритуал уже начат, так что поторапливайтесь.");
            Console.WriteLine("Спустя десять минут, возле стен цитадели...");
            Console.WriteLine(TraderName+": Идем тихо, убиваем только при крайней необходимости.");
            Console.WriteLine(TraderName + ": Вот возьми, это поможет забраться на стену, лезть не высоко, главное добраться до того окна.");
            Console.WriteLine(PlayerName + ": Тебе не впервой этим заниматься. Может ты заберешься и кинешь мне веревку оттуда?");
            Console.WriteLine(TraderName+": Если не хочешь лезть, можешь дождаться утра и идти через парадный вход.");
            Console.WriteLine("Вы забираетесь в окно. Пройдя несколько этажей по лестнице вы попадаете в зал, заполненный охраной.");
            Console.WriteLine("Лиатина: А вот и вы, мы уж думали, что легион не постарается сорвать наши планы.");
            Console.WriteLine(PlayerName+": Кто это? они нас ждали!");
            Console.WriteLine("Лиатина: Разберитесь с ними, мне пора.");
        }
        static public void Dialog18b(string PlayerName, string TraderName)
        {
            Console.WriteLine(PlayerName + ": Пойдем через парадную, твои трюки с магией меня впечатлили.");
            Console.WriteLine("Старик: Если я не дойду до конца, заберешь этот камень и бросишь в портал, мы должны спасти этот мир.");
            Console.WriteLine("На рассвете...");
            Console.WriteLine(TraderName + ": Они отключили защиту, можете выдвигаться.");
            Console.WriteLine("Старик: Помни, ты должен прикрывать меня, одному тебе туда не дойти.");
            Console.WriteLine("Вы подходите к вратам, старик распахивает их. Можно двигаться в самое сердце цитадели.");
        }
        static public void Dialog19a(string PlayerName, string TraderName)
        {
            Console.WriteLine(TraderName + ": Портал в соседней комнате, там не должно быть солдат, беги, я задержу подмогу.");
            Console.WriteLine(PlayerName+": Возьми, это мой счастливый браслет, я много раз был на волосок от смерти.");
            Console.WriteLine(TraderName+": Нееет, ты ошибаешься. Ты был на волосок от жизни, именно в такие моменты я чувствую, как начинаю жить.\n"+TraderName+": Оставь браслет себе, я не верю в подобную ерунду.");
            Console.WriteLine("Вы попадаете в огромный зал, в конце которого стоит портал, из него виднеются руки, сделанные из тьмы.");
            Console.WriteLine(PlayerName + ": Эй, вся твоя армия мертва, прекрати, или мне придется тебя убить!");
            Console.WriteLine("Лиатина: К чему столь официально, просто убей меня, если сможешь!");
            Console.WriteLine("Вы бежите к Лиатине, замахиваетесь мечом...");
            Console.WriteLine("Вы очнулись на полу, рядом лежит меч, вы хотите взять его, но ваши руки вас не слушаются.");
            Console.WriteLine("Лиатина: Тяжело, неправда ли?");
            Console.WriteLine(PlayerName + ": Скоро придет целая толпа таких как я, тебе не справиться со всеми!");
            Console.WriteLine("Лиатина: И ты предлагаешь мне после этих слов прекратить все?.");
            Console.WriteLine(TraderName+": Я предлагаю тебе вернуться обратно в свое братство!");
            Console.WriteLine("Лиатина: Деребин! Опять мы с тобой встретились!");
            Console.WriteLine("Деребин бросает на пол банку с зельем, Лиатина начинает кашлять и падает на пол.");
            Console.WriteLine(TraderName+": Быстрее, кидай камень, что дал старик в портал!");
            Console.WriteLine("Вы кидаете камень в портал... \nПортал начинает сверкать, в центре появляется водоворот.");
            Console.WriteLine("Лиатина начинает смеяться.");
            Console.WriteLine(TraderName+"Все кончено, портал никогда не будет открыт в этих землях!");
            Console.WriteLine("Лиатина: Что же вы тогда только что сделали? Не закончили ли ритуал? Бросив туда камень бездны. Глупцы!");
            Console.WriteLine(PlayerName+": Что она говорит? Это тот камень, что дал мне старик.");
            Console.WriteLine("Старик: Совершенно верно, и ты закончил то, что начало братство света.");
            Console.WriteLine(TraderName+": Ты с ними заодно? ты из братства света, а не из легиона! Это ты был информатором!");
            Console.WriteLine(PlayerName+": Но зачем тебе нужен был я? Почему ты не убил меня сразу?");
            Console.WriteLine("Старик: Убив тебя, я бы раскрыл себя перед лицом светлого легиона, они бы сразу догадались, что я веду двойную игру.");
            Console.WriteLine(PlayerName+": Мерзкий старикашка, тебе не уйти отсюда живым!");
        }
        static public void Dialog19b(string PlayerName, string TraderName)
        {
            Console.WriteLine(PlayerName + ": Мы добрались!");
            Console.WriteLine("Лиатина: Вы как раз вовремя, ты принес камень?");
            Console.WriteLine("Старик: Да, он у "+PlayerName);
            Console.WriteLine("Лиатина: Светлый легион еще ничего не знает?");
            Console.WriteLine("Вы не можете пошевелиться.");
            Console.WriteLine("Старик: Нет, единственный свидетель, который знает, что я работаю на легион и на братство здесь и сейчас мы с ним покончим.");
            Console.WriteLine("Лиатина берет камень и несет его к порталу. Старик начинает читать заклинание.");
            Console.WriteLine("Лиатина бросает камень в портал, ее тело начинает подниматься, лучи из портала наполняют ее.");
            Console.WriteLine("На руках старика появляются молнии, кажется он скоро закончит.");
            Console.WriteLine("В окно влетает стрела, которая угодила старику в ногу.");
            Console.WriteLine(TraderName+" стоит в окне");
            Console.WriteLine(TraderName+": Тебе не удалось провести нас! Отпусти "+PlayerName);
            Console.WriteLine(TraderName+ " выпускает еще одну стрелу в старика, старик падает истекая кровью. В зал забегают солдаты, почти всех из них вы знаете, они тоже были отличниками службы.");
            Console.WriteLine("Лиатина: Для вас все кончено, портал открыт. С вами с разберусь лично!");
            Console.WriteLine("Лиатина взмахивает рукой и из портала вырываются стаи огромных чудовищ.");
            Console.WriteLine(TraderName+": Собак мы возьмем на себя! Разберись с ней.");
        }
        static public void Dialog20(string PlayerName, string TraderName)
        {
            Console.WriteLine(PlayerName + ": С ними покончено!");
            Console.WriteLine(TraderName+": Необходимо убираться отсюда, мы не справимся с открытым порталом, мы должны как можно скорее добраться до обители светлого легиона и сообщить им.");
        }
    }
}
