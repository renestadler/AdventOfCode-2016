using Days.Shared;
using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day03
    {
        public static long PartOne(IEnumerable<string> input)
        {
            long possible = 0;
            foreach (string s in input)
            {
                var parts = s.Split(" ").Select(s1 => int.Parse(s1)).ToArray();
                if (parts[2] < parts[0] + parts[1] &&
                   parts[0] < parts[2] + parts[1] &&
                   parts[1] < parts[0] + parts[2])
                {
                    possible++;
                }
            }
            return possible;
        }

        public static int PartTwo(IEnumerable<string> input)
        {
            int possible = 0;
            var triangles = new List<Triangle>();
            var inputI = input.ToArray();
            for (int i = 0; i < input.Count(); i += 3)
            {
                var x = inputI[i].Split(" ").Select(s1 => int.Parse(s1)).ToArray();
                var y = inputI[i + 1].Split(" ").Select(s1 => int.Parse(s1)).ToArray();
                var z = inputI[i + 2].Split(" ").Select(s1 => int.Parse(s1)).ToArray();
                triangles.Add(new Triangle() { X = x[0], Y = y[0], Z = z[0] });
                triangles.Add(new Triangle() { X = x[1], Y = y[1], Z = z[1] });
                triangles.Add(new Triangle() { X = x[2], Y = y[2], Z = z[2] });
            }
            foreach (Triangle t in triangles)
            {
                if (t.X < t.Y + t.Z &&
                   t.Y < t.X + t.Z &&
                   t.Z < t.Y + t.X)
                {
                    possible++;
                }
            }
            return possible;
        }
    }
}
