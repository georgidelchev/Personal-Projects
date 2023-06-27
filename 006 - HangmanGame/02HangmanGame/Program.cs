using System;
using System.Collections.Generic;
using System.Threading;

namespace _02HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int errorsCounter = 0;
            int guessesCounter = 0;

            var words = new List<string>
            {
                "abruptly", "absurd", "abyss", "affix", "askew",
                "avenue", "awkward", "axiom", "azure", "bagpipes",
                "bandwagon", "banjo", "bayou", "beekeeper", "bikini",
                "blitz", "blizzard", "boggle", "bookworm", "boxcar",
                "boxful", "buckaroo", "buffalo", "buffoon", "buxom",
                "buzzard", "buzzing", "buzzwords", "caliph", "cobweb",
                "cockiness", "croquet", "crypt", "curacao", "cycle",
                "daiquiri", "dirndl", "disavow", "dizzying", "duplex",
                "dwarves", "embezzle", "equip", "espionage", "euouae",
                "exodus", "faking", "fishhook", "fixable", "fjord",
                "flapjack", "flopping", "fluffiness", "flyby", "foxglove",
                "frazzled", "frizzled", "fuchsia", "funny", "gabby",
                "galaxy", "galvanize", "gazebo", "giaour", "gizmo",
                "glowworm", "glyph", "gnarly", "gnostic", "gossip",
                "grogginess", "haiku", "haphazard", "hyphen", "iatrogenic",
                "icebox", "injury", "ivory", "ivy", "jackpot",
                "jaundice", "jawbreaker", "jaywalk", "jazziest", "jazzy",
                "jelly", "jigsaw", "jinx", "jiujitsu", "jockey",
                "jogging", "joking", "jovial", "joyful", "juicy",
                "jukebox", "jumbo", "kayak", "kazoo", "keyhole",
                "khaki", "kilobyte", "kiosk", "kitsch", "kiwifruit",
                "klutz", "knapsack", "larynx", "lengths", "lucky",
                "luxury", "lymph", "marquis", "matrix", "megahertz",
                "microwave", "mnemonic", "mystify", "naphtha", "nightclub",
                "nowadays", "numbskull", "nymph", "onyx", "ovary",
                "oxidize", "oxygen", "pajama", "peekaboo", "phlegm",
                "pixel", "pizazz", "pneumonia", "polka", "pshaw",
                "psyche", "puppy", "puzzling", "quartz", "queue",
                "quips", "quixotic", "qui", "quizzes", "quorum",
                "razzmatazz", "rhubarb", "rhythm", "rickshaw", "schnapps",
                "scratch", "shiv", "snazzy", "sphinx", "spritz",
                "squawk", "staff", "strength", "strengths", "stretch",
                "stronghold", "stymied", "subway", "swivel", "syndrome",
                "thriftless", "thumbscrew", "topaz", "transcript", "transgress",
                "transplant", "triphthong", "twelfth", "twelfths", "unknown",
                "unworthy", "unzip", "uptown", "vaporize", "vixen",
                "vodka", "voodoo", "vortex", "voyeurism", "walkway",
                "waltz", "wave", "wavy", "waxy", "wellspring",
                "wheezy", "whiskey", "whizzing", "whomever", "wimpy",
                "witchcraft", "wizard", "woozy", "wristwatch", "wyvern",
                "xylophone", "yachtsman", "yippee", "yoked", "youthful",
                "yummy", "zephyr", "zigzag", "zigzagging", "zilch",
                "zipper", "zodiac", "zombie",
            };

            string word = "";
            string wordCopy = "";

            List<char> wordLengthToStars;

            RandomisingWordAndMakeItWithStars(words, out word, out wordCopy, out wordLengthToStars);
            Console.WriteLine(word);
            while (true)
            {
                if (errorsCounter == 1)
                {
                    FirstHangman();
                }
                else if (errorsCounter == 2)
                {
                    SecondHangman();
                }
                else if (errorsCounter == 3)
                {
                    ThirdHangman();
                }
                else if (errorsCounter == 4)
                {
                    ForthHangman();
                }
                else if (errorsCounter == 5)
                {
                    FifthHangman();
                }
                else if (errorsCounter == 6)
                {
                    SixthHangman();
                    Console.WriteLine();
                    Console.WriteLine("You lost!");
                    Console.WriteLine($"The word was: {wordCopy}");
                    break;
                }

                Console.WriteLine("Current word: " + string.Join(" ", wordLengthToStars));

                Console.Write("Enter your letter: ");
                char letterInput = char.Parse(Console.ReadLine());
                MakingStarsWithLetters(ref errorsCounter, ref guessesCounter, ref word, wordLengthToStars, letterInput);

                if (guessesCounter == word.Length)
                {
                    Console.Clear();
                    Console.WriteLine("You won!");
                    Console.WriteLine($"The word was: {wordCopy}");
                    break;
                }

                Console.Clear();
            }
        }

        private static void MakingStarsWithLetters(ref int errorsCounter, ref int guessesCounter, ref string word, List<char> wordLengthToStars, char letterInput)
        {
            if (word.Contains(letterInput))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letterInput)
                    {
                        wordLengthToStars[i] = word[i];

                        guessesCounter++;
                    }
                }

                Console.WriteLine(string.Join("", wordLengthToStars));
            }
            else
            {
                errorsCounter++;
            }
        }

        private static void RandomisingWordAndMakeItWithStars(List<string> words, out string word, out string wordCopy, out List<char> wordLengthToStars)
        {
            Random random = new Random();

            int randIndex = random.Next(0, words.Count + 1);
            word = words[randIndex];
            wordCopy = word;
            wordLengthToStars = new List<char>();
            foreach (var item in word)
            {
                wordLengthToStars.Add('*');
            }
        }

        static void FirstHangman()
        {
            Console.WriteLine("  ╔═");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
        }

        static void SecondHangman()
        {
            Console.WriteLine("  ╔══════╗");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
        }

        static void ThirdHangman()
        {
            Console.WriteLine("  ╔══════╗");
            Console.WriteLine("  ║      ║");
            Console.WriteLine("  ║      O");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
        }

        static void ForthHangman()
        {
            Console.WriteLine("  ╔══════╗");
            Console.WriteLine("  ║      ║");
            Console.WriteLine("  ║      O");
            Console.WriteLine("  ║      |");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
        }

        static void FifthHangman()
        {
            Console.WriteLine("  ╔══════╗");
            Console.WriteLine("  ║      ║");
            Console.WriteLine("  ║      O");
            Console.WriteLine("  ║     /|\\");
            Console.WriteLine("  ║");
            Console.WriteLine("  ║");
        }

        static void SixthHangman()
        {
            Console.WriteLine("  ╔══════╗");
            Console.WriteLine("  ║      ║");
            Console.WriteLine("  ║      O");
            Console.WriteLine("  ║     /|\\");
            Console.WriteLine("  ║     / \\");
            Console.WriteLine("  ║");
            Console.WriteLine("══╝");
        }
    }
}
