using System;
using System.Threading;


namespace Chronometer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start!");
            Console.ReadKey();
            Console.Clear();
            
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(  "╔══════════════╗");
                        Console.WriteLine(  "║ hh - mm - ss ║");
                        Console.WriteLine( $"║ { hours:d2} : " +
                                             $"{minutes:d2} : " +
                                             $"{seconds:d2} ║");
                        Console.WriteLine(  "╚══════════════╝");
                        Thread.Sleep(950);
                        Console.Clear();
                    }
                }
            }
        }
    }
}
