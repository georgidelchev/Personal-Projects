using System;
using System.Collections;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "CSharp - Timer";
            Console.ForegroundColor = ConsoleColor.Red;


            string[] zeroToNine = new string[]
            {                       "\t\t\t\t\t\t\t\t\t\t\t░█████╗░"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t██╔══██╗"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t██║░░██║"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t██║░░██║"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t╚█████╔╝"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t░╚════╝░",




                                    "\t\t\t\t\t\t\t\t\t\t\t░░███╗░░"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t░████║░░"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t██╔██║░░"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t╚═╝██║░░"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t███████╗"+Environment.NewLine+
                                    "\t\t\t\t\t\t\t\t\t\t\t╚══════╝",



                                     "\t\t\t\t\t\t\t\t\t\t\t██████╗░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚════██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░░███╔═╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔══╝░░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t███████╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚══════╝",



                                     "\t\t\t\t\t\t\t\t\t\t\t██████╗░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚════██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░█████╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░╚═══██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██████╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚═════╝░",



                                     "\t\t\t\t\t\t\t\t\t\t\t░░██╗██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░██╔╝██║"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔╝░██║"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t███████║"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚════██║"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░░░░░╚═╝",



                                     "\t\t\t\t\t\t\t\t\t\t\t███████╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔════╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██████╗░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚════██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██████╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚═════╝░",




                                     "\t\t\t\t\t\t\t\t\t\t\t░█████╗░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔═══╝░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██████╗░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔══██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚█████╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░╚════╝",



                                     "\t\t\t\t\t\t\t\t\t\t\t███████╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚════██║"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░░░░██╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░░░██╔╝░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░░██╔╝░░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░░╚═╝░░░",



                                     "\t\t\t\t\t\t\t\t\t\t\t░█████╗░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔══██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚█████╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔══██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚█████╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░╚════╝░",



                                     "\t\t\t\t\t\t\t\t\t\t\t░█████╗░"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t██╔══██╗"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t╚██████║"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░╚═══██║"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░█████╔╝"+Environment.NewLine+
                                     "\t\t\t\t\t\t\t\t\t\t\t░╚════╝░"


            };

            for (int i = 1; i <= 180; i++)
            {
                Console.SetWindowSize(i, 55);
                Thread.Sleep(10);
            }

            int num = 0;
            bool flag = true;

            Console.Write("Enter starting number: ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong format!");
                flag = false;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = num; i >= 0; i--)
            {
                Thread.Sleep(950);
                Console.Clear();
                Console.SetCursorPosition(0, 15);
                if (num > 0 && num <= 9)
                {
                    if (i == 0)
                    {
                        break;
                    }

                    Console.WriteLine(zeroToNine[i]);
                }
                else
                {

                    int numberCopy = i;
                    ArrayList aL = new ArrayList();

                    while (numberCopy != 0)
                    {
                        int digit = numberCopy % 10;
                        numberCopy /= 10;

                        aL.Add(digit);
                    }
                    aL.Reverse();

                    foreach (int value in aL)
                    {

                        Console.Write(zeroToNine[value]);
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine(zeroToNine[0]);
            }

            Thread.Sleep(10000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
