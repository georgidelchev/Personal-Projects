using System;
using System.Linq;

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
                arr = arr.Where((source, index) => index != elementToDelete).ToArray();
                Console.WriteLine();
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
