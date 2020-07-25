using System.Security.Cryptography;
using System.Text;

namespace AOC_2016
{
    public class Day05
    {
        public static string PartOne(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            var counter = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                StringBuilder hash = new StringBuilder();
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input + i));

                for (int j = 0; j < bytes.Length; j++)
                {
                    hash.Append(bytes[j].ToString("x2"));
                }
                string v = hash.ToString();
                if (v.StartsWith("00000"))
                {
                    stringBuilder.Append(v[5]);
                    counter++;
                    if (counter == 8)
                    {
                        break;
                    }
                }
            }
            return stringBuilder.ToString();
        }

        public static string PartTwo(string input)
        {
            char[] characters = new char[8];
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            var counter = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                StringBuilder hash = new StringBuilder();
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input + i));

                for (int j = 0; j < bytes.Length; j++)
                {
                    hash.Append(bytes[j].ToString("x2"));
                }
                string v = hash.ToString();
                if (v.StartsWith("00000"))
                {
                    if (v[5] >= '0' && v[5] <= '7')
                    {
                        if (characters[int.Parse(v[5] + "")] < '0')
                        {
                            characters[int.Parse(v[5] + "")] = v[6];
                            counter++;
                        }
                    }
                    if (counter == 8)
                    {
                        break;
                    }
                }
            }
            return new string(characters);
        }
    }
}
