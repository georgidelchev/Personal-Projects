using System;

namespace DeleteElementFromAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int arrSize = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {arrSize} elements in the array");
            int[] arr = new int[arrSize];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the element position to delete : ");
            int elementToDelete = int.Parse(Console.ReadLine());

            if (elementToDelete < 0 || elementToDelete > arr.Length)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                for (int i = elementToDelete; i < arrSize - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arrSize--;

                Console.WriteLine("Elements of array after delete are");
                for (int i = 0; i < arrSize; i++)
                {
                    Console.Write($"{arr[i]}\t");
                }
            }
        }
    }
}
