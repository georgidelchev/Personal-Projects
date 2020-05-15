using System;

namespace CountEvenAndOddElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];

            Console.WriteLine($"Enter {arrSize} elements in the array");
            int evenCounter = 0;
            int oddCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] += elements;
                if (arr[i] % 2 == 0)
                {
                    evenCounter++;
                }
                else
                {
                    oddCounter++;
                }
            }

            Console.WriteLine($"Total even elements: {evenCounter}");
            Console.WriteLine($"Total odd elements: {oddCounter}");
        }
    }
}
