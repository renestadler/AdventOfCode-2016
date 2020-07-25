using System.Diagnostics;
using System.Linq;

namespace AOC_2016
{
    public class Day08
    {
        public static int PartOne(string[] input)
        {
            bool[][] fields = new bool[50][];
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = new bool[6];
            }
            foreach (var item in input)
            {
                if (item.StartsWith("rect"))
                {
                    int[] width = item.Split(" ")[1].Split("x").Select(a => int.Parse(a)).ToArray();
                    for (int i = 0; i < width[0]; i++)
                    {
                        for (int j = 0; j < width[1]; j++)
                        {
                            fields[i][j] = true;
                        }
                    }
                }
                else if (item.StartsWith("rotate row"))
                {
                    int height = int.Parse(item.Split(" ")[2].Split("=")[1]);
                    int width = int.Parse(item.Split(" ")[4]);
                    bool[] ar = new bool[50];
                    for (int i = 0; i < 50; i++)
                    {
                        ar[(i + width) % 50] = fields[i][height];
                    }
                    for (int i = 0; i < 50; i++)
                    {
                        fields[i][height] = ar[i];
                    }
                }
                else if (item.StartsWith("rotate column"))
                {
                    int width = int.Parse(item.Split(" ")[2].Split("=")[1]);
                    int height = int.Parse(item.Split(" ")[4]);
                    bool[] ar = new bool[6];
                    for (int i = 0; i < 6; i++)
                    {
                        ar[(i + height) % 6] = fields[width][i];
                    }
                    fields[width] = ar;

                }
            }
            var count = 0;
            for (int i = 0; i < fields.Length; i++)
            {
                for (int j = 0; j < fields[i].Length; j++)
                {
                    if (fields[i][j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static string PartTwo(string[] input)
        {
            bool[][] fields = new bool[50][];
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = new bool[6];
            }
            foreach (var item in input)
            {
                if (item.StartsWith("rect"))
                {
                    int[] width = item.Split(" ")[1].Split("x").Select(a => int.Parse(a)).ToArray();
                    for (int i = 0; i < width[0]; i++)
                    {
                        for (int j = 0; j < width[1]; j++)
                        {
                            fields[i][j] = true;
                        }
                    }
                }
                else if (item.StartsWith("rotate row"))
                {
                    int height = int.Parse(item.Split(" ")[2].Split("=")[1]);
                    int width = int.Parse(item.Split(" ")[4]);
                    bool[] ar = new bool[50];
                    for (int i = 0; i < 50; i++)
                    {
                        ar[(i + width) % 50] = fields[i][height];
                    }
                    for (int i = 0; i < 50; i++)
                    {
                        fields[i][height] = ar[i];
                    }
                }
                else if (item.StartsWith("rotate column"))
                {
                    int width = int.Parse(item.Split(" ")[2].Split("=")[1]);
                    int height = int.Parse(item.Split(" ")[4]);
                    bool[] ar = new bool[6];
                    for (int i = 0; i < 6; i++)
                    {
                        ar[(i + height) % 6] = fields[width][i];
                    }
                    fields[width] = ar;

                }
            }
            var count = 0;
            for (int i = 0; i < fields.Length; i++)
            {
                for (int j = 0; j < fields[i].Length; j++)
                {
                    if (fields[i][j])
                    {
                        count++;
                    }
                }
            }
            for (int i = 0; i < fields[0].Length; i++)
            {
                for (int j = 0; j < fields.Length; j++)
                {
                    Debug.Write(fields[j][i] ? "*" : " ");
                }
                Debug.WriteLine("");
            }
            return "";
        }
    }
}

