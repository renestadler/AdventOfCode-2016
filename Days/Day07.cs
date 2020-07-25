
using System.Collections.Generic;

namespace AOC_2016
{
    public class Day07
    {
        public static int PartOne(string[] input)
        {
            int suported = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool tls = false;
                bool bracketsEnabled = false;
                for (int j = 0; j < input[i].Length - 3; j++)
                {
                    if (input[i][j] == '[')
                    {
                        bracketsEnabled = true;
                    }
                    else if (input[i][j] == ']')
                    {
                        bracketsEnabled = false;
                    }
                    else
                    {
                        if (input[i][j] == input[i][j + 3] &&
                            input[i][j + 1] == input[i][j + 2] &&
                            input[i][j] != input[i][j + 1])
                        {
                            if (bracketsEnabled)
                            {
                                tls = false;
                                break;
                            }
                            else
                            {
                                tls = true;
                            }
                        }
                    }
                }
                if (tls)
                {
                    suported++;
                }
            }
            return suported;
        }

        public static int PartTwo(string[] input)
        {
            int suported = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool bracketsEnabled = false;
                List<string> abas = new List<string>();
                List<string> babs = new List<string>();
                for (int j = 0; j < input[i].Length - 2; j++)
                {
                    if (input[i][j] == '[')
                    {
                        bracketsEnabled = true;
                    }
                    else if (input[i][j] == ']')
                    {
                        bracketsEnabled = false;
                    }
                    else
                    {
                        if (input[i][j] == input[i][j + 2] &&
                            input[i][j] != input[i][j + 1])
                        {
                            if (bracketsEnabled)
                            {
                                babs.Add(input[i][j] + "" + input[i][j + 1] + "" + input[i][j + 2]);
                            }
                            else
                            {
                                abas.Add(input[i][j] + "" + input[i][j + 1] + "" + input[i][j + 2]);
                            }
                        }
                    }
                }

                for (int j = 0; j < abas.Count; j++)
                {
                    for (int k = 0; k < babs.Count; k++)
                    {
                        if (abas[j][0] == babs[k][1] && abas[j][1] == babs[k][0])
                        {
                            suported++;
                            abas.Clear();
                            babs.Clear();
                        }
                    }
                }
            }
            return suported;
        }
    }
}

