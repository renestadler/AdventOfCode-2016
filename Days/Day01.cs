using Days.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day01
    {
        public static int PartOne(IEnumerable<string> input)
        {
            int direction = 0;
            int horizontal = 0;
            int vertical = 0;
            input.ToList().ForEach(s =>
            {
                if (s.StartsWith("R"))
                {
                    direction++;
                    if (direction > 3)
                    {
                        direction = 0;
                    }
                }
                else
                {
                    direction--;
                    if (direction < 0)
                    {
                        direction = 3;
                    }
                }
                int numBlocks = int.Parse(s.Substring(1));
                switch (direction)
                {
                    case 0: vertical += numBlocks; break;
                    case 1: horizontal += numBlocks; break;
                    case 2: vertical -= numBlocks; break;
                    case 3: horizontal -= numBlocks; break;
                }
            });
            return Math.Abs(horizontal) + Math.Abs(vertical);
        }

        public static int PartTwo(IEnumerable<string> input)
        {
            int direction = 0;
            int horizontal = 0;
            int vertical = 0;
            var points = new List<Point>();
            foreach (string s in input)
            {
                if (s.StartsWith("R"))
                {
                    direction++;
                    if (direction > 3)
                    {
                        direction = 0;
                    }
                }
                else
                {
                    direction--;
                    if (direction < 0)
                    {
                        direction = 3;
                    }
                }
                int numBlocks = int.Parse(s.Substring(1));
                for (int i = 0; i < numBlocks; i++)
                {
                    switch (direction)
                    {
                        case 0: vertical++; break;
                        case 1: horizontal++; break;
                        case 2: vertical--; break;
                        case 3: horizontal--; break;
                    }
                    if (points.Any(p => horizontal == p.X && vertical == p.Y))
                    {
                        return Math.Abs(horizontal) + Math.Abs(vertical);
                    }
                    else
                    {
                        points.Add(new Point() { X = horizontal, Y = vertical });
                    }

                }
            }
            return Math.Abs(horizontal) + Math.Abs(vertical);
        }
    }
}
