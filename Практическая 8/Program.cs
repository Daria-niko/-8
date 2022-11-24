using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace Практическая_8
{
    internal class Program
    {
        public static string names = " ";
        public static long for_exit = 60;
        public static int letters = 0;
        public static int current_letter = 0;
        static void Main()
        {

            Console.WriteLine("Введите имя для таблицы рекордов");
            names = Console.ReadLine(); //передать значение в паme, где ханится инфа о пользователях
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.Enter)
            {
                Console.Clear();
                Text();
            }
            else if (key == ConsoleKey.Escape)
            {
                Console.Clear();
            }

        }
        static void Text()
        {
            string text = "Для чего нужно выполнять тест скорости печати? Чтобы узнать, насколько хороша ваша скорость и точность печати в данный момент. В среднем, скорость печати составляет 200 знаков в минуту. Будет отличным результатом, если вы сможете ее превзойти! Проходя тест несколько раз, вы увидите динамику, как ваш навык улучшается в режиме реального времени. Пройдя онлайн-тест вы получите сертификат скорости печати, который можно добавить к резюме, показать работодателю или похвалиться перед друзьями.";
            Console.WriteLine(text);
            char[] array_char = text.ToCharArray();
            Console.WriteLine("---------------------------------------");
            int i = 0;
            int c = 0;

            new Thread(time).Start();
            
            Console.SetCursorPosition(0,0);

            while (for_exit >= 0)
            {  
                char key = Console.ReadKey(true).KeyChar;

                try
                {
                    Console.SetCursorPosition(i, c);
                }
                catch (Exception)
                {
                    c++;
                    i = 0;
                    Console.SetCursorPosition(i, c);
                }

                if (key == array_char[current_letter])
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(key);
                    letters++;
                }
                else
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(key);
                    Console.ResetColor();
                }
                current_letter++;
            }
              users user = new users(names,letters, letters/60);
            decirialise.add_user(user);
            show_records();
        }

        static void time()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            stopwatch.Start();
            while (for_exit >= 0)
            {
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, 15);
                for_exit = 60 - stopwatch.ElapsedMilliseconds / 1000;
                Console.ResetColor();
                Console.WriteLine("Время для работы: " + for_exit + " ");
            }

            stopwatch.Stop();
            stopwatch.Reset();
        }

        static void show_records()
        {
            decirialise.vuvod()
;
        }

    }
}