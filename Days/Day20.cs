using Days.Shared;
using System.Collections.Generic;

namespace AOC_2016
{
    public class Day20
    {
        public static long PartOne(string[] input)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < input.Length; i++)
            {
                points.Add(new Point
                {
                    X = long.Parse(input[i].Split("-")[0]),
                    Y = long.Parse(input[i].Split("-")[1])
                });
            }
            for (long i = 0; i < long.MaxValue;)
            {
                bool ok = true;
                for (int j = 0; j < points.Count; j++)
                {
                    if (points[j].X <= i && points[j].Y >= i)
                    {
                        ok = false;
                        i = points[j].Y;
                        break;
                    }
                }
                if (ok)
                {
                    return i;
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }

        public static long PartTwo(string[] input, long length)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < input.Length; i++)
            {
                points.Add(new Point
                {
                    X = long.Parse(input[i].Split("-")[0]),
                    Y = long.Parse(input[i].Split("-")[1])
                });
            }
            int numElems = 0;
            for (long i = 0; i <= length;)
            {
                bool ok = true;
                for (int j = 0; j < points.Count; j++)
                {
                    if (points[j].X <= i && points[j].Y >= i)
                    {
                        ok = false;
                        i = points[j].Y;
                        break;
                    }
                }
                if (ok)
                {
                    numElems++;
                }
                i++;
            }
            return numElems;
        }
    }
}

