using System;
using System.Linq;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopTimes = int.Parse(Console.ReadLine());
            int k = 1;
            int i = 0;
            int sum = 0;
            int[] array = new int[0];
            Console.Write("Length Before:" + array.Length + Environment.NewLine);

            while (i < loopTimes)
            {

                Array.Resize(ref array, k);

                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"[{i}] {array[i]}");
                i++;                
                k++;
                
            }
            
            sum = array.Sum();
            
            Array.Sort(array);
            Console.Write("Length After:" + array.Length + Environment.NewLine);
            Console.WriteLine("Array elements + sorted: " + Environment.NewLine);
            
            foreach (var value in array)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"The sum of these numbers is: {sum} {Environment.NewLine}");
        }
    }
}
