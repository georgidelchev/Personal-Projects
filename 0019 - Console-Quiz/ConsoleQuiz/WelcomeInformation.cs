using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleQuiz
{
    public class WelcomeInformation
    {
        public static string[] title =
        {

                "              ██████╗░██████╗░░█████╗░░██████╗░██████╗░░█████╗░███╗░░░███╗███╗░░░███╗██╗███╗░░██╗░██████╗░",
                "              ██╔══██╗██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔══██╗████╗░████║████╗░████║██║████╗░██║██╔════╝░",
                "              ██████╔╝██████╔╝██║░░██║██║░░██╗░██████╔╝███████║██╔████╔██║██╔████╔██║██║██╔██╗██║██║░░██╗░",
                "              ██╔═══╝░██╔══██╗██║░░██║██║░░╚██╗██╔══██╗██╔══██║██║╚██╔╝██║██║╚██╔╝██║██║██║╚████║██║░░╚██╗",
                "              ██║░░░░░██║░░██║╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░╚═╝░██║██║░╚═╝░██║██║██║░╚███║╚██████╔╝",
                "              ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░",
                "                                                                           ",
                "                                              ░██████╗░██╗░░░██╗██╗███████╗",
                "                                              ██╔═══██╗██║░░░██║██║╚════██║",
                "                                              ██║██╗██║██║░░░██║██║░░███╔═╝",
                "                                              ╚██████╔╝██║░░░██║██║██╔══╝░░",
                "                                              ░╚═██╔═╝░╚██████╔╝██║███████╗",
                "                                              ░░░╚═╝░░░░╚═════╝░╚═╝╚══════╝",
        };

        public static string[] informationLetters =
        {
            "H", "e", "l", "l", "o", "!"," ",
            "T", "h", "i","s"," ","i","s"," ","a"," ","Q","u","i","z"," ","G","a","m","e","!","\n\n",
            "T", "o", " ", "a", "n", "s", "w", "e", "r", " ", "t", "h","e"," ","q","u","e","s","t","i","o","n","s","\n",
            "p","l","e","a","s","e"," ","u","s","e"," ","E","N","T","E","R"," ","o","r"," ","F","!","\n\n",
            "T","o"," ","s","e","l","e","c","t"," ","a","n"," ","o","p","t","i","o","n","\n",
            "p","l","e","a","s","e"," ","u","s","e"," ","A","R","R","O","W"," ","K","E","Y","S"," ","o","r"," ","W","/","S","!","\n\n"
        };

        public void QuizTitle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('\n', 7));

            foreach (string item in title)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }

            Thread.Sleep(2500);
            Console.WriteLine("\n\t\t\t\t\t\tPress any key to continue: ");
            Console.ReadKey();
            for (int i = 0; i < title.Length + 2; i++)
            {
                ClearingLine();
                Thread.Sleep(500);
            }
            Thread.Sleep(2500);
            Console.Clear();
        }

        public void QuizInformation()
        {
            foreach (string item in informationLetters)
            {
                Console.Write(item);
                //Thread.Sleep(300);
            }

            Thread.Sleep(2500);
            for (int i = 0; i < 8; i++)
            {
                ClearingLine();
                Thread.Sleep(500);
            }
        }
        public static void ClearingLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
