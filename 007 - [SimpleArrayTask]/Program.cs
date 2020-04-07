using System;
using System.Linq;

namespace FindingBiggestAndSmallestArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array Length: ");
            int elements = int.Parse(Console.ReadLine());

            double[] array = new double[elements];

            Console.WriteLine("Enter values:" + Environment.NewLine);

            for (int i = 0; i < array.Length; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                array[i] = numbers;
            }

            double min = array[0];
            double max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Min element: {min}");
            Console.WriteLine($"Max element: {max}" + Environment.NewLine);

            Array.Sort(array);

            Console.WriteLine("Sorted by ascending:");
            foreach (var value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine(Environment.NewLine);

            array = array.OrderByDescending(des => des).ToArray();
            Console.WriteLine("Sorted by descending:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
