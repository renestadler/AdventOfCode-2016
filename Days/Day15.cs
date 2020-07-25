using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day15
    {
        public static int PartOne(string[] input)
        {
            List<KeyValuePair<int, int>> pairs = new List<KeyValuePair<int, int>>();
            var counter = 1;
            foreach (var item in input)
            {
                pairs.Add(
                    new KeyValuePair<int, int>(
                        int.Parse(item.Split(" ")[3]),
                        int.Parse(item.Split(" ")[11].Split(".")[0]) + counter));
                counter++;
            }
            for (int i = 0; true; i++)
            {
                if (pairs.All(a => (a.Value + i) % a.Key == 0))
                {
                    return i;
                }
            }
        }

        public static int PartTwo(string[] input)
        {
            List<KeyValuePair<int, int>> pairs = new List<KeyValuePair<int, int>>();
            var counter = 1;
            foreach (var item in input)
            {
                pairs.Add(
                    new KeyValuePair<int, int>(
                        int.Parse(item.Split(" ")[3]),
                        int.Parse(item.Split(" ")[11].Split(".")[0]) + counter));
                counter++;
            }
            pairs.Add(
                new KeyValuePair<int, int>(
                    11,
                    counter));
            for (int i = 0; true; i++)
            {
                if (pairs.All(a => (a.Value + i) % a.Key == 0))
                {
                    return i;
                }
            }
        }
    }
}

