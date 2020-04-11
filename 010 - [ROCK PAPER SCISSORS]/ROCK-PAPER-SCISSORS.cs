using System;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = { "ROCK", "PAPER", "SCISSORS" };

            Random random = new Random();

            Console.Write("Games count: ");
            int gamesToPlay = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please choose:");
            Console.WriteLine("[0] ROCK ..");
            Console.WriteLine("[1] PAPER ..");
            Console.WriteLine("[2] SCISSORS ..");

            int playerWins = 0;
            int computerWins = 0;
            int draw = 0;

            int i = 0;
            while (i < gamesToPlay)
            {
                Console.ResetColor();
                Console.Write(">> ");
                int player = int.Parse(Console.ReadLine());

                Console.WriteLine("ROCK ..");
                Thread.Sleep(500);
                Console.WriteLine("PAPER ..");
                Thread.Sleep(500);
                Console.WriteLine("SCISSORS ..");
                Thread.Sleep(500);
                Console.Clear();

                while (player < 0 || player > 2)
                {
                    Console.WriteLine("Invalid! Try again...");
                    player = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"You choose: {elements[player]}");
                int computer = random.Next(0, 2);
                Console.WriteLine($"Computer choose: {elements[computer]}");

                if ((elements[player] == "ROCK" && elements[computer] == "ROCK")
                    || (elements[player] == "PAPER" && elements[computer] == "PAPER")
                    || (elements[player] == "SCISSORS" && elements[computer] == "SCISSORS"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Well... that means draw...");
                    draw++;
                    Console.ResetColor();
                }
                else if (elements[player] == "ROCK" && elements[computer] == "PAPER")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You loss...");
                    computerWins++;
                    Console.ResetColor();
                }
                else if (elements[player] == "ROCK" && elements[computer] == "SCISSORS")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won!!");
                    playerWins++;
                    Console.ResetColor();
                }
                else if (elements[player] == "PAPER" && elements[computer] == "ROCK")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won!!");
                    playerWins++;
                    Console.ResetColor();
                }
                else if (elements[player] == "PAPER" && elements[computer] == "SCISSORS")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You loss...");
                    computerWins++;
                    Console.ResetColor();
                }
                else if (elements[player] == "SCISSORS" && elements[computer] == "PAPER")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You loss...");
                    computerWins++;
                    Console.ResetColor();
                }
                else if (elements[player] == "SCISSORS" && elements[computer] == "ROCK")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won!!");
                    playerWins++;
                    Console.ResetColor();
                }
                i++;
                Thread.Sleep(500);
            }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Player wins: [{playerWins}] - {(playerWins * 1.00 / gamesToPlay * 1.00) * 100:f2}%");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Computer wins: [{computerWins}] - {(computerWins * 1.00 / gamesToPlay * 1.00) * 100:f2}%");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Draw games: [{draw}] - {(draw * 1.00 / gamesToPlay * 1.00) * 100:f2}%");

            Console.ResetColor();


            if (playerWins > computerWins)
            {
                Console.WriteLine();
                Console.WriteLine($"Congrats you won my tournament.{Environment.NewLine}" +
                    $"Your reward is a cup of grape juice.");
            }
            else if (computerWins > playerWins)
            {
                Console.WriteLine();
                Console.WriteLine($"Well... dont worry. This time you may losed , " +
                    $"{Environment.NewLine}but next time you will beat this metal box :3.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Handshaking...");
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for playing <3 :).");

        }
    }
}
