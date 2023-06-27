using System;
using System.Linq;

namespace _03Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessagesAndNameInput();

            int playerStartingPoints;
            int computerStartingPoints;

            GeneratingRandomPointsForThePlayerAndTheComputer(out playerStartingPoints, out computerStartingPoints);

            while (true)
            {
                PointsAndHitOrStayMessages(playerStartingPoints, computerStartingPoints);

                bool isSelected = false;
                int optionsCount = 2;
                int selected = 1;

                var choices = new[]
                {
                    "Hit",
                    "Stay"
                };

                while (!isSelected)
                {
                    DrawingTheOptionsAtTheScreen(optionsCount, selected, choices);

                    SwitchingOptions(ref isSelected, optionsCount, ref selected);

                    CheckingForSelectedOption(isSelected, optionsCount);
                }

                Console.Clear();
            }
        }

        private static void GeneratingRandomPointsForThePlayerAndTheComputer(out int playerStartingPoints, out int computerStartingPoints)
        {
            var rand = new Random();

            playerStartingPoints = rand.Next(0, 22);
            computerStartingPoints = rand.Next(0, 22);
        }

        private static void WelcomeMessagesAndNameInput()
        {
            Console.Title = "Blackjack Game!";

            Console.WriteLine($"Please enter your FIRST and LAST name," +
                $"{Environment.NewLine}separated by !SPACE INTERVAL!");

            string fullName = Console.ReadLine();
            Console.WriteLine($"Hello {fullName}!");
            Console.WriteLine();
        }

        private static void PointsAndHitOrStayMessages(int playerStartingPoints, int computerStartingPoints)
        {
            Console.WriteLine($"Your current points: {playerStartingPoints}");
            Console.WriteLine($"Computer current points: {computerStartingPoints}");

            Console.WriteLine();
            Console.WriteLine(" Hit or Stay?");
            Console.WriteLine();
        }

        private static void CheckingForSelectedOption(bool isSelected, int optionsCount)
        {
            if (!isSelected)
            {
                Console.CursorTop -= optionsCount;
            }
        }

        private static void DrawingTheOptionsAtTheScreen(int optionsCount, int selected, string[] choices)
        {
            for (int i = 1; i <= optionsCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (selected == i)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.Write(" █ ");
                }
                else
                {
                    Console.Write("   ");
                }

                Console.WriteLine($"{choices[i - 1]}");
                Console.ResetColor();
            }
        }

        private static void SwitchingOptions(ref bool isSelected, int optionsCount, ref int selected)
        {
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
                    // TODO LOGIC
                    isSelected = true;
                    break;
            }
        }
    }
}
