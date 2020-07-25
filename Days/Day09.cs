using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOC_2016
{
    public class Day09
    {
        public static int PartOne(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < input.Length;)
            {
                if (input[i] != '(')
                {
                    stringBuilder.Append(input[i]);
                    i++;
                }
                else
                {
                    var parenthesis = 0;
                    for (parenthesis = 0; parenthesis < input.Length - i; parenthesis++)
                    {
                        if (input[i + parenthesis] == ')')
                        {
                            break;
                        }
                    }
                    int length = int.Parse(input.Substring(i + 1, parenthesis - 1).Split("x")[0]);
                    int count = int.Parse(input.Substring(i + 1, parenthesis - 1).Split("x")[1]);
                    i += parenthesis + 1;
                    for (int j = 0; j < count; j++)
                    {
                        stringBuilder.Append(input.Substring(i, length));
                    }
                    i += length;
                }
            }
            return stringBuilder.Length;
        }

        public static long PartTwo(string input)
        {

            List<KeyValuePair<int, int>> multiplicators = new List<KeyValuePair<int, int>>();
            long multiplicator = 1;
            long counter = 0;
            for (int i = 0; i < input.Length;)
            {
                if (multiplicators.Any(a => a.Key == i))
                {
                    var elems = multiplicators.Where(a => a.Key == i).ToList();
                    foreach (var item in elems)
                    {
                        multiplicator /= item.Value;
                        multiplicators.Remove(item);
                    }
                }

                if (input[i] != '(')
                {
                    counter += multiplicator;
                    i++;
                }
                else
                {
                    var parenthesis = 0;
                    for (parenthesis = 0; parenthesis < input.Length - i; parenthesis++)
                    {
                        if (input[i + parenthesis] == ')')
                        {
                            break;
                        }
                    }
                    int length = int.Parse(input.Substring(i + 1, parenthesis - 1).Split("x")[0]);
                    int count = int.Parse(input.Substring(i + 1, parenthesis - 1).Split("x")[1]);
                    multiplicators.Add(new KeyValuePair<int, int>(i + parenthesis + 1 + length, count));
                    multiplicator *= count;
                    i += parenthesis + 1;
                }
            }
            return counter;
        }
    }
}

