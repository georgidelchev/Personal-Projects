using System;
using System.Threading;

namespace ConsoleQuiz
{
    public class Program
    {
        public static bool isTimerEnd = false;
        public static long timerCounter = 0;

        public static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Thread th = new Thread(Program.TitleTimer);
            th.Start();

            Thread music = new Thread(Program.BackgroundMusic);
            music.Start();
            for (int i = 1; i <= 101; i++)
            {
                Console.SetWindowSize(i, 30);
                Thread.Sleep(20);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int i = 0; i <= 100; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
                Console.WriteLine($"{i}/100%");
                Console.SetCursorPosition(0, 1);
                Thread.Sleep(100);
            }

            Thread.Sleep(2000);
            Console.Clear();

            MainMenuScreen mainOptions = new MainMenuScreen();
            mainOptions.MainScreen();
        }
        public static void StartingMusic()
        {
            QuizChapters.musicFlag = true;
            Thread firstThread = new Thread(BackgroundMusic);
            firstThread.Start();
        }
        public static void BackgroundMusic()
        {
            int[] sound = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            while (QuizChapters.musicFlag)
            {
                for (int i = 0; i < sound.Length; i++)
                {
                    Console.Beep(sound[i], 250);

                    if (i == sound.Length - 1)
                    {
                        for (int j = sound.Length - 1; j >= 0; j--)
                        {
                            Console.Beep(sound[j], 250);

                            if (QuizChapters.musicFlag == false)
                            {
                                break;
                            }
                        }
                    }

                    if (QuizChapters.musicFlag == false)
                    {
                        break;
                    }
                }
            }
        }
        public static void MusicOptions()
        {
            Console.WriteLine();
            Console.WriteLine();

            string[] music =
            {
                "                                       D","o"," ","y","o","u"," ","w","a","n","t"," ","a"," ","m","u","s","i","c","?","\n",
                "                                     P", "l", "e", "a","s","e"," ","s","e","l","e","c","t"," ","a","n"," ","o","p","t","i","o","n",":"
            };

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (string item in music)
            {
                Console.Write(item);
                //Thread.Sleep(125);
            }
            Console.WriteLine();
            Console.WriteLine();

            bool isSelected = false;
            int optionsCount = 2;
            int selected = 1;

            string[] choices = { "\u221A", "X" };
            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (selected == i)
                    {
                        if (selected == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        Console.Write("                                              █ ");
                    }
                    else
                    {
                        Console.Write("                                                ");
                    }

                    Console.WriteLine($"{choices[i - 1]}");
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 1)
                        {
                            selected = optionsCount;
                        }
                        else
                        {
                            selected -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (selected == optionsCount)
                        {
                            selected = 1;
                        }
                        else
                        {
                            selected += 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.F:
                        ProgrammingQuizMainScreen.selected = 1;

                        if (selected == 1 && ProgrammingQuizMainScreen.isStopped && !QuizChapters.musicFlag)
                        {
                            QuizChapters.musicFlag = true;
                            Thread th = new Thread(Program.BackgroundMusic);
                            th.Start();
                        }
                        else if (selected == 2)
                        {
                            QuizChapters.musicFlag = false;
                        }

                        isSelected = true;
                        break;
                }

                if (!isSelected)
                {
                    Console.CursorTop -= optionsCount;
                }
            }
            Console.Clear();
        }
        public static void TitleTimer()
        {
            while (!isTimerEnd)
            {
                long minutes = timerCounter / 60;
                long hours = minutes / 60;

                Console.Title =
                "                           " +
                "                           " +
                $"::::: PLAYING TIME        <><>[{hours:d2}] : " +
                                            $"[{(minutes - (hours * 60)):d2}] : " +
                                            $"[{(timerCounter - (minutes * 60)):d2}]<><>         " +
                $"OF THE QUIZ :::::";

                Thread.Sleep(1000);
                timerCounter++;
            }
        }
    }
}
