using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ThirdProblem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Input to test quicksort: https://pastebin.com/2HygC2Gf

            var numbers = Console
                .ReadLine()
                ?.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var start = 0;
            var end = numbers.Count - 1;

            var stopwatch = Stopwatch.StartNew();

            QuickSort(numbers, start, end);

            Console.WriteLine($"QuickSort elapsed: {stopwatch.Elapsed}");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        private static void QuickSort(List<int> arr, int start, int end)
        {
            var i = 0;

            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);

                QuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(List<int> numbers, int start, int end)
        {
            var tempNumber = 0;

            var pivot = numbers[end];
            var startIndex = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (numbers[j] <= pivot)
                {
                    startIndex++;
                    tempNumber = numbers[startIndex];
                    numbers[startIndex] = numbers[j];
                    numbers[j] = tempNumber;
                }
            }

            tempNumber = numbers[startIndex + 1];

            numbers[startIndex + 1] = numbers[end];

            numbers[end] = tempNumber;

            return startIndex + 1;
        }
    }
}
