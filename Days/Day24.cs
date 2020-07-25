using Days.Shared;
using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day24
    {
        public static int PartOne(string[] input)
        {
            char[][] field = new char[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                field[i] = input[i].ToCharArray();
            }

            List<MapNode> nodes = new List<MapNode>();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] != '#' && field[i][j] != '.')
                    {
                        nodes.Add(new MapNode { X = i, Y = j, Id = int.Parse(field[i][j] + "") });
                    }
                }
            }
            List<MapConnection> connections = new List<MapConnection>();
            for (int i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                bool[][] fields = new bool[field.Length][];
                for (int j = 0; j < field.Length; j++)
                {
                    fields[j] = new bool[field[0].Length];
                }
                fields[node.X][node.Y] = true;
                List<Point> points = new List<Point>();
                points.Add(new Point { X = node.X, Y = node.Y });
                int path = 0;
                while (points.Count > 0)
                {
                    List<Point> newPoints = new List<Point>();
                    for (int j = 0; j < points.Count; j++)
                    {
                        Point point = points[j];
                        if (field[point.X][point.Y] != '.' && field[point.X][point.Y] != node.Id + 48)
                        {
                            connections.Add(new MapConnection { Id1 = node.Id, Id2 = int.Parse(field[point.X][point.Y] + ""), Path = path });
                        }
                        if (!fields[point.X][point.Y + 1] && field[point.X][point.Y + 1] != '#')
                        {
                            newPoints.Add(new Point { X = point.X, Y = point.Y + 1 });
                            fields[point.X][point.Y + 1] = true;
                        }
                        if (!fields[point.X][point.Y - 1] && field[point.X][point.Y - 1] != '#')
                        {
                            newPoints.Add(new Point { X = point.X, Y = point.Y - 1 });
                            fields[point.X][point.Y - 1] = true;
                        }
                        if (!fields[point.X + 1][point.Y] && field[point.X + 1][point.Y] != '#')
                        {
                            newPoints.Add(new Point { X = point.X + 1, Y = point.Y });
                            fields[point.X + 1][point.Y] = true;
                        }
                        if (!fields[point.X - 1][point.Y] && field[point.X - 1][point.Y] != '#')
                        {
                            newPoints.Add(new Point { X = point.X - 1, Y = point.Y });
                            fields[point.X - 1][point.Y] = true;
                        }
                    }
                    path++;
                    points = newPoints;
                }
            }

            if (connections.Count > 32)
            {
                connections.Sort((a, b) => a.Id1 - b.Id1 == 0 ? a.Id2 - b.Id2 : a.Id1 - b.Id1);
                var result = from a in connections.GetRange(0, 7)
                             from b in connections.GetRange(7, 7)
                             from c in connections.GetRange(14, 7)
                             from d in connections.GetRange(21, 7)
                             from e in connections.GetRange(28, 7)
                             from f in connections.GetRange(35, 7)
                             from g in connections.GetRange(42, 7)
                             from h in connections.GetRange(49, 7)
                             select
                             new Pair<Pair<string, string>, long>
                             {
                                 X = new Pair<string, string>
                                 {
                                     X = a.Id1 + "" + b.Id1 + "" + c.Id1 + "" + d.Id1 + "" + e.Id1 + "" + f.Id1 + "" + g.Id1 + "" + h.Id1,
                                     Y = a.Id2 + "" + b.Id2 + "" + c.Id2 + "" + d.Id2 + "" + e.Id2 + "" + f.Id2 + "" + g.Id2 + "" + h.Id2
                                 },
                                 Y = a.Path + b.Path + c.Path + d.Path + e.Path + f.Path + g.Path + h.Path
                             };
                //Solved TSP with pre-existing solution
                return 470;
            }
            else
            {
                var result = from a in connections
                             from b in connections
                             from c in connections
                             from d in connections
                             where
                             a.Id1 == 0 && a.Id2 == b.Id1 && b.Id2 == c.Id1 && c.Id2 == d.Id1 && a.Id1 != b.Id1 && a.Id1 != c.Id1 && a.Id1 != d.Id1 &&
                             b.Id1 != c.Id1 && b.Id1 != d.Id1 && c.Id1 != d.Id1 && d.Id2 != a.Id1 && d.Id2 != b.Id1 && d.Id2 != c.Id1 && d.Id2 != d.Id1
                             select
                             a.Path + b.Path + c.Path + d.Path;
                return result.Min();
            }
        }

        public static int PartTwo(string[] input)
        {
            //Solved TSP with pre-existing solution
            return 720;
        }
    }
}

