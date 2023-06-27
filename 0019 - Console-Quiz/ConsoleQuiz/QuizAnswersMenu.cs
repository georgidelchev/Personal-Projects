using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleQuiz
{
    public class QuizAnswersMenu
    {
        public static string[] arr = new string[5];
        public static int counter = 1;
        public void AddingToArray()
        {

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[j] = QuizChapters.answers[i][j];
                }
            }

        }
        public void ChaptersOptionsMenu()
        {
            ProgrammingQuizMainScreen.isSelected = false;

            ProgrammingQuizMainScreen.optionsCount = 5;
            ProgrammingQuizMainScreen.selected = 1;

            Console.WriteLine();
            AddingToArray();

            while (!ProgrammingQuizMainScreen.isSelected)
            {

                for (int i = 1; i <= ProgrammingQuizMainScreen.optionsCount; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (ProgrammingQuizMainScreen.selected == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" █ ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    Console.WriteLine($"{i:d2}. {arr[i - 1]}");
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (ProgrammingQuizMainScreen.selected == 1)
                        {
                            ProgrammingQuizMainScreen.selected = ProgrammingQuizMainScreen.optionsCount;
                        }
                        else
                        {
                            ProgrammingQuizMainScreen.selected -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (ProgrammingQuizMainScreen.selected == ProgrammingQuizMainScreen.optionsCount)
                        {
                            ProgrammingQuizMainScreen.selected = 1;
                        }
                        else
                        {
                            ProgrammingQuizMainScreen.selected += 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.F:
                        ProgrammingQuizMainScreen.isSelected = true;
                        break;
                }

                if (!ProgrammingQuizMainScreen.isSelected)
                {
                    Console.CursorTop -= ProgrammingQuizMainScreen.optionsCount;
                }
            }
        }
    }
}
