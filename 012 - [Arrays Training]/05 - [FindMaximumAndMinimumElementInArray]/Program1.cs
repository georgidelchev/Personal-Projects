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
            int minElement = int.MaxValue;
            int maxElement = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arr[i] += numbers;
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }

            Console.WriteLine($"Maximum element = {maxElement}");
            Console.WriteLine($"Minimum element = {minElement}");
        }
    }
}
