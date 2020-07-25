using System;

namespace AOC_2016
{
    public class Day19
    {
        public static int PartOne(string input)
        {
            int numElves = int.Parse(input);
            return ElveRemover(numElves);
        }

        public static int PartTwo(string input)
        {
            int numElves = int.Parse(input);
            int counter = 1;
            while (3 * counter <= numElves)
            {
                counter *= 3;
            }
            if (numElves == counter)
            {
                return counter;
            }
            return numElves - counter + Math.Max(numElves - 2 * counter, 0);
        }

        private static int ElveRemover(int n)
        {
            if (n == 1)
                return 1;

            if ((n % 2) == 0)
                return 2 * ElveRemover(n / 2) - 1;

            if ((n % 2) == 1)
                return 2 * ElveRemover((n - 1) / 2) + 1;
            return -1;
        }
    }
}

