using System;

namespace _02_PrintAllNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayLength];

            Console.WriteLine($"Enter {arrayLength} elements in the array");
            for (int i = 0; i < numbers.Length; i++)
            {
                int numbersToAdd = int.Parse(Console.ReadLine());
                numbers[i] += numbersToAdd;
            }

            Console.WriteLine();
            Console.Write("All negative elements in array are : ");
            foreach (int nums in numbers)
            {
                if (nums < 0)
                {
                    Console.Write($"{nums}\t");
                }
            }
            Console.WriteLine();
        }
    }
}
