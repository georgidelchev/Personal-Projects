using System;

namespace PersonalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cars = { "Mercedes", "Audi", "BMW", "Toyota", "VW", "Alfa Romeo", "Honda", "Ferrari" };

            // Mercedes
            string[] modelsMercedes = { "C-Class", "G-Class", "AMG", "GLC", "GLE" };
            string[] mercedesInfo = {"Mercedes-Benz is a German global automobile marque and a division of Daimler AG. " +
                    "Mercedes-Benz is known for luxury vehicles, vans, trucks, buses, coaches and ambulances. The headquarters is in Stuttgart, Baden-Württemberg. " +
                    "The name first appeared in 1926 under Daimler-Benz. In 2018, Mercedes-Benz was the largest seller of premium vehicles in the world, having sold 2.31 million passenger cars. " +
                    "Mercedes-Benz origins' come from Daimler-Motoren-Gesellschaft's 1901 Mercedes and Karl Benz's 1886 Benz Patent-Motorwagen, which is widely regarded as the first gasoline-powered automobile. " +
                    "The slogan for the brand is the best or nothing."};

            // Audi
            string[] modelsAudi = { "Q7", "A4", "RS6", "A8", "E-Tron" };
            string[] audiInfo = { "Audi AG is a German automobile manufacturer that designs, engineers, produces, markets and distributes luxury vehicles. " +
                    "Audi is a member of the Volkswagen Group and has its roots at Ingolstadt, Bavaria, Germany. Audi-branded vehicles are produced in nine production facilities worldwide. " +
                    "The origins of the company are complex, going back to the early 20th century and the initial enterprises (Horch and the Audiwerke) " +
                    "founded by engineer August Horch; and two other manufacturers(DKW and Wanderer), leading to the foundation of Auto Union in 1932."};

           
            int i = 0;
            foreach (var value in cars)
            {
                Console.WriteLine($"Press key: [{i}]{Environment.NewLine}to see " +
                    $"some models and info about: {value}{Environment.NewLine}");
                i++;
            }

            Console.Write("Your choice: ");
            int key = int.Parse(Console.ReadLine());
            
            // checking for valid option
            while (key < 0 || key > cars.Length-1)
            {
                Console.WriteLine("Invalid option.Please try again!");
                key = int.Parse(Console.ReadLine());
            }
            int k = 0;
            while (k != key)
            {
                k++;
            }
            if (k == key)
            {
                Console.WriteLine();
                for (int a = 0; a < 5; a++)
                {
                    Console.Write($"<- {cars[k]} ->");
                }
                if (k == 0)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Some Mercedes models:");
                    foreach (var value in modelsMercedes)
                    {
                        Console.Write($"{value} ");
                    }
                    Console.WriteLine(Environment.NewLine);
                    foreach (var value in mercedesInfo)
                    {
                        Console.Write(value);
                    }
                    Console.WriteLine(Environment.NewLine);
                }
                else if (k == 1)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Some Audi models:");
                    foreach (var value in modelsAudi)
                    {
                        Console.Write($"{value} ");
                    }
                    Console.WriteLine(Environment.NewLine);
                    foreach (var value in audiInfo)
                    {
                        Console.Write(value);
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }


        }
    }
}
