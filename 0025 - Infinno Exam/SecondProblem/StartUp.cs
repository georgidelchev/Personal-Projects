using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondProblem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetEquals("abc", "dfg")); // empty result
            Console.WriteLine(GetEquals("abc", "cde")); // c
            Console.WriteLine(GetEquals("abc", "dafc")); // ac
            Console.WriteLine(GetEquals("abca", "deaf")); // a
        }

        private static string GetEquals(string firstString, string secondString)
        {
            var sb = new StringBuilder();

            var firstStringAsChars = firstString.ToCharArray();
            var secondStringAsChars = secondString.ToCharArray();

            foreach (var c in firstStringAsChars)
            {
                foreach (var c1 in secondStringAsChars)
                {
                    if (c == c1 &&
                        !sb.ToString().Contains(c))
                    {
                        sb.Append(c);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
