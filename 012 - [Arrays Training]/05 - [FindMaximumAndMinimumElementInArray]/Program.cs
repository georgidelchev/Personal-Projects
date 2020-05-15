using System;
using System.Linq;

namespace _05_FindMaximumAndMinimumElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];

            Console.WriteLine($"Enter {arraySize} elements in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arr[i] += numbers;
            }

            Console.WriteLine($"Maximum element = {arr.Max()}");
            Console.WriteLine($"Minimum element = {arr.Min()}");
        }
    }
}
