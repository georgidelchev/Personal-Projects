using System;
using System.Threading;

namespace _01SpacebarClicker
{
    class Program
    {
        public static bool isTimeOver = false;
        public static int counter = 0;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Thread th = new Thread(Timer);
            th.Start();

            ClicksCounter();
        }

        private static void ClicksCounter()
        {
            while (!isTimeOver)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Spacebar:
                        counter++;
                        Console.WriteLine(counter);
                        Console.SetCursorPosition(0, 0);
                        break;
                }
            }
        }

        public static void Timer()
        {
            int timer = 0;

            while (true)
            {
                if (timer == 1)
                {
                    Console.WriteLine("Total points: " + counter);
                    Environment.Exit(0);
                }

                Console.Title = $"TIMER: [{timer:d2}/10]";
                timer++;
                Thread.Sleep(1000);
            }
        }
    }
}
