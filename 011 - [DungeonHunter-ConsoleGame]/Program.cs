using System;
using System.Threading;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hello = {
                "H","e","l","l","o",
                " ",
                "t","r","a","v","e","l","l","e","r",
                "!"};

            for (int i = 0; i < hello.Length; i++)
            {
                Console.Write($"{hello[i]}");
                Thread.Sleep(200);
            }
            Thread.Sleep(300);
            Console.Clear();

            Console.WriteLine("         Hello traveller!");
            Console.WriteLine("        [Maze Runner v1.0]");
            Console.WriteLine($"{ Environment.NewLine}" +
                $"Im Steve , nice to meet you, son :) ! " +
                $"{Environment.NewLine}Welcome to the Maze Runner - " +
                $"[{System.Environment.MachineName}]");

            Thread.Sleep(7000);
            Console.Clear();

            Console.WriteLine($"Lets talk 'bout myself sir! " +
                $"{Environment.NewLine}...and your mission of course! ");
            // TODO  INFO AND STORY ADD!!!!
            // TODO  INFO AND STORY ADD!!!!
            // TODO  INFO AND STORY ADD!!!!

            // >>>>>>>>>>>>>>>>>>>>>>>>>>>> TODO  MAKE GAME WINNABLE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            Console.WriteLine();
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();

            double playerHealth = 100;      //
            double playerExp = 0;           //
            double playerLevel = 1;         // stats of the player
            double playerAttack = 15;       //
            double playerCoins = 15;        //

            bool isAlive = true;
            bool dmgReducer = false;
            int roomsCount = 0;

            while (isAlive) // while player is alive
            {
                roomsCount++;

                Console.WriteLine($"#=# Room: {roomsCount} #=#");
                int typeOfTheRoom = new Random().Next(1, 10); // picking random room
                switch (typeOfTheRoom)
                {
                    case 1:  //
                    case 2:  //
                    case 3:  // here you will meet a random monster
                    case 4:  //
                    case 5:  //
                        int typeOfTheMonster = new Random().Next(1, 5);
                        double monsterAttack = 0;
                        double monsterHealth = 0;
                        string monsterName = string.Empty;
                        bool isWinner = false;
                        switch (typeOfTheMonster)
                        {
                            case 1:
                                monsterName = "Little Dark Spider";
                                monsterAttack = 2;
                                monsterHealth = 50;
                                break;
                            case 2:
                                monsterName = "Dark Spider";
                                monsterAttack = 5;
                                monsterHealth = 60;
                                break;
                            case 3:
                                monsterName = "Giant";
                                monsterAttack = 10;
                                monsterHealth = 65;
                                break;
                            case 4:
                                monsterName = "Dark Warlock";
                                monsterAttack = 12;
                                monsterHealth = 50;
                                break;
                            case 5:
                                monsterName = "Big Goblin [BOSS]";
                                monsterAttack = 18;
                                monsterHealth = 100;
                                break;
                        }

                        Console.WriteLine($"You've met a " +
                            $"[{monsterName}] " +
                            $"with [{monsterAttack}] attack damage " +
                            $"and [{monsterHealth}] health.");

                        while (!isWinner && isAlive)
                        {
                            Console.WriteLine($"╔════════════════════════════════╗                                        ");
                            Console.WriteLine($"║  #=# Choose an operation: #=#  ║           Current Health:[{playerHealth}]      ");
                            Console.WriteLine($"║════════════════════════════════║           Current Damage:[{playerAttack}]      ");
                            Console.WriteLine($"║  [0]-Fight with the monster.   ║                                        ");
                            Console.WriteLine($"║  [1]-Run Away from the monster.║           Monster HP:[{monsterHealth}] ");
                            Console.WriteLine($"║  [2]-Hide somewhere.           ║           Monster Attack:[{monsterAttack}]                             ");
                            Console.WriteLine("╚════════════════════════════════╝                                         ");
                            int operationType = int.Parse(Console.ReadLine());

                            while (operationType < 0 || operationType > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid action:");
                                Console.WriteLine("╔════════════════════════════════╗");     //
                                Console.WriteLine("║  #=# Choose an operation: #=#  ║");     //
                                Console.WriteLine("║════════════════════════════════║");     //
                                Console.WriteLine("║  [0]-Fight with the monster.   ║");     // Operations:
                                Console.WriteLine("║  [1]-Run Away from the monster.║");     //
                                Console.WriteLine("║  [2]-Hide somewhere.           ║");     //
                                Console.WriteLine("╚════════════════════════════════╝");
                                operationType = int.Parse(Console.ReadLine());
                            }

                            if (operationType == 0) // fighting
                            {
                                while (isAlive && !isWinner)
                                {
                                    monsterHealth -= playerAttack;   // hit per hit between
                                    playerHealth -= monsterAttack;   // player and the monster
                                    if (monsterHealth <= 0)
                                    {
                                        Console.WriteLine("You killed that monster!");
                                        playerExp += 2;
                                        if (playerExp >= 100) // lvl up
                                        {
                                            playerLevel++;
                                            playerAttack += 5;
                                            playerHealth += 10;
                                            playerExp -= 100;
                                        }
                                        isWinner = true;
                                        break;
                                    }

                                    if (playerHealth <= 0)
                                    {
                                        Console.WriteLine($"Sorry but you are out of HP." +
                                            $"{Environment.NewLine} You lost that.. :(");
                                        isAlive = false;
                                        break;
                                    }
                                }


                                if (dmgReducer == true)
                                {
                                    playerHealth = playerHealth + (playerHealth * 0.20);
                                }
                                dmgReducer = false;
                            }


                            else if (operationType == 1) // running away
                            {
                                int dmgOrNot = new Random().Next(1, 2);
                                if (dmgOrNot == 1)
                                {
                                    Console.WriteLine("You ran away successfully " +
                                        "without taking a damage!");
                                    break;
                                }
                                else
                                {
                                    playerHealth -= monsterAttack / 2;
                                    double took = monsterAttack / 2;
                                    Console.WriteLine($"Awghhh.... you were too slow..");
                                    Console.WriteLine($"You took [{took}] damage.");
                                }
                            }
                            else if (operationType == 2) // hiding
                            {
                                int hiding = new Random().Next(1, 2);
                                if (hiding == 1)
                                {
                                    Console.WriteLine("you hided yourself successfully in the bushes" +
                                        "without taking a damage!");
                                }
                                else
                                {
                                    playerHealth -= monsterAttack / 2;
                                    double took = monsterAttack / 2;
                                    Console.WriteLine($"Arghhh.... you were too slow..");
                                    Console.WriteLine($"You took [{took}] damage.");
                                }
                            }
                        }
                        break;
                    case 6:
                        int chestWithCoins = new Random().Next(50, 150);
                        playerCoins += chestWithCoins;
                        Console.WriteLine($"You have found a chest with {chestWithCoins} coins," +
                            $"now you have {playerCoins}!");
                        Thread.Sleep(2000);
                        break;
                    case 7:
                        int typePotion = new Random().Next(1, 3);
                        if (typePotion == 1)
                        {
                            Console.WriteLine("You have found a small health potion" +
                                "that brings to you [10] healt.");
                            playerHealth += 10;
                        }
                        else if (typePotion == 2)
                        {
                            Console.WriteLine("You have found a medium health potion" +
                                "that brings to you [15] healt.");
                            playerHealth += 15;
                        }
                        else if (typePotion == 3)
                        {
                            Console.WriteLine("You have found a large health potion" +
                                "that brings to you [25] healt regenerated.");
                            playerHealth += 25;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 8:
                        int trapType = new Random().Next(1, 5);
                        Console.WriteLine("You got an trap...");
                        if (trapType == 1)
                        {
                            Console.WriteLine("Some arrows in your body...");
                            playerHealth -= 3;
                        }
                        else if (trapType == 2)
                        {
                            int slimesCount = new Random().Next(1, 6);
                            Console.WriteLine("Arghh... a couple of" +
                                "slimes has jumped from the roof to your head.");
                            playerHealth -= slimesCount * 2;
                        }
                        else if (trapType == 3)
                        {
                            Console.WriteLine("FASTTT... TSUNAMI IS COMING...");
                            int howMuchDmg = new Random().Next(1, 5);
                            if (howMuchDmg == 1)
                            {
                                Console.WriteLine("30 seconds under water...");
                                playerHealth -= 2;
                            }
                            else if (howMuchDmg == 2)
                            {
                                Console.WriteLine("45 seconds under water...");
                                playerHealth -= 3;
                            }
                            else if (howMuchDmg == 3)
                            {
                                Console.WriteLine("60 seconds under water...");
                                playerHealth -= 5;
                            }
                            else if (howMuchDmg == 4)
                            {
                                Console.WriteLine("70 seconds under water...");
                                playerHealth -= 7;
                            }
                            else if (howMuchDmg == 5)
                            {
                                Console.WriteLine("90 seconds under water...");
                                playerHealth -= 9;
                            }
                        }
                        else if (trapType == 4)
                        {
                            string[] bricksCounting = {
                                "first",
                                "second",
                                "third",
                                "fourth",
                                "fifth",
                                "sixth",
                                "seventh",
                                "eighth",
                                "ninth",
                                "tenth" };

                            Console.WriteLine($"Damn.. you have lava and bricks.." +
                                $"{Environment.NewLine}can you pass through this lava?");
                            int bricks = 10;
                            int counter = 0;

                            while (counter < bricks)
                            {
                                int passOrNot = new Random().Next(1, 2);
                                if (passOrNot == 1)
                                {
                                    Console.WriteLine($"You've passed the " +
                                        $"{bricksCounting[counter]} brick. " +
                                        $"C'mon i believe in you boy!");
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Thread.Sleep(2000);
                                    Console.Write(new string(' ', Console.BufferWidth));
                                    Console.SetCursorPosition(0, Console.CursorTop);

                                }
                                else if (passOrNot == 2)
                                {
                                    Console.WriteLine("OUCH THAT HURST :@");
                                    playerHealth -= 2;
                                }
                                counter++;
                            }
                        }
                        else if (trapType == 5)
                        {
                            Console.WriteLine("Someone is throwing a Potions with poison to you...");
                            playerHealth -= 5;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 9:
                        Console.WriteLine("You found an chest with item!");
                        int chestType = new Random().Next(1, 5);
                        if (chestType == 1)
                        {
                            Console.WriteLine(":O You've found an Obsidian Sword!!!");
                            playerAttack += 10;
                            Console.WriteLine("Gained [10] Attack Damage!");
                        }
                        else if (chestType == 2)
                        {
                            Console.WriteLine("You've found an Health Booster!");
                            playerHealth += 5;
                        }
                        else if (chestType == 3)
                        {
                            Console.WriteLine("You've found an Level Card!");
                            playerLevel += 1;
                            playerAttack += 10;
                        }
                        else if (chestType == 4)
                        {
                            Console.WriteLine($"You've found some coins!! " +
                                $"{Environment.NewLine}lets count them!");
                            int coinsCount = new Random().Next(1, 10);
                            switch (coinsCount)
                            {
                                case 1:
                                    playerCoins += 2;
                                    break;
                                case 2:
                                    playerCoins += 4;
                                    break;
                                case 3:
                                    playerCoins += 6;
                                    break;
                                case 4:
                                    playerCoins += 8;
                                    break;
                                case 5:
                                    playerCoins += 10;
                                    break;
                                case 6:
                                    playerCoins += 12;
                                    break;
                                case 7:
                                    playerCoins += 14;
                                    break;
                                case 8:
                                    playerCoins += 16;
                                    break;
                                case 9:
                                    playerCoins += 18;
                                    break;
                                case 10:
                                    playerCoins += 20;
                                    break;
                            }
                        }
                        else if (chestType == 5)
                        {
                            Console.WriteLine($"You've found an 20% Damage Reduce Potion!" +
                                $"{Environment.NewLine}You can use it only in fight with monster!");
                            dmgReducer = true;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 10:
                        // TODO  ADD SHOP AND ITEMS TO BUY !!!!
                        // TODO  ADD SHOP AND ITEMS TO BUY !!!!
                        // TODO  ADD SHOP AND ITEMS TO BUY !!!!
                        // TODO  ADD SHOP AND ITEMS TO BUY !!!!
                        // TODO  ADD SHOP AND ITEMS TO BUY !!!!
                        break;
                }
            }

            string[] gameOver = { "G", "A", "M", "E", " ", "O", "V", "E", "R", "!" };
            for (int i = 0; i < gameOver.Length; i++)
            {
                Console.Write($"{gameOver[i]}");
                Thread.Sleep(200);
            }
            Console.Clear();
            Console.WriteLine("GAME OVER!");
            Console.WriteLine($"Health Diff: {playerHealth}");
            Console.WriteLine($"Total attack damage: {playerAttack}");
            Console.WriteLine($"Total coins earned: {playerCoins}");
            // TODO  add more statistics!!! - total wins
            // TODO  add more statistics!!! - damage dealt
            // TODO  add more statistics!!! - damage took
            // TODO  add more statistics!!! - purchases when i implemate shop
            // TODO  add more statistics!!! - OTHERS...



            // TODO  customizing:
            // TODO  other implementations:



            // TODO  MORE THINGS...
        }
    }
}
