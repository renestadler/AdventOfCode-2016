using Days.Shared;
using System.Collections.Generic;

namespace AOC_2016
{
    public class Day02
    {
        public static int PartOne(IEnumerable<string> input)
        {
            int number = 0;
            int[,] digits = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Point p = new Point { X = 1, Y = 1 };
            foreach (string s in input)
            {
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case 'U': p.X--; break;
                        case 'D': p.X++; break;
                        case 'L': p.Y--; break;
                        case 'R': p.Y++; break;
                    }
                    if (p.X < 0)
                    {
                        p.X = 0;
                    }
                    if (p.Y < 0)
                    {
                        p.Y = 0;
                    }
                    if (p.X > 2)
                    {
                        p.X = 2;
                    }
                    if (p.Y > 2)
                    {
                        p.Y = 2;
                    }
                }
                number *= 10;
                number += digits[p.X, p.Y];
            }
            return number;
        }

        public static string PartTwo(IEnumerable<string> input)
        {
            string number = "";
            char[,] digits = new char[,]
            {
                { '0', '0', '1', '0', '0' },
                { '0', '2', '3', '4', '0' },
                { '5', '6', '7', '8', '9' },
                { '0', 'A', 'B', 'C', '0' },
                { '0', '0', 'D', '0', '0' } };
            Point p = new Point { X = 2, Y = 0 };
            foreach (string s in input)
            {
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case 'U':
                            p.X--;
                            if (p.X == -1 || digits[p.Y, p.X] == '0')
                            {
                                p.X++;
                            }
                            break;
                        case 'D':
                            p.X++;
                            if (p.X == 5 || digits[p.Y, p.X] == '0')
                            {
                                p.X--;
                            }
                            break;
                        case 'L':
                            p.Y--;
                            if (p.Y == -1 || digits[p.Y, p.X] == '0')
                            {
                                p.Y++;
                            }
                            break;
                        case 'R':
                            p.Y++;
                            if (p.Y == 5 || digits[p.Y, p.X] == '0')
                            {
                                p.Y--;
                            }
                            break;
                    }
                }
                number += digits[p.X, p.Y];
            }
            return number;
        }
    }
}
