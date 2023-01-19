using System;
using System.Collections.Generic;

namespace Organizer
{
    public class Program
    {
        protected static int amount = 4;

        public static void Main(string[] args)
        {
            // set amount of ints
            //int amount = 10;
            List<int> randomInts = RandomInts(Program.amount);

            // write unordered list
            Console.WriteLine("Unordered list:");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(randomInts[i]);
            }

            // order ints
            var ShiftHighestSort = new ShiftHighestSort();
            List<int> orderedInts = ShiftHighestSort.Sort(randomInts);

            // write ordered list
            Console.WriteLine("\nOrdered list:");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(orderedInts[i]);
            }

            // check if list is ordered
            if (ValidateInt(orderedInts))
            {
                Console.WriteLine("\nCheck succes: List is ordered.");
            }
            else
            {
                Console.WriteLine("\nCheck failed: List is not ordered.");
            }
        }

        private static List<int> RandomInts(int amount)
        {
            Random rnd = new Random();
            List<int> randomInts = new List<int>();

            // add x amount of random ints to list
            for (int i = 0; i < amount; i++)
            {
                int n = rnd.Next(-99, 99);
                randomInts.Add(n);
            }

            return randomInts;
        }

        private static bool ValidateInt(List<int> input)
        {
            bool check = true;
            for (int i = 0; i <= Program.amount - 1; i++)
            {
                if ((i + 1) <= Program.amount - 1)
                {
                    if (input[i] > input[i + 1])
                    {
                        check = false;
                    }
                }
            }
            return check;
        }
    }
}