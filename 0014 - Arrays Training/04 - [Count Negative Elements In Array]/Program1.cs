using System;

namespace _04_CountNegativeElementsInArraySecondVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];

            int negativeNumbersCounter = 0;
            Console.WriteLine($"Enter {arraySize} elements in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arr[i] += numbers;
                if (arr[i] < 0)
                {
                    negativeNumbersCounter++;
                }
            }
            Console.Write($"Total negative elements in array = {negativeNumbersCounter}");
        }
    }
}
