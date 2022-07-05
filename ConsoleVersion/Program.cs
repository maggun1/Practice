using System;
using System.Threading;

namespace ConsoleVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Console.WriteLine("Нажмите любую клавишу, чтобы начать...");
                //Console.ReadKey(true);
                //Console.Clear();

                //Console.WriteLine("Звуки стучащих по покрытой снегом дороге колес повозки. Ты открываешь глаза. \nПеред тобой сидит один из братьев Бури, Ралоф, по правую руку от него – Локир, обычный вор.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Ралоф поворачивается лицом к тебе и говорит: \n-Эй ты. Не спишь? Ты нарушитель границы, так? Надо же тебе было налететь на имперскую засаду. \nОни и нас поймали и ворюгу этого.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("В диалог вступает Локир: \n-Проклятые братья Бури. В Хоринисе было тихо пока вас сюда не принесло. И Империи не до чего дела не было. \nЕсли бы вас не искали, я бы сейчас украл вон ту лошадь и рванул в Хаммерфелл!\n");
                //Console.ReadKey(true);
                //Console.WriteLine("-Мы все сейчас братья и сестры по судьбе, ворюга.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Позади, мы слышим недовольный крик конвоира: \n-A ну все заткнулись!\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Заметив, сидящего напротив Локира, Ульфрика Буревестника, ярла Виндхельма, \nвожака восстания все сомнения о том куда всех нас везут отпали. На казнь.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Послышался голос Ралофа:\n-Эй, конокрад, а ты родом из какой деревни?\n");
                //Console.ReadKey(true);
                //Console.WriteLine("-А тебе то что?\n");
                //Console.ReadKey(true);
                //Console.WriteLine("-Последние мысли норда всегда должны быть о доме.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("-Рорикстед. Я из Рорикстеда.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Впереди разносится звучный голос одного из стражников: \n-Здравия желаю, генерал.Палач уже ждет.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("-Хорошо. Покончим с этим.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Локир начинает нервно произносить себе под нос что-то похожее на молитву: \n-Мара, Дибелла, Кинарет, Акатош. Боги, пожалуйста помогите мне. Это не может быть правдой. Это сон.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Мы заезжаем в величественный имперский город-крепость. Хелген.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Очень скоро мы прибываем на место нашей казни.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Ралоф командует: \n-Пошли. Не будем заставлять Богов дожидаться.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Все пленники спрыгивают с повозки и встают в шеренгу. Легионер Хадвар зачитывает список приговоренных: \n-Ульфрик Буревестник, Ралоф из Ривервуда, Локир из Рорикстедa...\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Но в этот момент неудачливый вор кричит: \n-Нет. Я не мятежник. Вы не имеете права. Я вам не дамся! \nОн предпринимает попытку побега. Последнюю в своей жизни, ведь стрела выпущенная одним из имперских \nлучников обрывает жизнь вора.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Список приговоренных заканчивается, но нашего имени там нет.\n");
                //Console.ReadKey(true);
                //Console.WriteLine("Хадвар спрашивает нас: \n-А кто ты?");
                //Console.ReadKey(true);
                Console.WriteLine("Выберите персонажа: \n1-Норд (100 HP, 20 AR) \n2-Эльф (75 HP, 15 AR) \n3-Орк (125HP, 25 AR)\n");
                string choose = Console.ReadLine();
                Console.WriteLine("Назовите персонажа:");
                string name = Console.ReadLine();
                Character mc = null;
                Weapon mc_wp = null;
                while (choose != "1" && choose != "2" && choose != "3")
                {
                    Console.WriteLine("Введите ответ корректно\n");
                    choose = Console.ReadLine();
                }
                if (choose == "1")
                {
                    mc = new Character(name, 100, 20);
                    mc_wp = new Weapon("Меч", 30);
                }
                if (choose == "2")
                {
                    mc = new Character(name, 75, 15);
                    mc_wp = new Weapon("Кинжал", 40);
                }
                if (choose == "3")
                {
                    mc = new Character(name, 125, 25);
                    mc_wp = new Weapon("Бревно", 35);
                }
                Console.WriteLine("День нашей казни откладывается, ведь в тот самый момент, когда палач замахивает свою секиру над нашей \nголовой мы замечаем дракона Алдуина, приземляющегося на одну из башен города. В крепости начинается паника. \nИ с этого момента мы вольны сами вершить свою судьбу...\n");
                //Thread.Sleep(5000);
                //Console.Clear();








                Console.WriteLine("Необходимо бежать из Хелгена, пока не стало слишком поздно!\n");
                Console.ReadKey(true);
                Console.WriteLine("Выберите за кем следовать: \n1 - легионер Хадвар \n2 - Ралоф – Брат Бури\n");
                choose = Console.ReadLine();

                Character enemy = null;
                Weapon en_wp = new Weapon("Ржавый меч", 10);
                while (choose != "1" && choose != "2")
                {
                    Console.WriteLine("Введите ответ корректно\n");
                    choose = Console.ReadLine();
                }
                if (choose == "1")
                {
                    enemy = new Character("Брат Бури", 70, 10);
                    choose = "Хадвар";
                }
                else if (choose == "2")
                {
                    enemy = new Character("Имперец", 70, 10);
                    choose = "Ралоф";
                }
                Console.WriteLine($"После того как Вы с напарником пробираетесь в крепось, он развзывает Вам руки.\n-Ну а теперь веди меня,- сказал {choose}.\n");
                Console.ReadKey(true);
                Console.WriteLine($"Вы заходите в первую комнату. Перед вами {enemy.Name}! Нажмите любую клавишу, чтобы принять бой!\n");
                Console.ReadKey(true);

                while (mc.Health > 0 && enemy.Health > 0)
                {
                    mc.Hit(enemy, mc_wp);
                    enemy.Hit(mc, en_wp);
                }
                if (mc.Health < 0)
                {
                    Console.WriteLine("Вы погибли!\n");
                    return;
                }

                enemy.Heal();
                Console.WriteLine($"Вы победили! У вас осталось {mc.Health} здоровья.");
                Console.WriteLine("Выберите действие: \n1 - пойти на Восток \n2 - пойти на Запад\n");
                choose = Console.ReadLine();

                while (choose != "1" && choose != "2")
                {
                    Console.WriteLine("Введите ответ корректно\n");
                    choose = Console.ReadLine();
                }
                if (choose == "1")
                {
                    Console.WriteLine("Вы оказались во второй комнате! Ваши действие: \n1 - Обыскать сундук \n 2 - Активировать рычаг\n");
                    Console.WriteLine("");
                }
                
            }
        }
    }
}
