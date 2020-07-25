using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //  name, city, region, mobileOperator, mobile numbers;
            var phonebook = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>>();

            string input;

            while ((input = Console.ReadLine()) != "Save")
            {
                var splittedInput = input
                    .Split("=>")
                    .ToList();

                string username = splittedInput[0];
                string city = splittedInput[1];
                string region = splittedInput[2];
                string mobileOperator = splittedInput[3];
                string mobileNumber = splittedInput[4];

                if (!phonebook.ContainsKey(username))
                {
                    phonebook[username] = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();
                }

                if (!phonebook[username].ContainsKey(city))
                {
                    phonebook[username].Add(city, new Dictionary<string, Dictionary<string, List<string>>>());
                }

                if (!phonebook[username][city].ContainsKey(region))
                {
                    phonebook[username][city].Add(region, new Dictionary<string, List<string>>());
                }

                if (!phonebook[username][city][region].ContainsKey(mobileOperator))
                {
                    phonebook[username][city][region].Add(mobileOperator, new List<string>());

                }

                phonebook[username][city][region][mobileOperator].Add(mobileNumber);
            }

            int counter;
            foreach (var kvp1 in phonebook)
            {
                Console.Write($"{kvp1.Key}");
                counter = 1;

                foreach (var kvp2 in kvp1.Value)
                {
                    Console.Write(" -> " + kvp2.Key);

                    foreach (var kvp3 in kvp2.Value)
                    {
                        Console.Write(" -> " + kvp3.Key);

                        foreach (var kvp4 in kvp3.Value)
                        {
                            Console.WriteLine(" -> " + kvp4.Key);

                            Console.WriteLine($"{kvp1.Key} have {kvp4.Value.Count} number/s registered!");

                            Console.WriteLine($"{counter}#  " + string.Join(" | ", kvp4.Value));
                            counter++;
                        }
                    }

                }
            }
        }
    }
}
