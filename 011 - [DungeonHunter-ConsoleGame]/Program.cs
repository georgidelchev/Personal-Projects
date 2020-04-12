using System;
using System.Threading;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            // >>> IF YOU FOUND A BUG , SEND ME A MESSAGE PLEASE!!! <<<

            //// string[] hello = {
            ////     "H","e","l","l","o",
            ////     " ",
            ////     "t","r","a","v","e","l","l","e","r",
            ////     "!"};
            ////
            //// for (int i = 0; i < hello.Length; i++)
            //// {
            ////     Console.Write($"{hello[i]}");
            ////     Thread.Sleep(200);
            //// }
            //// Thread.Sleep(300);
            //// Console.Clear();
            ////
            //// Console.WriteLine("         Hello traveller!");
            //// Console.WriteLine("        [Maze Runner v1.0]");
            //// Console.WriteLine($"{ Environment.NewLine}" +
            ////     $"Im Steve , nice to meet you, son :) ! " +
            ////     $"{Environment.NewLine}Welcome to the Maze Runner - " +
            ////     $"[{System.Environment.MachineName}]");
            ////
            //// Thread.Sleep(7000);
            //// Console.Clear();
            ////
            //// Console.WriteLine($"Lets talk 'bout myself sir! " +
            ////     $"{Environment.NewLine}...and your mission of course! ");
            //// Console.WriteLine("STORY: ");
            ////
            //// // >>>>>>>>>>>>>>>>>>>>>>>>>>>> TODO  MAKE GAME WINNABLE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //// // >>>>>>>>>>>>>>>>>>>>>>>>>>>> TODO  FIX THE TEXTS   !! !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ////
            //// // TODO ADD ARMORS AND SOME DEFENSIVE ITEMS !!!
            //// // TODO ADD ARMORS AND SOME DEFENSIVE ITEMS !!!
            ////
            //// Console.WriteLine();
            //// Console.Write("Press any key to continue: ");
            //// Console.ReadKey();
            //// Console.Clear();

            // Player statistics:
            double playerHealth = 100;
            double playerExp = 0;
            double playerLevel = 1;
            double playerAttack = 25;
            double playerCoins = 30;
            double playerDefence = 0;

            // Current equipment as names:
            string currentHelmet = string.Empty;
            string currentChestplate = string.Empty;
            string currentPants = string.Empty;
            string currentBoots = string.Empty;
            string currentSword = string.Empty;


            // Which monsters are beaten:
            bool isLittleDarkSpiderBeaten = false;
            bool isDarkSpiderBeaten = false;
            bool isGiantBeaten = false;
            bool isDarkWarlockBeaten = false;
            bool isBigGoblinBeaten = false;

            // Reward cards:
            bool isAlive = true;
            bool dmgReducer = false;
            bool reviveCard = false;

            // Rooms and Wins Count:
            int roomsCount = 0;
            int winsCount = 0;

            // while player is alive loop is true:
            while (isAlive)
            {
                // Increasing of rooms count:
                roomsCount++;
                if (roomsCount % 3 == 0)
                {
                    Console.WriteLine("Do you want to shop?");
                    Console.WriteLine("[0] YES");
                    Console.WriteLine("[1] NO");
                    int shoping = int.Parse(Console.ReadLine());
                    switch (shoping)
                    {
                        case 0:
                            string[] obsidianArmors = { "Obsidian helmet", "Obsidian chestplate",
                                                    "Obsidian pants", "Obsidian boots" };

                            string[] ironArmors ={"Iron helmet","Iron chestplate",
                                              "Iron pants","Iron boots" };

                            string[] bronzeArmors = { "Bronze helmet", "Bronze chestplate",
                                                  "Bronze pants", "Bronze boots", };

                            string[] swords = { "Wood sword", "Iron sword", "Obsidian sword" };

                            // Console.WriteLine("     WELCOME TO THE SHOP ROOM!");
                            // Console.WriteLine($"     We have a couple of items." +
                            //     $"{Environment.NewLine}            Lets see!");
                            // Thread.Sleep(3000);

                            Console.WriteLine("[0] to see the swords!");
                            Console.WriteLine("[1] to see the armors!");
                            Console.WriteLine("[2] to EXIT!");
                            int shopChoice = int.Parse(Console.ReadLine());
                            if (shopChoice == 0)
                            {
                                Console.WriteLine("What you want to buy?");

                                Console.WriteLine($"╔════════════════════════════════╗");
                                Console.WriteLine($"║       #=# SWORDS MENU #=#      ║");
                                Console.WriteLine($"║════════════════════════════════║");
                                Console.WriteLine($"║[0] - {swords[0]} - [50G]        ║");
                                Console.WriteLine($"║      [+10 dmg][+1 deff]        ║");
                                Console.WriteLine($"║════════════════════════════════║");
                                Console.WriteLine($"║[1] - {swords[1]} - [100G]       ║");
                                Console.WriteLine($"║      [+15 dmg][+3 deff]        ║");
                                Console.WriteLine($"║════════════════════════════════║");
                                Console.WriteLine($"║[2] - {swords[2]} - [200G]   ║");
                                Console.WriteLine($"║      [+20 dmg][+5 deff]        ║");
                                Console.WriteLine($"╚════════════════════════════════╝");

                                int order = int.Parse(Console.ReadLine());
                                if (order == 0)
                                {
                                    if (playerCoins >= 50)
                                    {
                                        playerCoins -= 50;
                                        Console.WriteLine($"You bought an Wooden Sword! " +
                                        $"{Environment.NewLine}Attack increased with: +10 Attack Damage! " +
                                        $"{Environment.NewLine}Deff increased with: +1");
                                        playerAttack += 10;
                                        playerDefence += 1;
                                        currentSword = "Wooden Sword";
                                    }
                                    else
                                    {
                                        double neededCoins = Math.Abs(playerCoins - 50);
                                        Console.WriteLine($"Not enough money!" +
                                        $"{Environment.NewLine}You need {neededCoins} coins more!");
                                    }
                                }
                                else if (order == 1)
                                {
                                    if (playerCoins >= 100)
                                    {
                                        playerCoins -= 100;
                                        Console.WriteLine($"You bought an Iron Sword! " +
                                        $"{Environment.NewLine}Attack increased with: +15 Attack Damage! " +
                                        $"{Environment.NewLine}Deff increased with: +3");
                                        playerAttack += 15;
                                        playerDefence += 3;
                                        currentSword = "Iron Sword";
                                    }
                                    else
                                    {
                                        double neededCoins = Math.Abs(playerCoins - 100);
                                        Console.WriteLine($"Not enough money!" +
                                        $"{Environment.NewLine}You need {neededCoins} coins more!");
                                    }

                                }
                                else if (order == 2)
                                {
                                    if (playerCoins >= 200)
                                    {
                                        playerCoins -= 200;
                                        Console.WriteLine($"You bought an Obsidian Sword! " +
                                        $"{Environment.NewLine}Attack increased with: +20 Attack Damage! " +
                                        $"{Environment.NewLine}Deff increased with: +5");
                                        playerAttack += 20;
                                        playerDefence += 5;
                                        currentSword = "Obsidian Sword";
                                    }
                                    else
                                    {
                                        double neededCoins = Math.Abs(playerCoins - 200);
                                        Console.WriteLine($"Not enough money!" +
                                        $"{Environment.NewLine}You need {neededCoins} coins more!");
                                    }
                                }

                            }
                            else if (shopChoice == 1)
                            {
                                Console.WriteLine($"╔════════════════════════════════╗");
                                Console.WriteLine($"║       #=# ARMORS MENU #=#      ║");
                                Console.WriteLine($"║════════════════════════════════║");
                                Console.WriteLine($"║[0] - Bronze Armor - [150G]     ║");
                                Console.WriteLine($"║      [+10 deff]                ║");
                                Console.WriteLine($"║════════════════════════════════║");
                                Console.WriteLine($"║[1] - Iron Armor - [250G]       ║");
                                Console.WriteLine($"║      [+18 deff]                ║");
                                Console.WriteLine($"║════════════════════════════════║");
                                Console.WriteLine($"║[2] - Obsidian Armor - [550G]   ║");
                                Console.WriteLine($"║      [+35 deff]                ║");
                                Console.WriteLine($"╚════════════════════════════════╝");
                            }
                            else if (shopChoice == 2)
                            {
                                break;
                            }
                            break;
                    }
                }

                Console.WriteLine($"#=# Room: {roomsCount} #=#"); // message which room is it
                int typeOfTheRoom = new Random().Next(1, 10); // picking random room

                // switching rooms:
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
                                monsterAttack = 6;
                                monsterHealth = 30;
                                break;
                            case 2:
                                monsterName = "Dark Spider";
                                monsterAttack = 10;
                                monsterHealth = 60;
                                break;
                            case 3:
                                monsterName = "Giant";
                                monsterAttack = 13;
                                monsterHealth = 80;
                                break;
                            case 4:
                                monsterName = "Dark Warlock";
                                monsterAttack = 15;
                                monsterHealth = 95;
                                break;
                            case 5:
                                monsterName = "Big Goblin [BOSS]";
                                monsterAttack = 20;
                                monsterHealth = 115;
                                break;
                        }

                        // message what monster you met
                        Console.WriteLine($"You've met a " +
                            $"[{monsterName}] " +
                            $"with [{monsterAttack}] attack damage " +
                            $"and [{monsterHealth}] health.");

                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Thread.Sleep(4500);
                        Console.Write(new string(' ', Console.BufferWidth));
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine();

                        // while player is alive 
                        // and he is not a winner 
                        while (!isWinner && isAlive)
                        {
                                                                                    // current armors
                            Console.WriteLine($"Sword: {currentSword} | Helmet: {currentHelmet} | Chestplate: {currentChestplate} | Pants: {currentPants} | Boots: {currentBoots}");
                            Console.WriteLine();
                                        // operation choose                                            // current stats
                            Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{playerHealth}]      ");
                            Console.WriteLine($"║  #=# Choose an operation: #=#  ║           ║Current Deffence: [{playerDefence}]   ");
                            Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{playerAttack}]      ");
                            Console.WriteLine($"║  [0]-Fight with the monster.   ║           ║Current Coins: [{playerCoins}]        ");
                            Console.WriteLine($"║  [1]-Run Away from the monster.║           ║Monster Name :[{monsterName}]         ");
                            Console.WriteLine($"║  [2]-Hide somewhere.           ║           ║Monster HP: [{monsterHealth}]         ");
                            Console.WriteLine($"╚════════════════════════════════╝           ║Monster Attack: [{monsterAttack}]     ");

                            // choosing the operation
                            int operationType = int.Parse(Console.ReadLine());

                            //re-typing the operation if its invalid
                            while (operationType < 0 || operationType > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid action:");
                                Console.WriteLine("╔════════════════════════════════╗");     //
                                Console.WriteLine("║  #=# Choose an operation: #=#  ║");     //
                                Console.WriteLine("║════════════════════════════════║");     //   Player
                                Console.WriteLine("║  [0]-Fight with the monster.   ║");     // Operations:
                                Console.WriteLine("║  [1]-Run Away from the monster.║");     //
                                Console.WriteLine("║  [2]-Hide somewhere.           ║");     //
                                Console.WriteLine("╚════════════════════════════════╝");
                                operationType = int.Parse(Console.ReadLine());
                            }
                            // fighting
                            if (operationType == 0)
                            {
                                while (isAlive && !isWinner)
                                {
                                    int criticalStrike = new Random().Next(1, 2);
                                    if (criticalStrike == 1) // he have critical strike
                                    {
                                        monsterHealth -= playerAttack * 3; // CRITICAL STRIKE (triple damage)
                                        playerHealth -= monsterAttack - playerDefence;   // player took a damage from the monster
                                        playerDefence -= monsterAttack; // decrease the armor
                                        if (playerDefence < 0)
                                        {
                                            playerDefence = 0;
                                        }
                                    }
                                    else if (criticalStrike == 2) // he dont have critical strike
                                    {
                                        monsterHealth -= playerAttack;   // hit per hit between
                                        playerHealth -= monsterAttack;   // player took a damage from the monster
                                    }

                                    if (monsterHealth <= 0)
                                    {
                                        Console.WriteLine("You killed that monster!");
                                        playerExp += 5;
                                        if (playerExp >= 100) // lvl up
                                        {
                                            playerLevel++;           //
                                            playerAttack += 5;       // some stats added to the 
                                            playerHealth += 10;      // player when he level up !
                                            playerExp -= 100;        //
                                        }

                                        isWinner = true;
                                        if (monsterName == "Little Dark Spider")
                                        {
                                            isLittleDarkSpiderBeaten = true;
                                        }
                                        else if (monsterName == "Dark Spider")
                                        {
                                            isDarkSpiderBeaten = true;
                                        }
                                        else if (monsterName == "Giant")
                                        {
                                            isGiantBeaten = true;
                                        }
                                        else if (monsterName == "Dark Warlock")
                                        {
                                            isDarkWarlockBeaten = true;
                                        }
                                        else if (monsterName == "Big Goblin [BOSS]")
                                        {
                                            isBigGoblinBeaten = true;
                                        }

                                        if (isWinner)
                                        {
                                            winsCount++;
                                        }
                                    }

                                    if (dmgReducer == true) // card of reducing damage
                                    {
                                        playerHealth = playerHealth + (playerHealth * 0.20);
                                        dmgReducer = false;
                                    }

                                    if (playerHealth <= 0)
                                    {
                                        if (reviveCard == true)
                                        {
                                            isAlive = true;
                                            Console.WriteLine("You died.. " +
                                                "BUT you have an revive card!");

                                            reviveCard = false;
                                            playerHealth = 100;
                                        }
                                        else if (reviveCard == false)
                                        {
                                            Console.WriteLine($"Sorry but you are out of HP." +
                                                $"{Environment.NewLine} " +
                                                $"You lost that.. :(");
                                            isAlive = false;

                                        }
                                        break;
                                    }
                                }
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
                    case 6: // ROOM THAT HAVE A CHEST WITH COINS
                        int chestWithCoins = new Random().Next(50, 150);
                        playerCoins += chestWithCoins;
                        Console.WriteLine($"You have found a chest with {chestWithCoins} coins," +
                            $"now you have {playerCoins}!");
                        Thread.Sleep(2000);
                        break;
                    case 7: // ROOM WITH HEALTH POTION
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
                    case 8: // TRAP ROOMS
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
                            string[] bricksCounting =
                                {
                                "first",
                                "second",
                                "third",
                                "fourth",
                                "fifth",
                                "sixth",
                                "seventh",
                                "eighth",
                                "ninth",
                                "tenth"
                                };

                            Console.WriteLine($"Damn.. you have lava and bricks.." +
                                $"{Environment.NewLine}" +
                                $"can you pass through this lava?");

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
                                    Console.WriteLine("OUCH THAT HURTS :@");
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

                        if (playerHealth <= 0)
                        {
                            Console.WriteLine("You died...");
                            isAlive = false;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 9: // AN CHEST WITH ITEM
                        Console.WriteLine("You found an chest with item!");

                        int chestType = new Random().Next(1, 6);
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
                                    Console.WriteLine(
                                        "You got an " +
                                        "2 coins!");
                                    break;
                                case 2:
                                    playerCoins += 4;
                                    Console.WriteLine(
                                        "You got an " +
                                        "4 coins!");
                                    break;
                                case 3:
                                    playerCoins += 6;
                                    Console.WriteLine(
                                        "You got an " +
                                        "6 coins!");
                                    break;
                                case 4:
                                    playerCoins += 8;
                                    Console.WriteLine(
                                        "You got an " +
                                        "8 coins!");
                                    break;
                                case 5:
                                    playerCoins += 10;
                                    Console.WriteLine(
                                        "You got an " +
                                        "10 coins!");
                                    break;
                                case 6:
                                    playerCoins += 12;
                                    Console.WriteLine(
                                        "You got an " +
                                        "12 coins!");
                                    break;
                                case 7:
                                    playerCoins += 14;
                                    Console.WriteLine(
                                        "You got an " +
                                        "14 coins!");
                                    break;
                                case 8:
                                    playerCoins += 16;
                                    Console.WriteLine(
                                        "You got an " +
                                        "16 coins!");
                                    break;
                                case 9:
                                    playerCoins += 18;
                                    Console.WriteLine(
                                        "You got an " +
                                        "18 coins!");
                                    break;
                                case 10:
                                    playerCoins += 20;
                                    Console.WriteLine(
                                        "You got an " +
                                        "20 coins!");
                                    break;
                            }
                        }
                        else if (chestType == 5)
                        {
                            Console.WriteLine($"You've found an 20% Damage Reduce Potion!" +
                                $"{Environment.NewLine}You can use it only in fight with monster!");
                            dmgReducer = true;
                        }
                        else if (chestType == 6)
                        {
                            Console.WriteLine($"You've found a REVIVE CARD!!!" +
                                $"{Environment.NewLine}" +
                                $"It will revive you automatically when you die!!!");
                            reviveCard = true;
                        }
                        Thread.Sleep(2000);
                        break;







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
            Console.WriteLine($"Health Diff: {Math.Abs(playerHealth)}");
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
