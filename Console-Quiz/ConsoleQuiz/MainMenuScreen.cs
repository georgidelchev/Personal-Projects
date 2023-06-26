using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleQuiz
{
    public class MainMenuScreen
    {
        ProgrammingQuizMainScreen beginningOptions = new ProgrammingQuizMainScreen();

        public void Logo()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in BigTexts.mainMenuText)
            {
                Console.WriteLine(item);
                Thread.Sleep(150);
            }

            Console.WriteLine();
            Console.WriteLine();

            string[] categories =
            {
                "\t\t\t\t          #","C","a","t","e","g","o","r","i","e","s","#"
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in categories)
            {
                Console.Write(item);
                Thread.Sleep(150);
            }
            Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine();
        }
        public void MainScreen()
        {
            string[] choices =
            {
                "Programming Quiz",
                "Sports Quiz",
                "Geography Quiz",
                "Automobiles Quiz",
                "Games Quiz",
                "Movies/Series Quiz",
                "History Quiz",
                "",
                "#Information TBA",
                "#Credits TBA",
                "",
                "#EXIT#"
            };

            Logo();

            bool isSelected = false;
            int optionsCount = 12;
            int selected = 1;

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {

                    if (ProgrammingQuizMainScreen.programmingQuizCompletedChapters == 10 && i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        choices[0] = "Programming Quiz - [ \u221A Completed ]";
                    }
                    else if (ProgrammingQuizMainScreen.sportsQuizCompletedChapters == 4 && i == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        choices[1] = "Sports Quiz - [ \u221A Completed ]";
                    }
                    else if (ProgrammingQuizMainScreen.geographyQuizCompletedChapters == 12 && i == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        choices[2] = "Geography Quiz - [ \u221A Completed ]";
                    }
                    else if (ProgrammingQuizMainScreen.automobilesQuizCompletedChapters == 15 && i == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        choices[3] = "Automobiles Quiz - [ \u221A Completed ]";
                    }
                    else if (ProgrammingQuizMainScreen.gamesQuizCompletedChapters == 5 && i == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        choices[4] = "Games Quiz - [ \u221A Completed ]";
                    }
                    else if (ProgrammingQuizMainScreen.moviesQuizCompletedChapters == 6 && i == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        choices[5] = "Movies Quiz - [ \u221A Completed ]";
                    }
                    else if (ProgrammingQuizMainScreen.historyQuizCompletedChapters == 3 && i == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        choices[6] = "History Quiz - [ \u221A Completed ]";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }

                    if (i == 9 || i == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (i == 12)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }

                    if (selected == i)
                    {
                        if (i == 9 || i == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("                                          █ ");
                        }
                        else if (i == 12)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("                                               █ ");
                        }
                        else
                        {
                            if ((ProgrammingQuizMainScreen.programmingQuizCompletedChapters == 10 && i == 1) ||
                                (ProgrammingQuizMainScreen.sportsQuizCompletedChapters == 4 && i == 2) ||
                                (ProgrammingQuizMainScreen.geographyQuizCompletedChapters == 12 && i == 3) ||
                                (ProgrammingQuizMainScreen.automobilesQuizCompletedChapters == 15 && i == 4) ||
                                (ProgrammingQuizMainScreen.gamesQuizCompletedChapters == 5 && i == 5) ||
                                (ProgrammingQuizMainScreen.moviesQuizCompletedChapters == 6 && i == 6) ||
                                (ProgrammingQuizMainScreen.historyQuizCompletedChapters == 3 && i == 7))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }
                            Console.Write("                                     █ ");
                        }
                    }
                    else
                    {
                        if (i == 9 || i == 10)
                        {
                            Console.Write("                                            ");
                        }
                        else if (i == 12)
                        {
                            Console.Write("                                                 ");
                        }
                        else
                        {
                            Console.Write("                                       ");
                        }
                    }
                    if (i == 9 || i == 10 || i == 12)
                    {
                        Console.WriteLine($"{choices[i - 1]}");
                    }
                    else
                    {
                        if (i == 8 || i == 11)
                        {
                            Console.WriteLine($"{choices[i - 1]}");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]}");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 9 || selected == 12)
                        {
                            selected--;
                        }
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

                        if (selected == 7 || selected == 10)
                        {
                            selected++;
                        }
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
                        if ((ProgrammingQuizMainScreen.programmingQuizCompletedChapters == 10 && selected == 1) ||
                            (ProgrammingQuizMainScreen.sportsQuizCompletedChapters == 4 && selected == 2) ||
                            (ProgrammingQuizMainScreen.geographyQuizCompletedChapters == 12 && selected == 3) ||
                            (ProgrammingQuizMainScreen.automobilesQuizCompletedChapters == 15 && selected == 4) ||
                            (ProgrammingQuizMainScreen.gamesQuizCompletedChapters == 5 && selected == 5) ||
                            (ProgrammingQuizMainScreen.moviesQuizCompletedChapters == 6 && selected == 6) ||
                            (ProgrammingQuizMainScreen.historyQuizCompletedChapters == 3 && selected == 7))
                        {
                            Console.Clear();
                            Logo();
                            continue;
                        }
                        isSelected = true;

                        if (selected != 12 && selected != 10 && selected != 9)
                        {
                            Thread.Sleep(2000);
                            Program.MusicOptions();
                        }

                        if (selected == 1)
                        {
                            Console.Clear();
                            beginningOptions.ProgrammingQuizStartingScreen();
                        }
                        else if (selected == 2)
                        {
                            Console.Clear();
                            beginningOptions.SportsQuizStartingScreen();
                        }
                        else if (selected == 3)
                        {
                            Console.Clear();
                            beginningOptions.GeographyQuizStartingScreen();
                        }
                        else if (selected == 4)
                        {
                            Console.Clear();
                            beginningOptions.AutomobilesQuizStartingScreen();
                        }
                        else if (selected == 5)
                        {
                            Console.Clear();
                            beginningOptions.GamesQuizStartingScreen();
                        }
                        else if (selected == 6)
                        {
                            Console.Clear();
                            beginningOptions.MoviesQuizStartingScreen();
                        }
                        else if (selected == 7)
                        {
                            Console.Clear();
                            beginningOptions.HistoryQuizStartingScreen();
                        }
                        else if (selected == 9)
                        {
                            Console.Clear();
                            Console.WriteLine("info TBA");
                        }
                        else if (selected == 10)
                        {
                            Console.Clear();
                            Console.WriteLine("credits TBA");
                        }
                        else if (selected == 12)
                        {
                            Console.Clear();
                            Environment.Exit(0);
                        }
                        break;
                }

                if (!isSelected)
                {
                    Console.CursorTop -= optionsCount;
                }
            }
        }
    }
}
