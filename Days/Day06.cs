using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOC_2016
{
    public class Day06
    {
        public static string PartOne(string[] input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char[][] elements = new char[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                elements[i] = input[i].ToCharArray();
            }
            for (int i = 0; i < elements[0].Length; i++)
            {
                Dictionary<char, int> keyValues = new Dictionary<char, int>();
                for (int j = 0; j < elements.Length; j++)
                {
                    if (keyValues.ContainsKey(elements[j][i]))
                    {
                        keyValues[elements[j][i]] = keyValues[elements[j][i]] + 1;
                    }
                    else
                    {
                        keyValues[elements[j][i]] = 1;
                    }
                }
                stringBuilder.Append(keyValues.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
            }
            return stringBuilder.ToString();
        }

        public static string PartTwo(string[] input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char[][] elements = new char[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                elements[i] = input[i].ToCharArray();
            }
            for (int i = 0; i < elements[0].Length; i++)
            {
                Dictionary<char, int> keyValues = new Dictionary<char, int>();
                for (int j = 0; j < elements.Length; j++)
                {
                    if (keyValues.ContainsKey(elements[j][i]))
                    {
                        keyValues[elements[j][i]] = keyValues[elements[j][i]] + 1;
                    }
                    else
                    {
                        keyValues[elements[j][i]] = 1;
                    }
                }
                stringBuilder.Append(keyValues.Aggregate((x, y) => x.Value < y.Value ? x : y).Key);
            }
            return stringBuilder.ToString();
        }
    }
}
