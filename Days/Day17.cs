
using Days.Shared;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AOC_2016
{
    public class Day17
    {
        public static string PartOne(string input)
        {
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            List<Path> list = new List<Path>();
            list.Add(new Path { PosX = 0, PosY = 0, PathString = "" });
            while (true)
            {
                List<Path> newList = new List<Path>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].PosX < 0 || list[i].PosX > 3 || list[i].PosY < 0 || list[i].PosY > 3)
                    {
                        continue;
                    }
                    if (list[i].PosX == 3 && list[i].PosY == 3)
                    {
                        return list[i].PathString;
                    }
                    StringBuilder hash = new StringBuilder();
                    byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input + list[i].PathString));

                    for (int j = 0; j < bytes.Length; j++)
                    {
                        hash.Append(bytes[j].ToString("x2"));
                    }
                    string v = hash.ToString();
                    switch (v[0])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX, PosY = list[i].PosY - 1, PathString = list[i].PathString + "U" });
                            break;
                    }
                    switch (v[1])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX, PosY = list[i].PosY + 1, PathString = list[i].PathString + "D" });
                            break;
                    }
                    switch (v[2])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX - 1, PosY = list[i].PosY, PathString = list[i].PathString + "L" });
                            break;
                    }
                    switch (v[3])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX + 1, PosY = list[i].PosY, PathString = list[i].PathString + "R" });
                            break;
                    }
                }
                list = newList;
            }
        }

        public static int PartTwo(string input)
        {
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            List<Path> list = new List<Path>();
            Path final = null;
            list.Add(new Path { PosX = 0, PosY = 0, PathString = "" });
            while (list.Count > 0)
            {
                List<Path> newList = new List<Path>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].PosX < 0 || list[i].PosX > 3 || list[i].PosY < 0 || list[i].PosY > 3)
                    {
                        continue;
                    }
                    if (list[i].PosX == 3 && list[i].PosY == 3)
                    {
                        final = list[i];
                        continue;
                    }
                    StringBuilder hash = new StringBuilder();
                    byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input + list[i].PathString));

                    for (int j = 0; j < bytes.Length; j++)
                    {
                        hash.Append(bytes[j].ToString("x2"));
                    }
                    string v = hash.ToString();
                    switch (v[0])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX, PosY = list[i].PosY - 1, PathString = list[i].PathString + "U" });
                            break;
                    }
                    switch (v[1])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX, PosY = list[i].PosY + 1, PathString = list[i].PathString + "D" });
                            break;
                    }
                    switch (v[2])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX - 1, PosY = list[i].PosY, PathString = list[i].PathString + "L" });
                            break;
                    }
                    switch (v[3])
                    {
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'e':
                        case 'f':
                            newList.Add(new Path { PosX = list[i].PosX + 1, PosY = list[i].PosY, PathString = list[i].PathString + "R" });
                            break;
                    }
                }
                list = newList;
            }
            return final.PathString.Length;
        }
    }
}

