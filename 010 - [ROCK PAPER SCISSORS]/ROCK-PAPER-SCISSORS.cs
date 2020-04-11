using System;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating array that contains these three words:
            string[] elements = { "ROCK", "PAPER", "SCISSORS" };

            // creating randomize:
            Random random = new Random();

            //picking up the number of games:
            Console.Write("Games count: ");
            int gamesToPlay = int.Parse(Console.ReadLine());
            while (gamesToPlay < 1)
            {
                Console.WriteLine("Please play at least one game. :)");
                gamesToPlay = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            //message to choose:
            Console.WriteLine("Please choose:");
            Console.WriteLine($"[0] {elements[0]} ..");
            Console.WriteLine($"[1] {elements[1]} ..");
            Console.WriteLine($"[2] {elements[2]} ..");

            //variables to count player wins,computer wins and draw games:
            int playerWins = 0;
            int computerWins = 0;
            int draw = 0;

            string[] compWins = new string[gamesToPlay];
            string[] plrWins = new string[gamesToPlay];

            //counter and the game:
            int i = 0;
            while (i < gamesToPlay)
            {
                Console.ResetColor();
                Console.Write(">> ");
                int player = int.Parse(Console.ReadLine());

                while (player < 0 || player > 2)
                {
                    Console.WriteLine("Invalid! Try again...");
                    Console.Write(">> ");
                    player = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"{elements[0]} ...");
                Thread.Sleep(500);
                Console.WriteLine($"{elements[1]} ...");
                Thread.Sleep(500);
                Console.WriteLine($"{elements[2]} ...");
                Thread.Sleep(500);
                Console.Clear();

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
                compWins[i] = elements[computer];
                plrWins[i] = elements[player];
                i++;
                Thread.Sleep(500);

            }

            Thread.Sleep(1000);
            Console.Clear();

            string[] arr = { "S", "T", "A", "T", "I", "S", "T", "I", "C", "S", };
            foreach (string letters in arr)
            {
                Console.Write($"{letters} ");
                Thread.Sleep(500);
            }
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("       Statistics: ");
            Console.WriteLine();
            Console.WriteLine($"Total games played: [{gamesToPlay}]");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Player wins: [{playerWins}] - {(playerWins * 1.00 / gamesToPlay * 1.00) * 100:f2}%.");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Computer wins: [{computerWins}] - {(computerWins * 1.00 / gamesToPlay * 1.00) * 100:f2}%.");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Draw games: [{draw}] - {(draw * 1.00 / gamesToPlay * 1.00) * 100:f2}%.");

            Console.ResetColor();

            if (playerWins > computerWins && playerWins > draw)
            {
                Console.WriteLine();
                Console.WriteLine($"Congrats you won my tournament.{Environment.NewLine}" +
                    $"Your reward is a cup of grape juice.");
            }
            else if (computerWins > playerWins && computerWins > draw)
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
            Console.Write("Type 'yes' or 'y' for additional statistics: ");
            string command = Console.ReadLine();

            if (command == "yes" || command == "y")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write($"Player picks:");
                Console.ResetColor();
                int counter = 0;
                foreach (string picks in plrWins)
                {
                    Console.Write($"   [{counter}]{picks} ");
                    counter++;
                }

                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write($"Computer picks:");
                Console.ResetColor();
                counter = 0;
                foreach (string picks in compWins)
                {
                    Console.Write($" [{counter}]{picks} ");
                    counter++;
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thanks for playing <3 :).");
            }

        }
    }
}
