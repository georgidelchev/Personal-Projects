using System;

namespace FindFirstAndSecondLargestNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];

            Console.WriteLine($"Enter {arrSize} elements in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arr[i] += numbers;

            }

            int firstMax, secondMax;
            firstMax = secondMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else if ((arr[i] > secondMax) && (arr[i] < firstMax))
                {
                    secondMax = arr[i];
                }
            }

            Console.WriteLine($"First largest = {firstMax}");
            Console.WriteLine($"Second largest = {secondMax}");
        }
    }
}
