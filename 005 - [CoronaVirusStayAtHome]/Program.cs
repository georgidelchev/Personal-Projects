using System;

namespace StayAtHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you at home?");
            string areYouAtHome = Console.ReadLine();

            while (areYouAtHome != "Yes".ToLower())
            {
                Console.WriteLine("Go to home!");
                Console.WriteLine("Are you at home now?");
                areYouAtHome = Console.ReadLine();
            }
            Console.WriteLine("Good! Stay there :)!");
        }
    }
}
