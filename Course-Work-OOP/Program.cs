using System;

namespace oop_kursova_rabota
{
    class Program
    {
        static void Main(string[] args)
        {
            Rhumb r = new Rhumb();


            double[] array = new double[5];
            double maxValue = 0.0;
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter values for Rhumb" + "[" + i + "]");
                r.Input();
                Console.WriteLine("Face: " + r.Face());
                r.Output();
                array[i] = r.Face();
                if (r.Face() > maxValue)
                {
                    maxValue = r.Face();
                    num = i;
                }

            }
            Console.WriteLine("Rhumb #" + num + " have max value: " + maxValue);
        }
    }
    class Rhumb
    {
        private double a, h;
        public Rhumb()
        {
            h = 0;
            a = 0;
        }
        public Rhumb(double a, double h)
        {
            this.a = a;
            this.h = h;
        }
        public void Input()
        {
            Console.Write("h: ");
            h = Int32.Parse(Console.ReadLine());
            Console.Write("a: ");
            a = Int32.Parse(Console.ReadLine());
            while (h > a || h == 0 || a == 0)
            {
                Console.WriteLine("Enter valid value!");
                Console.Write("h: ");
                h = Int32.Parse(Console.ReadLine());
                Console.Write("a: ");
                a = Int32.Parse(Console.ReadLine());
            }
        }
        public void Output()
        {
            Console.WriteLine("Output values> h:" + h + " a:" + a);
        }
        public double Face()
        {
            double f = a * h;
            return f;
        }
    }
}