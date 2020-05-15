using System;

namespace _08_InsertAnElementInArray
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
                int elements = int.Parse(Console.ReadLine());
                arr[i] += elements;
            }

            Console.Write("Enter element to insert: ");
            int insertedElement = int.Parse(Console.ReadLine());
            Console.Write($"Enter the element position 1 to {arrSize}: ");
            int position = int.Parse(Console.ReadLine());

            int[] secondArr = new int[arrSize + 1];
            for (int i = arrSize; i >= position; i--)
            {
                secondArr[i] = arr[i - 1];
            }

            secondArr[position - 1] = insertedElement;

            for (int i = 0; i < position - 1; i++)
            {
                secondArr[i] = arr[i];
            }

            Console.Write("Array elements after insertion: ");
            foreach (int values in secondArr)
            {
                Console.Write(values + "\t");
            }
        }
    }
}
