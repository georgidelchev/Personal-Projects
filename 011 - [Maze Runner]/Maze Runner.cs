using System;
using System.Threading;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hello = {"H","e","l","l","o"," ",
                "t","r","a","v","e","l","l","e","r","!"};

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

            Console.WriteLine($"Lets talk 'bout myself sir " +
                $"{Environment.NewLine}and your mission of course! ");


            // info :


            Console.WriteLine();
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}
