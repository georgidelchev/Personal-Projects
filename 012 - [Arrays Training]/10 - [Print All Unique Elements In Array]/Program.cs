using System;

namespace PrintAllUniqueElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];
            int[] arr2 = new int[arrSize];

            Console.WriteLine($"Enter {arrSize} elements in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                arr[i] = elements;
            }

            Console.Write("Unique elements in the array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.Write(arr[i] + "\t");
                }
            }

        }
    }
}
