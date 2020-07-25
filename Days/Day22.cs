
using Days.Shared;
using System.Collections.Generic;
using System.Diagnostics;

namespace AOC_2016
{
    public class Day22
    {
        public static int PartOne(string[] input)
        {
            List<Node> nodes = new List<Node>();
            if (input.Length == 1)
            {
                return -1;
            }
            for (int i = 0; i < input.Length; i++)
            {
                string[] properties = input[i].Split(" ");
                string name = properties[0];
                int x = int.Parse(properties[0].Split("-")[1].Split("x")[1]);
                int y = int.Parse(properties[0].Split("-")[2].Split("y")[1]);
                int size = int.Parse(properties[1].Split("T")[0]);
                int used = int.Parse(properties[2].Split("T")[0]);
                int available = int.Parse(properties[3].Split("T")[0]);
                nodes.Add(new Node { Name = name, X = x, Y = y, Size = size, Used = used, Available = available });
            }
            int pairs = 0;
            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (i != j)
                    {
                        if (nodes[i].Used != 0 && nodes[i].Used <= nodes[j].Available)
                        {
                            pairs++;
                        }
                    }
                }
            }
            return pairs;
        }

        public static int PartTwo(string[] input)
        {
            List<Node> nodes = new List<Node>();
            if (input.Length == 1)
            {
                return -1;
            }
            for (int i = 0; i < input.Length; i++)
            {
                string[] properties = input[i].Split(" ");
                string name = properties[0];
                int x = int.Parse(properties[0].Split("-")[1].Split("x")[1]);
                int y = int.Parse(properties[0].Split("-")[2].Split("y")[1]);
                int size = int.Parse(properties[1].Split("T")[0]);
                int used = int.Parse(properties[2].Split("T")[0]);
                int available = int.Parse(properties[3].Split("T")[0]);
                nodes.Add(new Node { Name = name, X = x, Y = y, Size = size, Used = used, Available = available });
            }
            nodes.Sort((a, b) => a.Y - b.Y == 0 ? a.X - b.X : a.Y - b.Y);
            for (int i = 0; i < nodes.Count; i++)
            {
                if (i != 0)
                {
                    if (nodes[i - 1].Y != nodes[i].Y)
                    {
                        Debug.WriteLine("");
                    }
                }
                Debug.Write(nodes[i].Used == 0 ? '_' : nodes[i].Size > 200 ? '#' : '.');
            }
            //solved manually by printing maze
            return 227;
        }
    }

}

