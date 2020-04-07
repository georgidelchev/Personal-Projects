using System;

namespace RandomArrayElementsAndFindingBiggestAndSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter elements of the array: ");
            int elementsOfTheArray = int.Parse(Console.ReadLine());
            while (elementsOfTheArray < 2)
            {
                elementsOfTheArray = int.Parse(Console.ReadLine());
            }
            int[] array = new int[elementsOfTheArray];


            int j = 0, k = 0, l = 0;
            Random RandomNumber = new Random();
            int max = array[0];
            int max2 = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomNumber.Next(1, 1000);
                if (array[i] > max)
                {
                    max = array[i];
                    j = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (elementsOfTheArray > 2)
                {
                    if (array[i] > max2 && array[i] < max)
                    {
                        max2 = array[i];
                        k = i;
                    }
                }
            }
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    l = i;
                }
            }
            Console.WriteLine("max: {0} {1} position", max, j);
            if (elementsOfTheArray > 2)
            {
                Console.WriteLine("max2: {0} {1} position", max2, k);
            }
            Console.WriteLine("min: {0} {1} position", min, l);
            int posCounter = 0;
            foreach (var entry in array)
            {
                Console.WriteLine($"[{posCounter}] > {entry}");
                posCounter++;
            }
        }
        static int RandomNumber(int MIN, int MAX)
        {

            Random random = new Random();
            return random.Next(1, 1000);
        }
    }
}