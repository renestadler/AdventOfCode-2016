using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day04
    {
        public static long PartOne(IEnumerable<string> input)
        {
            long checksum = 0;
            foreach (string s in input)
            {
                var parts = s.Split("-");
                var numberAndResult = parts[parts.Length - 1].Split("[");
                var number = int.Parse(numberAndResult[0]);
                var result = numberAndResult[1].Substring(0, numberAndResult[1].Length - 1);
                Dictionary<char, int> alphabet = new Dictionary<char, int>();
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    foreach (char c in parts[i].ToArray())
                    {
                        if (alphabet.ContainsKey(c))
                        {
                            alphabet[c]++;
                        }
                        else
                        {
                            alphabet.Add(c, 1);
                        }
                    }
                }
                var orderedAlphabet = alphabet.OrderByDescending(a => a.Value).ThenBy(a => a.Key);
                int count = 0;
                var expectedResults = result.ToCharArray();
                bool valid = true;
                foreach (var entry in orderedAlphabet)
                {
                    if (entry.Key != expectedResults[count])
                    {
                        valid = false;
                        break;
                    }
                    else
                    {
                        count++;
                        if (count == expectedResults.Length)
                        {
                            break;
                        }
                    }
                }
                if (valid)
                {
                    checksum += number;
                }
            }
            return checksum;
        }

        public static int PartTwo(IEnumerable<string> input)
        {
            List<string> validRooms = new List<string>();
            foreach (string s in input)
            {
                var parts = s.Split("-");
                var numberAndResult = parts[parts.Length - 1].Split("[");
                var number = int.Parse(numberAndResult[0]);
                var result = numberAndResult[1].Substring(0, numberAndResult[1].Length - 1);
                Dictionary<char, int> alphabet = new Dictionary<char, int>();
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    foreach (char c in parts[i].ToArray())
                    {
                        if (alphabet.ContainsKey(c))
                        {
                            alphabet[c]++;
                        }
                        else
                        {
                            alphabet.Add(c, 1);
                        }
                    }
                }
                var orderedAlphabet = alphabet.OrderByDescending(a => a.Value).ThenBy(a => a.Key);
                int count = 0;
                var expectedResults = result.ToCharArray();
                bool valid = true;
                foreach (var entry in orderedAlphabet)
                {
                    if (entry.Key != expectedResults[count])
                    {
                        valid = false;
                        break;
                    }
                    else
                    {
                        count++;
                        if (count == expectedResults.Length)
                        {
                            break;
                        }
                    }
                }
                if (valid)
                {
                    validRooms.Add(s);
                }
            }
            var rooms = new List<string>();
            foreach (var room in validRooms)
            {
                var parts = room.Split("-");
                var numberAndResult = parts[parts.Length - 1].Split("[");
                var number = int.Parse(numberAndResult[0]) % 26;
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    string decryptedPart = "";
                    foreach (char c in parts[i].ToCharArray())
                    {
                        if (c + number > 'z')
                        {
                            decryptedPart += (char)(c + number - 'z' + 'a' - 1);
                        }
                        else
                        {
                            decryptedPart += (char)(c + number);
                        }
                    }
                    parts[i] = decryptedPart;
                }
                string result = "";
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    result += parts[i] + " ";
                }
                if (result.Equals("northpole object storage "))
                {
                    return int.Parse(numberAndResult[0]);
                }
            }
            return 0;
        }
    }
}
