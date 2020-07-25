using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AOC_2016
{
    public class Day14
    {
        public static int PartOne(string input)
        {
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            List<string> hashes = new List<string>();
            for (int i = 0; i < 100000; i++)
            {
                StringBuilder hash = new StringBuilder();
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input + i));

                for (int j = 0; j < bytes.Length; j++)
                {
                    hash.Append(bytes[j].ToString("x2"));
                }
                string v = hash.ToString();
                hashes.Add(v);
            }
            List<KeyValuePair<int, char>> three = new List<KeyValuePair<int, char>>();
            List<KeyValuePair<int, char>> five = new List<KeyValuePair<int, char>>();
            for (int i = 0; i < hashes.Count; i++)
            {
                bool already3 = false;
                for (int j = 0; j < hashes[i].Length - 2; j++)
                {
                    if (hashes[i][j] == hashes[i][j + 1] &&
                        hashes[i][j] == hashes[i][j + 2])
                    {
                        if (j + 4 < hashes[i].Length)
                        {
                            if (hashes[i][j] == hashes[i][j + 3] && hashes[i][j] == hashes[i][j + 4])
                            {
                                five.Add(new KeyValuePair<int, char>(i, hashes[i][j]));
                                if (!already3)
                                {
                                    already3 = true;
                                    three.Add(new KeyValuePair<int, char>(i, hashes[i][j]));
                                }
                                break;
                            }
                        }
                        if (!already3)
                        {
                            already3 = true;
                            three.Add(new KeyValuePair<int, char>(i, hashes[i][j]));
                        }
                    }
                }
            }
            var count = 0;
            foreach (var item in three)
            {
                var fives = five.Where(f => f.Key <= item.Key + 1000 && f.Key > item.Key);
                fives = fives.Where(f => f.Value == item.Value);
                if (fives.Count() >= 1)
                {
                    count++;
                }
                if (count == 64)
                {
                    return item.Key;
                }
            }
            return 0;
        }

        public static int PartTwo(string input)
        {
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            List<string> hashes = new List<string>();
            for (int i = 0; i < 50000; i++)
            {
                StringBuilder hash = new StringBuilder();
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input + i));

                for (int j = 0; j < 2016; j++)
                {
                    var newBytes = new byte[32];
                    for (int k = 0; k < bytes.Length; k++)
                    {
                        var a = bytes[k] / 16;
                        var b = bytes[k] % 16;
                        if (a > 9)
                        {
                            newBytes[2 * k] = (byte)(a + 87);
                        }
                        else
                        {
                            newBytes[2 * k] = (byte)(a + 48);
                        }
                        if (b > 9)
                        {
                            newBytes[2 * k + 1] = (byte)(b + 87);
                        }
                        else
                        {
                            newBytes[2 * k + 1] = (byte)(b + 48);
                        }
                    }
                    bytes = md5provider.ComputeHash(newBytes);
                    hash.Clear();
                }
                for (int j = 0; j < bytes.Length; j++)
                {
                    hash.Append(bytes[j].ToString("x2"));
                }
                string v = hash.ToString();
                hashes.Add(v);
            }
            List<KeyValuePair<int, char>> three = new List<KeyValuePair<int, char>>();
            List<KeyValuePair<int, char>> five = new List<KeyValuePair<int, char>>();
            for (int i = 0; i < hashes.Count; i++)
            {
                bool already3 = false;
                for (int j = 0; j < hashes[i].Length - 2; j++)
                {
                    if (hashes[i][j] == hashes[i][j + 1] &&
                        hashes[i][j] == hashes[i][j + 2])
                    {
                        if (j + 4 < hashes[i].Length)
                        {
                            if (hashes[i][j] == hashes[i][j + 3] && hashes[i][j] == hashes[i][j + 4])
                            {
                                five.Add(new KeyValuePair<int, char>(i, hashes[i][j]));
                                if (!already3)
                                {
                                    already3 = true;
                                    three.Add(new KeyValuePair<int, char>(i, hashes[i][j]));
                                }
                                break;
                            }
                        }
                        if (!already3)
                        {
                            already3 = true;
                            three.Add(new KeyValuePair<int, char>(i, hashes[i][j]));
                        }
                    }
                }
            }
            var count = 0;
            foreach (var item in three)
            {
                var fives = five.Where(f => f.Key <= item.Key + 1000 && f.Key > item.Key);
                fives = fives.Where(f => f.Value == item.Value);
                if (fives.Count() >= 1)
                {
                    count++;
                }
                if (count == 64)
                {
                    return item.Key;
                }
            }
            return 0;
        }
    }
}

