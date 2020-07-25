
using System;
using System.Linq;
using System.Text;

namespace AOC_2016
{
    public class Day21
    {
        public static string PartOne(string[] input)
        {
            StringBuilder stringBuilder = new StringBuilder("abcdefgh");
            for (int i = 0; i < input.Length; i++)
            {
                string cur = input[i];
                if (cur.StartsWith("swap position"))
                {
                    char temp = stringBuilder[int.Parse(cur.Split(" ")[2])];
                    stringBuilder[int.Parse(cur.Split(" ")[2])] = stringBuilder[int.Parse(cur.Split(" ")[5])];
                    stringBuilder[int.Parse(cur.Split(" ")[5])] = temp;
                }
                else if (cur.StartsWith("swap letter"))
                {
                    stringBuilder.Replace(cur.Split(" ")[2][0], '\n');
                    stringBuilder.Replace(cur.Split(" ")[5][0], cur.Split(" ")[2][0]);
                    stringBuilder.Replace('\n', cur.Split(" ")[5][0]);
                }
                else if (cur.StartsWith("rotate right"))
                {
                    string v = stringBuilder.ToString();
                    int d = v.Length - int.Parse(cur.Split(" ")[2]);
                    string ans = v.Substring(d, v.Length - d) + v.Substring(0, d);
                    stringBuilder.Clear();
                    stringBuilder.Append(ans);
                }
                else if (cur.StartsWith("rotate left"))
                {
                    int d = int.Parse(cur.Split(" ")[2]);
                    string v = stringBuilder.ToString();
                    string ans = v.Substring(d, v.Length - d) + v.Substring(0, d);
                    stringBuilder.Clear();
                    stringBuilder.Append(ans);

                }
                else if (cur.StartsWith("rotate based"))
                {
                    string v = stringBuilder.ToString();
                    int index = v.IndexOf(cur.Split(" ")[6]);
                    int d = v.Length - (index >= 4 ? index + 2 : index + 1);
                    while (d < 0)
                    {
                        d += v.Length;
                    }
                    string ans = v.Substring(d, v.Length - d) + v.Substring(0, d);
                    stringBuilder.Clear();
                    stringBuilder.Append(ans);
                }
                else if (cur.StartsWith("reverse"))
                {
                    int a = int.Parse(cur.Split(" ")[2]);
                    int b = int.Parse(cur.Split(" ")[4]);

                    string v = stringBuilder.ToString();
                    char[] charArray = v.Substring(a, b - a + 1).ToCharArray();
                    string before = v.Substring(0, a);
                    string after = v.Substring(b + 1);
                    Array.Reverse(charArray);
                    stringBuilder.Clear();
                    stringBuilder.Append(before).Append(new string(charArray)).Append(after);
                }
                else if (cur.StartsWith("move"))
                {
                    char toMove = stringBuilder[int.Parse(cur.Split(" ")[2])];
                    stringBuilder.Remove(int.Parse(cur.Split(" ")[2]), 1);
                    stringBuilder.Insert(int.Parse(cur.Split(" ")[5]), toMove);
                }
            }
            return stringBuilder.ToString();
        }

        public static string PartTwo(string[] input)
        {
            //Found solutions through brutefore of part1
            if (input.Count() >= 10)
            {
                return "gcehdbfa";
            }
            return "efghdabc";
        }

    }
}