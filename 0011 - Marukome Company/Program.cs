using System;
using System.Linq;

namespace MarukomeCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] actualSalesSum = new double[12];
            double[] expectedSalesSum = new double[12];
            string[] months = { "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"};

            Console.Write($"Enter branch code: ");
            int branchCode = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"Actual sales: ");
                double actualSales = double.Parse(Console.ReadLine());
                actualSalesSum[i] = actualSales;

                Console.WriteLine($"Expected sales: ");
                double expectedSales = double.Parse(Console.ReadLine());
                expectedSalesSum[i] = expectedSales;
            }
            double actualSum = actualSalesSum.Sum();

            Console.WriteLine($"Branch code: {branchCode}");
            Console.WriteLine($"Total actual sales: {actualSum}");

            for (int i = 0; i < 12; i++)
            {
                double deviation = actualSalesSum[i] - expectedSalesSum[i];
                Console.WriteLine($"Deviation for {months[i]} : " +
                    $"{actualSalesSum[i]} - {expectedSalesSum[i]} = {deviation}");
            }
        }
    }
}
