
using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day18
    {
        public static int PartOne(string input, int length)
        {
            List<string> trapMap = new List<string>();
            trapMap.Add(input);
            for (int i = 0; i < length - 1; i++)
            {
                string s = "";
                for (int j = 0; j < trapMap[0].Length; j++)
                {
                    if (j == 0)
                    {
                        if ((trapMap[i][j] == '^' && trapMap[i][j + 1] == '^') ||
                            (trapMap[i][j] == '.' && trapMap[i][j + 1] == '^'))
                        {
                            s += '^';
                        }
                        else
                        {
                            s += '.';
                        }
                    }
                    else if (j == trapMap[0].Length - 1)
                    {
                        if ((trapMap[i][j - 1] == '^' && trapMap[i][j] == '^') ||
                            (trapMap[i][j - 1] == '^' && trapMap[i][j] == '.'))
                        {
                            s += '^';
                        }
                        else
                        {
                            s += '.';
                        }
                    }
                    else
                    {
                        if ((trapMap[i][j - 1] == '^' && trapMap[i][j] == '^' && trapMap[i][j + 1] == '.') ||
                           (trapMap[i][j - 1] == '.' && trapMap[i][j] == '^' && trapMap[i][j + 1] == '^') ||
                           (trapMap[i][j - 1] == '^' && trapMap[i][j] == '.' && trapMap[i][j + 1] == '.') ||
                           (trapMap[i][j - 1] == '.' && trapMap[i][j] == '.' && trapMap[i][j + 1] == '^'))
                        {
                            s += '^';
                        }
                        else
                        {
                            s += '.';
                        }
                    }
                }
                trapMap.Add(s);
            }
            return trapMap.Sum(a => a.Select(a => a == '.' ? 1 : 0).Sum());
        }

        public static int PartTwo(string input, int length)
        {
            List<string> trapMap = new List<string>();
            trapMap.Add(input);
            for (int i = 0; i < length - 1; i++)
            {
                string s = "";
                for (int j = 0; j < trapMap[0].Length; j++)
                {
                    if (j == 0)
                    {
                        if ((trapMap[i][j] == '^' && trapMap[i][j + 1] == '^') ||
                            (trapMap[i][j] == '.' && trapMap[i][j + 1] == '^'))
                        {
                            s += '^';
                        }
                        else
                        {
                            s += '.';
                        }
                    }
                    else if (j == trapMap[0].Length - 1)
                    {
                        if ((trapMap[i][j - 1] == '^' && trapMap[i][j] == '^') ||
                            (trapMap[i][j - 1] == '^' && trapMap[i][j] == '.'))
                        {
                            s += '^';
                        }
                        else
                        {
                            s += '.';
                        }
                    }
                    else
                    {
                        if ((trapMap[i][j - 1] == '^' && trapMap[i][j] == '^' && trapMap[i][j + 1] == '.') ||
                           (trapMap[i][j - 1] == '.' && trapMap[i][j] == '^' && trapMap[i][j + 1] == '^') ||
                           (trapMap[i][j - 1] == '^' && trapMap[i][j] == '.' && trapMap[i][j + 1] == '.') ||
                           (trapMap[i][j - 1] == '.' && trapMap[i][j] == '.' && trapMap[i][j + 1] == '^'))
                        {
                            s += '^';
                        }
                        else
                        {
                            s += '.';
                        }
                    }
                }
                trapMap.Add(s);
            }
            return trapMap.Sum(a => a.Select(a => a == '.' ? 1 : 0).Sum());
        }
    }
}

