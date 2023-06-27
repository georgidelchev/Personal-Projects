using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleQuiz
{
    public class ProgrammingQuizMainScreen
    {
        public static bool isSelected;
        public static int selected = 1;
        public static int optionsCount;

        // PROGRAMMING CHAPTER COMPLETED CATEGORIES:
        public static bool isCSharpCompleted = false;
        public static bool isJavaCompleted = false;
        public static bool isJavaScriptCompleted = false;
        public static bool isPythonCompleted = false;
        public static bool isHTML_CSSCompleted = false;
        public static bool isPHPCompleted = false;
        public static bool isCPlusPlusCompleted = false;
        public static bool isSqlCompleted = false;
        public static bool isC_Completed = false;
        public static bool isSwiftCompleted = false;

        // FOOTBALL CHAPTER COMPLETED CATEGORIES:
        public static bool isFootballCompleted = false;
        public static bool isBasketballCompleted = false;
        public static bool isTennisCompleted = false;
        public static bool isVolleyballCompleted = false;

        // GEORGRAPHY CHAPTER COMPLETED CATEGORIES:
        public static bool isContinentsCompleted = false;
        public static bool isPlantsCompleted = false;
        public static bool isCitiesCompleted = false;
        public static bool isCapitalsCompleted = false;
        public static bool isCapitalsSecondCompleted = false;
        public static bool isCapitalsThirdCompleted = false;
        public static bool isCapitalsForthCompleted = false;
        public static bool isCapitalsFifthCompleted = false;
        public static bool isDesertsCompleted = false;
        public static bool isMountainsCompleted = false;
        public static bool isAtmosphereCompleted = false;
        public static bool isOceansCompleted = false;

        // AUTOMOBILES CHAPTER COMPLETED CATEGORIES:
        public static bool isAudiCompleted = false;
        public static bool isBMWCompleted = false;
        public static bool isMercedesCompleted = false;
        public static bool isPeugeotCompleted = false;
        public static bool isCitroenCompleted = false;
        public static bool isHondaCompleted = false;
        public static bool isVWCompleted = false;
        public static bool isFerrariCompleted = false;
        public static bool isPaganiCompleted = false;
        public static bool isBugattiCompleted = false;
        public static bool isLamborghiniCompleted = false;
        public static bool isPorscheCompleted = false;
        public static bool isToyotaPCompleted = false;
        public static bool isNissanCompleted = false;
        public static bool isMazdaCompleted = false;

        // GAMES CHAPTER COMPLETED CATEGORIES
        public static bool isCounterStrikePCompleted = false;
        public static bool isWorldOfWarcraftCompleted = false;
        public static bool isMinecraftCompleted = false;
        public static bool isLeagueOfLegendsCompleted = false;
        public static bool isFortniteCompleted = false;

        // MOVIES CHAPTER COMPLETED CATEGORIES:
        // Movies
        public static bool isHobbitCompleted = false;
        public static bool isTheLordOfTheRingsCompleted = false;
        public static bool isHarryPotterCompleted = false;
        // Series
        public static bool isThe100Completed = false;
        public static bool isTheWalkingDeadCompleted = false;
        public static bool isVanHelsingCompleted = false;

        // HISTORY CHAPTER COMPLETED CATEGORIES:
        public static bool isAncientHistoryCompleted = false;
        public static bool isMedievalHistoryCompleted = false;
        public static bool isModernHistoryCompleted = false;

        public static int programmingQuizCompletedChapters = 0;
        public static int sportsQuizCompletedChapters = 0;
        public static int geographyQuizCompletedChapters = 0;
        public static int automobilesQuizCompletedChapters = 0;
        public static int gamesQuizCompletedChapters = 0;
        public static int moviesQuizCompletedChapters = 0;
        public static int historyQuizCompletedChapters = 0;

        public static bool isStopped = false;

        public static string[] choices;

        public static bool isProgrammingQuizPicked = false;
        public static bool isSportsQuizPicked = false;
        public static bool isGeographyQuizPicked = false;
        public static bool isAutomobilesQuizPicked = false;
        public static bool isGamesQuizPicked = false;
        public static bool isMoviesQuizPicked = false;
        public static bool isHistoryQuizPicked = false;

        // QUIZ 1
        public void ProgrammingQuizStartingScreen()
        {
            isProgrammingQuizPicked = true;
            isSportsQuizPicked = false;
            isGeographyQuizPicked = false;
            isAutomobilesQuizPicked = false;
            isGamesQuizPicked = false;
            isMoviesQuizPicked = false;
            isHistoryQuizPicked = false;

            choices = new string[14]
                {
              "[CSharp]",
              "[Java]",
              "[JavaScript]",
              "[Python]",
              "[HTML/CSS]",
              "[PHP]",
              "[C++]",
              "[SQL]",
              "[C]",
              "[Swift]",
              "", // empty
              "EXIT",
              "MAIN MENU",
              "", // music ON/OFF
                };

            if (programmingQuizCompletedChapters == 10) // to change this to 10
            {
                Console.WriteLine("you completed programming quiz");
                Thread.Sleep(5000);
                Console.Clear();
                MainMenuScreen mainManu = new MainMenuScreen();
                mainManu.MainScreen();
            }
            isSelected = false;
            optionsCount = 14;

            InfoAtTheTop();

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    if ((isCSharpCompleted && i == 1) ||
                        (isJavaCompleted && i == 2) ||
                        (isJavaScriptCompleted && i == 3) ||
                        (isPythonCompleted && i == 4) ||
                        (isHTML_CSSCompleted && i == 5) ||
                        (isPHPCompleted && i == 6) ||
                        (isCPlusPlusCompleted && i == 7) ||
                        (isSqlCompleted && i == 8) ||
                        (isC_Completed && i == 9) ||
                        (isSwiftCompleted && i == 10))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (isCSharpCompleted)
                        {
                            choices[0] = "\u221A [CSharp]";
                        }
                        if (isJavaCompleted)
                        {
                            choices[1] = "\u221A [Java]";
                        }
                        if (isJavaScriptCompleted)
                        {
                            choices[2] = "\u221A [JavaScript]";
                        }
                        if (isPythonCompleted)
                        {
                            choices[3] = "\u221A [Python]";
                        }
                        if (isHTML_CSSCompleted)
                        {
                            choices[4] = "\u221A [HTML_CSS]";
                        }
                        if (isPHPCompleted)
                        {
                            choices[5] = "\u221A [PHP]";
                        }
                        if (isCPlusPlusCompleted)
                        {
                            choices[6] = "\u221A [CPlusPlus]";
                        }
                        if (isSqlCompleted)
                        {
                            choices[7] = "\u221A [Sql]";
                        }
                        if (isC_Completed)
                        {
                            choices[8] = "\u221A [C]";
                        }
                        if (isSwiftCompleted)
                        {
                            choices[9] = "\u221A [Swift]";
                        }

                    }
                    else
                    {
                        if (i >= 1 || i <= 10)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                        }
                        if (i == 12 || i == 13)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        if (i == 14)
                        {
                            if (QuizChapters.musicFlag)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }

                    if (selected == i)
                    {
                        if ((i >= 1 || i <= 10) &&
                            ((!isCSharpCompleted && i == 1) ||
                            (!isJavaCompleted && i == 2) ||
                            (!isJavaScriptCompleted && i == 3) ||
                            (!isPythonCompleted && i == 4) ||
                            (!isHTML_CSSCompleted && i == 5) ||
                            (!isPHPCompleted && i == 6) ||
                            (!isCPlusPlusCompleted && i == 7) ||
                            (!isSqlCompleted && i == 8) ||
                            (!isC_Completed && i == 9) ||
                            (!isSwiftCompleted && i == 10)))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        if (i == 12 || i == 13)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 14)
                        {
                            if (QuizChapters.musicFlag == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }

                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i < 11)
                    {
                        if ((isCSharpCompleted && i == 1) ||
                        (isJavaCompleted && i == 2) ||
                        (isJavaScriptCompleted && i == 3) ||
                        (isPythonCompleted && i == 4) ||
                        (isHTML_CSSCompleted && i == 5) ||
                        (isPHPCompleted && i == 6) ||
                        (isCPlusPlusCompleted && i == 7) ||
                        (isSqlCompleted && i == 8) ||
                        (isC_Completed && i == 9) ||
                        (isSwiftCompleted && i == 10))
                        {
                            Console.WriteLine($"{choices[i - 1]} - Quiz   ");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]} - Quiz");
                        }
                    }
                    else if (i == 11)
                    {
                        Console.WriteLine($"");
                    }
                    else if (i == 12 || i == 13)
                    {
                        Console.WriteLine($"[{choices[i - 1]}]");
                    }
                    else if (i == 14)
                    {
                        if (QuizChapters.musicFlag == true)
                        {
                            choices[13] = "X Turn OFF the Music X";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                        else
                        {
                            choices[13] = "\u221A Turn ON the Music \u221A";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 12)
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
                        if (selected == 10)
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
                        if ((isCSharpCompleted && selected == 1) ||
                        (isJavaCompleted && selected == 2) ||
                        (isJavaScriptCompleted && selected == 3) ||
                        (isPythonCompleted && selected == 4) ||
                        (isHTML_CSSCompleted && selected == 5) ||
                        (isPHPCompleted && selected == 6) ||
                        (isCPlusPlusCompleted && selected == 7) ||
                        (isSqlCompleted && selected == 8) ||
                        (isC_Completed && selected == 9) ||
                        (isSwiftCompleted && selected == 10))
                        {
                            Console.Clear();

                            Console.WriteLine(choices[selected - 1]);
                            Console.WriteLine("Already completed!");
                            Thread.Sleep(2000);

                            Console.Clear();

                            InfoAtTheTop();
                            continue;
                        }

                        isSelected = true;

                        break;
                }

                if (!isSelected)
                {
                    Console.CursorTop -= optionsCount;
                }
            }

            QuizChapters quizChapters = new QuizChapters();
            Console.Clear();

            switch (selected)
            {
                case 1:
                    quizChapters.CSharpChapter();
                    break;
                case 2:
                    quizChapters.JavaChapter();
                    break;
                case 3:
                    quizChapters.JavaScriptChapter();
                    break;
                case 4:
                    quizChapters.PythonChapter();
                    break;
                case 5:
                    quizChapters.HTML_CssChapter();
                    break;
                case 6:
                    quizChapters.PhpChapter();
                    break;
                case 7:
                    quizChapters.CPlusPlusChapter();
                    break;
                case 8:
                    quizChapters.SqlChapter();
                    break;
                case 9:
                    quizChapters.C_Chapter();
                    break;
                case 10:
                    quizChapters.SwiftChapter();
                    break;
                case 12:
                    Program.isTimerEnd = true;
                    Console.WriteLine("PROGRAM TERMINATED!!!");
                    Console.WriteLine();
                    Console.WriteLine($"You played for total time of: [{Program.timerCounter:d2}] seconds");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue:");
                    QuizChapters.musicFlag = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 13:
                    MainMenuScreen mainMenu = new MainMenuScreen();
                    Console.Clear();
                    mainMenu.MainScreen();
                    break;
                case 14:
                    if (QuizChapters.musicFlag)
                    {
                        QuizChapters.musicFlag = false;
                        isStopped = true;
                    }
                    else
                    {
                        Program.StartingMusic();
                    }

                    ProgrammingQuizStartingScreen();
                    break;
            }
        }

        // QUIZ 2
        public void SportsQuizStartingScreen()
        {
            isProgrammingQuizPicked = false;
            isSportsQuizPicked = true;
            isGeographyQuizPicked = false;
            isAutomobilesQuizPicked = false;
            isGamesQuizPicked = false;
            isMoviesQuizPicked = false;
            isHistoryQuizPicked = false;

            if (sportsQuizCompletedChapters == 4) // to change this to 10
            {
                Console.WriteLine("you completed sports quiz");
                Thread.Sleep(5000);
                Console.Clear();
                MainMenuScreen mainManu = new MainMenuScreen();
                mainManu.MainScreen();
            }

            QuizChapters quizChapters = new QuizChapters();

            choices = new string[8]
            {
              "[Football]",
              "[Basketball]",
              "[Tennis]",
              "[Volleyball]",
              "", // empty
              "EXIT",
              "MAIN MENU",
              "", // music ON/OFF
            };
            isSelected = false;
            optionsCount = 8;

            InfoAtTheTop();

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    if ((isFootballCompleted && i == 1) ||
                        (isBasketballCompleted && i == 2) ||
                        (isTennisCompleted && i == 3) ||
                        (isVolleyballCompleted && i == 4))
                    {
                        if (isFootballCompleted)
                        {
                            choices[0] = "\u221A [Football]";
                        }
                        if (isBasketballCompleted)
                        {
                            choices[1] = "\u221A [Basketball]";
                        }
                        if (isTennisCompleted)
                        {
                            choices[2] = "\u221A [Tennis]";
                        }
                        if (isVolleyballCompleted)
                        {
                            choices[3] = "\u221A [Volleyball]";
                        }
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if (i >= 1 || i <= 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                        }
                        if (i == 6 || i == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        if (i == 8)
                        {
                            if (QuizChapters.musicFlag)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }

                    if (selected == i)
                    {
                        if ((i >= 1 || i <= 4))
                        {
                            if ((isFootballCompleted && i == 1) ||
                                (isBasketballCompleted && i == 2) ||
                                (isTennisCompleted && i == 3) ||
                                (isVolleyballCompleted && i == 4))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }

                        if (i == 6 || i == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 8)
                        {
                            if (QuizChapters.musicFlag == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }

                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i < 5)
                    {
                        if ((isFootballCompleted && i == 1) ||
                        (isBasketballCompleted && i == 2) ||
                        (isTennisCompleted && i == 3) ||
                        (isVolleyballCompleted && i == 4))
                        {
                            Console.WriteLine($"{choices[i - 1]} - Quiz   ");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]} - Quiz");
                        }
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine($"");
                    }
                    else if (i == 6 || i == 7)
                    {
                        Console.WriteLine($"[{choices[i - 1]}]");
                    }
                    else if (i == 8)
                    {
                        if (QuizChapters.musicFlag == true)
                        {
                            choices[7] = "X Turn OFF the Music X";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                        else
                        {
                            choices[7] = "\u221A Turn ON the Music \u221A";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 6)
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
                        if (selected == 4)
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
                        if ((isFootballCompleted && selected == 1) ||
                        (isBasketballCompleted && selected == 2) ||
                        (isTennisCompleted && selected == 3) ||
                        (isVolleyballCompleted && selected == 4))
                        {
                            Console.Clear();

                            Console.WriteLine(choices[selected - 1]);
                            Console.WriteLine("Already completed!");
                            Thread.Sleep(2000);

                            Console.Clear();

                            InfoAtTheTop();
                            continue;
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

            switch (selected)
            {
                case 1:
                    quizChapters.FootballChapter();
                    break;
                case 2:
                    quizChapters.BasketballChapter();
                    break;
                case 3:
                    quizChapters.TennisChapter();
                    break;
                case 4:
                    quizChapters.VolleyballChapter();
                    break;
                case 6:
                    Program.isTimerEnd = true;
                    Console.WriteLine("PROGRAM TERMINATED!!!");
                    Console.WriteLine();
                    Console.WriteLine($"You played for total time of: [{Program.timerCounter:d2}] seconds");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue:");
                    QuizChapters.musicFlag = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 7:
                    MainMenuScreen mainMenu = new MainMenuScreen();
                    Console.Clear();
                    mainMenu.MainScreen();
                    break;
                case 8:
                    if (QuizChapters.musicFlag)
                    {
                        QuizChapters.musicFlag = false;
                        isStopped = true;
                    }
                    else
                    {
                        Program.StartingMusic();
                    }

                    SportsQuizStartingScreen();
                    break;
            }
        }

        // QUIZ 3
        public void GeographyQuizStartingScreen()
        {
            isProgrammingQuizPicked = false;
            isSportsQuizPicked = false;
            isGeographyQuizPicked = true;
            isAutomobilesQuizPicked = false;
            isGamesQuizPicked = false;
            isMoviesQuizPicked = false;
            isHistoryQuizPicked = false;

            if (geographyQuizCompletedChapters == 12)
            {
                Console.WriteLine("you completed geography quiz");
                Thread.Sleep(5000);
                Console.Clear();
                MainMenuScreen mainManu = new MainMenuScreen();
                mainManu.MainScreen();
            }

            QuizChapters quizChapters = new QuizChapters();

            choices = new string[16]
            {
              "[Continents]",
              "[Plants]",
              "[Cities]",
              "[Capitals]",
              "[Capitals Second]",
              "[Capitals Third]",
              "[Capitals Forth]",
              "[Capitals Fifth]",
              "[Deserts]",
              "[Mountains]",
              "[Atmosphere]",
              "[Oceans]",
              "", // empty
              "EXIT",
              "MAIN MENU",
              "", // music ON/OFF
            };
            isSelected = false;
            optionsCount = 16;

            InfoAtTheTop();

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    if ((isContinentsCompleted && i == 1) ||
                        (isPlantsCompleted && i == 2) ||
                        (isCitiesCompleted && i == 3) ||
                        (isCapitalsCompleted && i == 4) ||
                        (isCapitalsSecondCompleted && i == 5) ||
                        (isCapitalsThirdCompleted && i == 6) ||
                        (isCapitalsForthCompleted && i == 7) ||
                        (isCapitalsFifthCompleted && i == 8) ||
                        (isDesertsCompleted && i == 9) ||
                        (isMountainsCompleted && i == 10) ||
                        (isAtmosphereCompleted && i == 11) ||
                        (isOceansCompleted && i == 12))
                    {
                        if (isContinentsCompleted)
                        {
                            choices[0] = "\u221A [Continents]";
                        }
                        if (isPlantsCompleted)
                        {
                            choices[1] = "\u221A [Plants]";
                        }
                        if (isCitiesCompleted)
                        {
                            choices[2] = "\u221A [Cities]";
                        }
                        if (isCapitalsCompleted)
                        {
                            choices[3] = "\u221A [Capitals]";
                        }
                        if (isCapitalsSecondCompleted)
                        {
                            choices[4] = "\u221A [Capitals Second]";
                        }
                        if (isCapitalsThirdCompleted)
                        {
                            choices[5] = "\u221A [Capitals Third]";
                        }
                        if (isCapitalsForthCompleted)
                        {
                            choices[6] = "\u221A [Capitals Forth]";
                        }
                        if (isCapitalsFifthCompleted)
                        {
                            choices[7] = "\u221A [Capitals Fifth]";
                        }
                        if (isDesertsCompleted)
                        {
                            choices[8] = "\u221A [Deserts]";
                        }
                        if (isMountainsCompleted)
                        {
                            choices[9] = "\u221A [Mountains]";
                        }
                        if (isAtmosphereCompleted)
                        {
                            choices[10] = "\u221A [Atmosphere]";
                        }
                        if (isOceansCompleted)
                        {
                            choices[11] = "\u221A [Oceans]";
                        }

                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if (i >= 1 || i <= 12)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                        }
                        if (i == 14 || i == 15)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        if (i == 16)
                        {
                            if (QuizChapters.musicFlag)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }

                    if (selected == i)
                    {
                        if (i >= 1 || i <= 12)
                        {
                            if ((isContinentsCompleted && i == 1) ||
                                (isPlantsCompleted && i == 2) ||
                                (isCitiesCompleted && i == 3) ||
                                (isCapitalsCompleted && i == 4) ||
                                (isCapitalsSecondCompleted && i == 5) ||
                                (isCapitalsThirdCompleted && i == 6) ||
                                (isCapitalsForthCompleted && i == 7) ||
                                (isCapitalsFifthCompleted && i == 8) ||
                                (isDesertsCompleted && i == 9) ||
                                (isMountainsCompleted && i == 10) ||
                                (isAtmosphereCompleted && i == 11) ||
                                (isOceansCompleted && i == 12))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }

                        if (i == 14 || i == 15)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 16)
                        {
                            if (QuizChapters.musicFlag == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }

                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i < 13)
                    {
                        if ((isContinentsCompleted && i == 1) ||
                            (isPlantsCompleted && i == 2) ||
                            (isCitiesCompleted && i == 3) ||
                            (isCapitalsCompleted && i == 4) ||
                            (isCapitalsSecondCompleted && i == 5) ||
                            (isCapitalsThirdCompleted && i == 6) ||
                            (isCapitalsForthCompleted && i == 7) ||
                            (isCapitalsFifthCompleted && i == 8) ||
                            (isDesertsCompleted && i == 9) ||
                            (isMountainsCompleted && i == 10) ||
                            (isAtmosphereCompleted && i == 11) ||
                            (isOceansCompleted && i == 12))
                        {
                            Console.WriteLine($"{choices[i - 1]} - Quiz   ");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]} - Quiz");
                        }
                    }
                    else if (i == 13)
                    {
                        Console.WriteLine($"");
                    }
                    else if (i == 14 || i == 15)
                    {
                        Console.WriteLine($"[{choices[i - 1]}]");
                    }
                    else if (i == 16)
                    {
                        if (QuizChapters.musicFlag == true)
                        {
                            choices[15] = "X Turn OFF the Music X";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                        else
                        {
                            choices[15] = "\u221A Turn ON the Music \u221A";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 14)
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
                        if (selected == 12)
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
                        if ((isContinentsCompleted && selected == 1) ||
                            (isPlantsCompleted && selected == 2) ||
                            (isCitiesCompleted && selected == 3) ||
                            (isCapitalsCompleted && selected == 4) ||
                            (isCapitalsSecondCompleted && selected == 5) ||
                            (isCapitalsThirdCompleted && selected == 6) ||
                            (isCapitalsForthCompleted && selected == 7) ||
                            (isCapitalsFifthCompleted && selected == 8) ||
                            (isDesertsCompleted && selected == 9) ||
                            (isMountainsCompleted && selected == 10) ||
                            (isAtmosphereCompleted && selected == 11) ||
                            (isOceansCompleted && selected == 12))
                        {
                            Console.Clear();

                            Console.WriteLine(choices[selected - 1]);
                            Console.WriteLine("Already completed!");
                            selected = 1;
                            Thread.Sleep(2000);

                            Console.Clear();

                            InfoAtTheTop();
                            continue;
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

            switch (selected)
            {
                case 1:
                    quizChapters.Continents();
                    break;
                case 2:
                    quizChapters.Plants();
                    break;
                case 3:
                    quizChapters.Cities();
                    break;
                case 4:
                    quizChapters.Capitals();
                    break;
                case 5:
                    quizChapters.CapitalsSecond();
                    break;
                case 6:
                    quizChapters.CapitalsThird();
                    break;
                case 7:
                    quizChapters.CapitalsForth();
                    break;
                case 8:
                    quizChapters.CapitalsFifth();
                    break;
                case 9:
                    quizChapters.Deserts();
                    break;
                case 10:
                    quizChapters.Mountains();
                    break;
                case 11:
                    quizChapters.Atmosphere();
                    break;
                case 12:
                    quizChapters.Oceans();
                    break;
                case 14:
                    Program.isTimerEnd = true;
                    Console.WriteLine("PROGRAM TERMINATED!!!");
                    Console.WriteLine();
                    Console.WriteLine($"You played for total time of: [{Program.timerCounter:d2}] seconds");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue:");
                    QuizChapters.musicFlag = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 15:
                    MainMenuScreen mainMenu = new MainMenuScreen();
                    Console.Clear();
                    mainMenu.MainScreen();
                    break;
                case 16:
                    if (QuizChapters.musicFlag)
                    {
                        QuizChapters.musicFlag = false;
                        isStopped = true;
                    }
                    else
                    {
                        Program.StartingMusic();
                    }

                    GeographyQuizStartingScreen();
                    break;
            }
        }

        // QUIZ 4
        public void AutomobilesQuizStartingScreen()
        {
            isProgrammingQuizPicked = false;
            isSportsQuizPicked = false;
            isGeographyQuizPicked = false;
            isAutomobilesQuizPicked = true;
            isGamesQuizPicked = false;
            isMoviesQuizPicked = false;
            isHistoryQuizPicked = false;

            if (automobilesQuizCompletedChapters == 15)
            {
                Console.WriteLine("you completed automobiles quiz");
                Thread.Sleep(5000);
                Console.Clear();
                MainMenuScreen mainManu = new MainMenuScreen();
                mainManu.MainScreen();
            }

            QuizChapters quizChapters = new QuizChapters();

            choices = new string[19]
            {
              "[Audi]",
              "[BMW]",
              "[Mercedes]",
              "[Peugeot]",
              "[Citroen]",
              "[Honda]",
              "[VW]",
              "[Ferrari]",
              "[Pagani]",
              "[Bugatti]",
              "[Lamborghini]",
              "[Porsche]",
              "[Toyota]",
              "[Nissan]",
              "[Mazda]",
              "", // empty
              "EXIT",
              "MAIN MENU",
              "", // music ON/OFF
            };
            isSelected = false;
            optionsCount = 19;

            InfoAtTheTop();

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    if ((isAudiCompleted && i == 1) ||
                        (isBMWCompleted && i == 2) ||
                        (isMercedesCompleted && i == 3) ||
                        (isPeugeotCompleted && i == 4) ||
                        (isCitroenCompleted && i == 5) ||
                        (isHondaCompleted && i == 6) ||
                        (isVWCompleted && i == 7) ||
                        (isFerrariCompleted && i == 8) ||
                        (isPaganiCompleted && i == 9) ||
                        (isBugattiCompleted && i == 10) ||
                        (isLamborghiniCompleted && i == 11) ||
                        (isPorscheCompleted && i == 12) ||
                        (isToyotaPCompleted && i == 13) ||
                        (isNissanCompleted && i == 14) ||
                        (isMazdaCompleted && i == 15))
                    {
                        if (isAudiCompleted)
                        {
                            choices[0] = "\u221A [Audi]";
                        }
                        if (isBMWCompleted)
                        {
                            choices[1] = "\u221A [BMW]";
                        }
                        if (isMercedesCompleted)
                        {
                            choices[2] = "\u221A [Mercedes]";
                        }
                        if (isPeugeotCompleted)
                        {
                            choices[3] = "\u221A [Peugeot]";
                        }
                        if (isCitroenCompleted)
                        {
                            choices[4] = "\u221A [Citroen]";
                        }
                        if (isHondaCompleted)
                        {
                            choices[5] = "\u221A [Honda]";
                        }
                        if (isVWCompleted)
                        {
                            choices[6] = "\u221A [VW]";
                        }
                        if (isFerrariCompleted)
                        {
                            choices[7] = "\u221A [Ferrari]";
                        }
                        if (isPaganiCompleted)
                        {
                            choices[8] = "\u221A [Pagani]";
                        }
                        if (isBugattiCompleted)
                        {
                            choices[9] = "\u221A [Bugatti]";
                        }
                        if (isLamborghiniCompleted)
                        {
                            choices[10] = "\u221A [Lamborghini]";
                        }
                        if (isPorscheCompleted)
                        {
                            choices[11] = "\u221A [Porsche]";
                        }
                        if (isToyotaPCompleted)
                        {
                            choices[12] = "\u221A [Toyota]";
                        }
                        if (isNissanCompleted)
                        {
                            choices[13] = "\u221A [Nissan]";
                        }
                        if (isMazdaCompleted)
                        {
                            choices[13] = "\u221A [Mazda]";
                        }

                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if (i >= 1 || i <= 15)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                        }
                        if (i == 17 || i == 18)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        if (i == 19)
                        {
                            if (QuizChapters.musicFlag)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }

                    if (selected == i)
                    {
                        if (i >= 1 || i <= 15)
                        {
                            if ((isAudiCompleted && i == 1) ||
                                (isBMWCompleted && i == 2) ||
                                (isMercedesCompleted && i == 3) ||
                                (isPeugeotCompleted && i == 4) ||
                                (isCitroenCompleted && i == 5) ||
                                (isHondaCompleted && i == 6) ||
                                (isVWCompleted && i == 7) ||
                                (isFerrariCompleted && i == 8) ||
                                (isPaganiCompleted && i == 9) ||
                                (isBugattiCompleted && i == 10) ||
                                (isLamborghiniCompleted && i == 11) ||
                                (isPorscheCompleted && i == 12) ||
                                (isToyotaPCompleted && i == 13) ||
                                (isNissanCompleted && i == 14) ||
                                (isMazdaCompleted && i == 15))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }

                        if (i == 17 || i == 18)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 19)
                        {
                            if (QuizChapters.musicFlag == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }

                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i < 16)
                    {
                        if ((isAudiCompleted && i == 1) ||
                            (isBMWCompleted && i == 2) ||
                            (isMercedesCompleted && i == 3) ||
                            (isPeugeotCompleted && i == 4) ||
                            (isCitroenCompleted && i == 5) ||
                            (isHondaCompleted && i == 6) ||
                            (isVWCompleted && i == 7) ||
                            (isFerrariCompleted && i == 8) ||
                            (isPaganiCompleted && i == 9) ||
                            (isBugattiCompleted && i == 10) ||
                            (isLamborghiniCompleted && i == 11) ||
                            (isPorscheCompleted && i == 12) ||
                            (isToyotaPCompleted && i == 13) ||
                            (isNissanCompleted && i == 14) ||
                            (isMazdaCompleted && i == 15))
                        {
                            Console.WriteLine($"{choices[i - 1]} - Quiz   ");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]} - Quiz");
                        }
                    }
                    else if (i == 16)
                    {
                        Console.WriteLine($"");
                    }
                    else if (i == 17 || i == 18)
                    {
                        Console.WriteLine($"[{choices[i - 1]}]");
                    }
                    else if (i == 19)
                    {
                        if (QuizChapters.musicFlag == true)
                        {
                            choices[18] = "X Turn OFF the Music X";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                        else
                        {
                            choices[18] = "\u221A Turn ON the Music \u221A";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 17)
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
                        if (selected == 15)
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
                        if ((isAudiCompleted && selected == 1) ||
                            (isBMWCompleted && selected == 2) ||
                            (isMercedesCompleted && selected == 3) ||
                            (isPeugeotCompleted && selected == 4) ||
                            (isCitroenCompleted && selected == 5) ||
                            (isHondaCompleted && selected == 6) ||
                            (isVWCompleted && selected == 7) ||
                            (isFerrariCompleted && selected == 8) ||
                            (isPaganiCompleted && selected == 9) ||
                            (isBugattiCompleted && selected == 10) ||
                            (isLamborghiniCompleted && selected == 11) ||
                            (isPorscheCompleted && selected == 12) ||
                            (isToyotaPCompleted && selected == 13) ||
                            (isNissanCompleted && selected == 14) ||
                            (isMazdaCompleted && selected == 15))
                        {
                            Console.Clear();

                            Console.WriteLine(choices[selected - 1]);
                            Console.WriteLine("Already completed!");
                            selected = 1;
                            Thread.Sleep(2000);

                            Console.Clear();

                            InfoAtTheTop();
                            continue;
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

            switch (selected)
            {
                case 1:
                    quizChapters.Audi();
                    break;
                case 2:
                    quizChapters.BMW();
                    break;
                case 3:
                    quizChapters.Mercedes();
                    break;
                case 4:
                    quizChapters.Peugeot();
                    break;
                case 5:
                    quizChapters.Citroen();
                    break;
                case 6:
                    quizChapters.Honda();
                    break;
                case 7:
                    quizChapters.VW();
                    break;
                case 8:
                    quizChapters.Ferrari();
                    break;
                case 9:
                    quizChapters.Pagani();
                    break;
                case 10:
                    quizChapters.Bugatti();
                    break;
                case 11:
                    quizChapters.Lamborghini();
                    break;
                case 12:
                    quizChapters.Porsche();
                    break;
                case 13:
                    quizChapters.Toyota();
                    break;
                case 14:
                    quizChapters.Nissan();
                    break;
                case 15:
                    quizChapters.Mazda();
                    break;
                case 17:
                    Program.isTimerEnd = true;
                    Console.WriteLine("PROGRAM TERMINATED!!!");
                    Console.WriteLine();
                    Console.WriteLine($"You played for total time of: [{Program.timerCounter:d2}] seconds");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue:");
                    QuizChapters.musicFlag = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 18:
                    MainMenuScreen mainMenu = new MainMenuScreen();
                    Console.Clear();
                    mainMenu.MainScreen();
                    break;
                case 19:
                    if (QuizChapters.musicFlag)
                    {
                        QuizChapters.musicFlag = false;
                        isStopped = true;
                    }
                    else
                    {
                        Program.StartingMusic();
                    }

                    AutomobilesQuizStartingScreen();
                    break;
            }
        }

        // QUIZ 5
        public void GamesQuizStartingScreen()
        {
            isProgrammingQuizPicked = false;
            isSportsQuizPicked = false;
            isGeographyQuizPicked = false;
            isAutomobilesQuizPicked = false;
            isGamesQuizPicked = true;
            isMoviesQuizPicked = false;
            isHistoryQuizPicked = false;

            if (gamesQuizCompletedChapters == 5)
            {
                Console.WriteLine("you completed automobiles quiz");
                Thread.Sleep(5000);
                Console.Clear();
                MainMenuScreen mainManu = new MainMenuScreen();
                mainManu.MainScreen();
            }

            QuizChapters quizChapters = new QuizChapters();

            choices = new string[9]
            {
              "[Counter Strike]",
              "[World of Warcraft]",
              "[Minecraft]",
              "[League Of Legends]",
              "[Fortnite]",
              "", // empty
              "EXIT",
              "MAIN MENU",
              "", // music ON/OFF
            };
            isSelected = false;
            optionsCount = 9;

            InfoAtTheTop();

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    if ((isCounterStrikePCompleted && i == 1) ||
                        (isWorldOfWarcraftCompleted && i == 2) ||
                        (isMinecraftCompleted && i == 3) ||
                        (isLeagueOfLegendsCompleted && i == 4) ||
                        (isFortniteCompleted && i == 5))
                    {
                        if (isCounterStrikePCompleted)
                        {
                            choices[0] = "\u221A [Counter Strike]";
                        }
                        if (isWorldOfWarcraftCompleted)
                        {
                            choices[1] = "\u221A [World of Warcraft]";
                        }
                        if (isMinecraftCompleted)
                        {
                            choices[2] = "\u221A [Minecraft]";
                        }
                        if (isLeagueOfLegendsCompleted)
                        {
                            choices[3] = "\u221A [League Of Legends]";
                        }
                        if (isFortniteCompleted)
                        {
                            choices[4] = "\u221A [Fortnite]";
                        }

                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if (i >= 1 || i <= 5)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                        }
                        if (i == 7 || i == 8)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        if (i == 9)
                        {
                            if (QuizChapters.musicFlag)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }

                    if (selected == i)
                    {
                        if (i >= 1 || i <= 5)
                        {
                            if ((isCounterStrikePCompleted && i == 1) ||
                                (isWorldOfWarcraftCompleted && i == 2) ||
                                (isMinecraftCompleted && i == 3) ||
                                (isLeagueOfLegendsCompleted && i == 4) ||
                                (isFortniteCompleted && i == 5))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }

                        if (i == 7 || i == 8)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 9)
                        {
                            if (QuizChapters.musicFlag == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }

                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i < 6)
                    {
                        if ((isCounterStrikePCompleted && i == 1) ||
                            (isWorldOfWarcraftCompleted && i == 2) ||
                            (isMinecraftCompleted && i == 3) ||
                            (isLeagueOfLegendsCompleted && i == 4) ||
                            (isFortniteCompleted && i == 5))
                        {
                            Console.WriteLine($"{choices[i - 1]} - Quiz   ");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]} - Quiz");
                        }
                    }
                    else if (i == 6)
                    {
                        Console.WriteLine($"");
                    }
                    else if (i == 7 || i == 8)
                    {
                        Console.WriteLine($"[{choices[i - 1]}]");
                    }
                    else if (i == 9)
                    {
                        if (QuizChapters.musicFlag == true)
                        {
                            choices[8] = "X Turn OFF the Music X";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                        else
                        {
                            choices[8] = "\u221A Turn ON the Music \u221A";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 7)
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
                        if (selected == 5)
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
                        if ((isCounterStrikePCompleted && selected == 1) ||
                            (isWorldOfWarcraftCompleted && selected == 2) ||
                            (isMinecraftCompleted && selected == 3) ||
                            (isLeagueOfLegendsCompleted && selected == 4) ||
                            (isFortniteCompleted && selected == 5))
                        {
                            Console.Clear();

                            Console.WriteLine(choices[selected - 1]);
                            Console.WriteLine("Already completed!");
                            selected = 1;
                            Thread.Sleep(2000);

                            Console.Clear();

                            InfoAtTheTop();
                            continue;
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

            switch (selected)
            {
                case 1:
                    quizChapters.CounterStrike();
                    break;
                case 2:
                    quizChapters.WorldOfWarcraft();
                    break;
                case 3:
                    quizChapters.Minecraft();
                    break;
                case 4:
                    quizChapters.LeagueOfLegends();
                    break;
                case 5:
                    quizChapters.Fortnite();
                    break;
                case 7:
                    Program.isTimerEnd = true;
                    Console.WriteLine("PROGRAM TERMINATED!!!");
                    Console.WriteLine();
                    Console.WriteLine($"You played for total time of: [{Program.timerCounter:d2}] seconds");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue:");
                    QuizChapters.musicFlag = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 8:
                    MainMenuScreen mainMenu = new MainMenuScreen();
                    Console.Clear();
                    mainMenu.MainScreen();
                    break;
                case 9:
                    if (QuizChapters.musicFlag)
                    {
                        QuizChapters.musicFlag = false;
                        isStopped = true;
                    }
                    else
                    {
                        Program.StartingMusic();
                    }

                    GamesQuizStartingScreen();
                    break;
            }
        }

        // QUIZ 6
        public void MoviesQuizStartingScreen()
        {
            isProgrammingQuizPicked = false;
            isSportsQuizPicked = false;
            isGeographyQuizPicked = false;
            isAutomobilesQuizPicked = false;
            isGamesQuizPicked = false;
            isMoviesQuizPicked = true;
            isHistoryQuizPicked = false;

            if (moviesQuizCompletedChapters == 6)
            {
                Console.WriteLine("you completed automobiles quiz");
                Thread.Sleep(5000);
                Console.Clear();
                MainMenuScreen mainManu = new MainMenuScreen();
                mainManu.MainScreen();
            }

            QuizChapters quizChapters = new QuizChapters();

            choices = new string[10]
            {
              "[Hobbit]",
              "[LOTR]",
              "[Harry Potter]",
              "[The 100]",
              "[The Walking Dead]",
              "[Van Helsing]",
              "", // empty
              "EXIT",
              "MAIN MENU",
              "", // music ON/OFF
            };
            isSelected = false;
            optionsCount = 10;

            InfoAtTheTop();

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    if ((isHobbitCompleted && i == 1) ||
                        (isTheLordOfTheRingsCompleted && i == 2) ||
                        (isHarryPotterCompleted && i == 3) ||
                        (isThe100Completed && i == 4) ||
                        (isTheWalkingDeadCompleted && i == 5) ||
                        (isVanHelsingCompleted && i == 6))
                    {
                        if (isHobbitCompleted)
                        {
                            choices[0] = "\u221A [Hobbit]";
                        }
                        if (isTheLordOfTheRingsCompleted)
                        {
                            choices[1] = "\u221A [LOTR]";
                        }
                        if (isHarryPotterCompleted)
                        {
                            choices[2] = "\u221A [Harry Potter]";
                        }
                        if (isThe100Completed)
                        {
                            choices[3] = "\u221A [The 100]";
                        }
                        if (isTheWalkingDeadCompleted)
                        {
                            choices[4] = "\u221A [The Walking Dead]";
                        }
                        if (isVanHelsingCompleted)
                        {
                            choices[5] = "\u221A [Van Helsing]";
                        }

                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if (i >= 1 || i <= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                        }
                        if (i == 8 || i == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        if (i == 10)
                        {
                            if (QuizChapters.musicFlag)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }

                    if (selected == i)
                    {
                        if (i >= 1 || i <= 6)
                        {
                            if ((isHobbitCompleted && i == 1) ||
                                (isTheLordOfTheRingsCompleted && i == 2) ||
                                (isHarryPotterCompleted && i == 3) ||
                                (isThe100Completed && i == 4) ||
                                (isTheWalkingDeadCompleted && i == 5) ||
                                (isVanHelsingCompleted && i == 6))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }

                        if (i == 8 || i == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 10)
                        {
                            if (QuizChapters.musicFlag == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }

                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i < 7)
                    {
                        if ((isHobbitCompleted && i == 1) ||
                            (isTheLordOfTheRingsCompleted && i == 2) ||
                            (isHarryPotterCompleted && i == 3) ||
                            (isThe100Completed && i == 4) ||
                            (isTheWalkingDeadCompleted && i == 5) ||
                            (isVanHelsingCompleted && i == 6))
                        {
                            Console.WriteLine($"{choices[i - 1]} - Quiz   ");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]} - Quiz");
                        }
                    }
                    else if (i == 7)
                    {
                        Console.WriteLine($"");
                    }
                    else if (i == 8 || i == 9)
                    {
                        Console.WriteLine($"[{choices[i - 1]}]");
                    }
                    else if (i == 10)
                    {
                        if (QuizChapters.musicFlag == true)
                        {
                            choices[9] = "X Turn OFF the Music X";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                        else
                        {
                            choices[9] = "\u221A Turn ON the Music \u221A";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 8)
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
                        if (selected == 6)
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
                        if ((isHobbitCompleted && selected == 1) ||
                            (isTheLordOfTheRingsCompleted && selected == 2) ||
                            (isHarryPotterCompleted && selected == 3) ||
                            (isThe100Completed && selected == 4) ||
                            (isTheWalkingDeadCompleted && selected == 5) ||
                            (isVanHelsingCompleted && selected == 6))
                        {
                            Console.Clear();

                            Console.WriteLine(choices[selected - 1]);
                            Console.WriteLine("Already completed!");
                            selected = 1;
                            Thread.Sleep(2000);

                            Console.Clear();

                            InfoAtTheTop();
                            continue;
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

            switch (selected)
            {
                case 1:
                    quizChapters.Hobbit();
                    break;
                case 2:
                    quizChapters.TheLordOfTheRings();
                    break;
                case 3:
                    quizChapters.HarryPotter();
                    break;
                case 4:
                    quizChapters.The100();
                    break;
                case 5:
                    quizChapters.TheWalkingDead();
                    break;
                case 6:
                    quizChapters.VanHelsing();
                    break;
                case 8:
                    Program.isTimerEnd = true;
                    Console.WriteLine("PROGRAM TERMINATED!!!");
                    Console.WriteLine();
                    Console.WriteLine($"You played for total time of: [{Program.timerCounter:d2}] seconds");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue:");
                    QuizChapters.musicFlag = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 9:
                    MainMenuScreen mainMenu = new MainMenuScreen();
                    Console.Clear();
                    mainMenu.MainScreen();
                    break;
                case 10:
                    if (QuizChapters.musicFlag)
                    {
                        QuizChapters.musicFlag = false;
                        isStopped = true;
                    }
                    else
                    {
                        Program.StartingMusic();
                    }

                    MoviesQuizStartingScreen();
                    break;
            }
        }

        // QUIZ 7
        public void HistoryQuizStartingScreen()
        {
            isProgrammingQuizPicked = false;
            isSportsQuizPicked = false;
            isGeographyQuizPicked = false;
            isAutomobilesQuizPicked = false;
            isGamesQuizPicked = false;
            isMoviesQuizPicked = false;
            isHistoryQuizPicked = true;

            if (moviesQuizCompletedChapters == 6)
            {
                Console.WriteLine("you completed history quiz");
                Thread.Sleep(5000);
                Console.Clear();
                MainMenuScreen mainManu = new MainMenuScreen();
                mainManu.MainScreen();
            }

            QuizChapters quizChapters = new QuizChapters();

            choices = new string[7]
            {
              "[Ancient History]",
              "[Medieval History]",
              "[Modern History]",
              "", // empty
              "EXIT",
              "MAIN MENU",
              "", // music ON/OFF
            };
            isSelected = false;
            optionsCount = 7;

            InfoAtTheTop();

            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    if ((isAncientHistoryCompleted && i == 1) ||
                        (isMedievalHistoryCompleted && i == 2) ||
                        (isModernHistoryCompleted && i == 3))
                    {
                        if (isAncientHistoryCompleted)
                        {
                            choices[0] = "\u221A [Ancient History]";
                        }
                        if (isMedievalHistoryCompleted)
                        {
                            choices[1] = "\u221A [Medieval History]";
                        }
                        if (isModernHistoryCompleted)
                        {
                            choices[2] = "\u221A [Modern History]";
                        }

                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        if (i >= 1 || i <= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                        }
                        if (i == 5 || i == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }

                        if (i == 7)
                        {
                            if (QuizChapters.musicFlag)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }

                    if (selected == i)
                    {
                        if (i >= 1 || i <= 3)
                        {
                            if ((isAncientHistoryCompleted && i == 1) ||
                                (isMedievalHistoryCompleted && i == 2) ||
                                (isModernHistoryCompleted && i == 3))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }

                        if (i == 5 || i == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 7)
                        {
                            if (QuizChapters.musicFlag == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }

                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i < 4)
                    {
                        if ((isAncientHistoryCompleted && i == 1) ||
                            (isMedievalHistoryCompleted && i == 2) ||
                            (isModernHistoryCompleted && i == 3))
                        {
                            Console.WriteLine($"{choices[i - 1]} - Quiz   ");
                        }
                        else
                        {
                            Console.WriteLine($"{i:d2}. {choices[i - 1]} - Quiz");
                        }
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine($"");
                    }
                    else if (i == 5 || i == 6)
                    {
                        Console.WriteLine($"[{choices[i - 1]}]");
                    }
                    else if (i == 7)
                    {
                        if (QuizChapters.musicFlag == true)
                        {
                            choices[6] = "X Turn OFF the Music X";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                        else
                        {
                            choices[6] = "\u221A Turn ON the Music \u221A";
                            Console.WriteLine($"[{choices[i - 1]}]");
                        }
                    }

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 5)
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
                        if (selected == 3)
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
                        if ((isAncientHistoryCompleted && selected == 1) ||
                            (isMedievalHistoryCompleted && selected == 2) ||
                            (isModernHistoryCompleted && selected == 3))
                        {
                            Console.Clear();

                            Console.WriteLine(choices[selected - 1]);
                            Console.WriteLine("Already completed!");
                            selected = 1;
                            Thread.Sleep(2000);

                            Console.Clear();

                            InfoAtTheTop();
                            continue;
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

            switch (selected)
            {
                case 1:
                    quizChapters.AncientHistory();
                    break;
                case 2:
                    quizChapters.MedievalHistory();
                    break;
                case 3:
                    quizChapters.ModernHistory();
                    break;
                case 5:
                    Program.isTimerEnd = true;
                    Console.WriteLine("PROGRAM TERMINATED!!!");
                    Console.WriteLine();
                    Console.WriteLine($"You played for total time of: [{Program.timerCounter:d2}] seconds");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue:");
                    QuizChapters.musicFlag = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 6:
                    MainMenuScreen mainMenu = new MainMenuScreen();
                    Console.Clear();
                    mainMenu.MainScreen();
                    break;
                case 7:
                    if (QuizChapters.musicFlag)
                    {
                        QuizChapters.musicFlag = false;
                        isStopped = true;
                    }
                    else
                    {
                        Program.StartingMusic();
                    }

                    HistoryQuizStartingScreen();
                    break;
            }
        }

        // TOP INFO
        public void InfoAtTheTop()
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("   Means Completed   ");
            Console.ResetColor();
            Console.Write("; ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Means Uncompleted ");
            Console.ResetColor();
            Console.Write("; ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("█ Means currently selected");

            Console.WriteLine();
        }
    }
}
