using System;
using System.Linq;

namespace FindSumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[arrayLength];

            Console.WriteLine($"Enter {arrayLength} elements in the array");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arrayNumbers[i] += numbers;
            }
            Console.WriteLine($"Sum of all elements of array = {arrayNumbers.Sum()}");
        }
    }
}
