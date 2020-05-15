using System;

namespace _04_CountNegativeElementsInArray
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

            int negativeNumbersCounter = 0;
            foreach (int values in arr)
            {
                if (values < 0)
                {
                    negativeNumbersCounter++;
                }
            }
            Console.Write($"Total negative elements in array = {negativeNumbersCounter}");
        }
    }
}
