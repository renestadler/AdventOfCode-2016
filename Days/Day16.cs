
using System.Linq;
using System.Text;

namespace AOC_2016
{
    public class Day16
    {
        public static string PartOne(string input, int length)
        {
            string res = input + '0' + new string(input.Reverse().Select(a => a == '0' ? '1' : '0').ToArray());
            while (res.Length < length)
            {
                res = res + '0' + new string(res.Reverse().Select(a => a == '0' ? '1' : '0').ToArray());
            }
            res = res.Substring(0, length);
            do
            {
                var newString = new StringBuilder();
                for (int i = 0; i < res.Length; i += 2)
                {
                    if (res[i] == res[i + 1])
                    {
                        newString.Append("1");
                    }
                    else
                    {
                        newString.Append("0");
                    }
                }
                res = newString.ToString();
            }
            while (res.Length % 2 == 0);

            return res;
        }

        public static string PartTwo(string input, int length)
        {
            string res = input + '0' + new string(input.Reverse().Select(a => a == '0' ? '1' : '0').ToArray());
            while (res.Length < length)
            {
                res = res + '0' + new string(res.Reverse().Select(a => a == '0' ? '1' : '0').ToArray());
            }
            res = res.Substring(0, length);
            do
            {
                var newString = new StringBuilder();
                for (int i = 0; i < res.Length; i += 2)
                {
                    if (res[i] == res[i + 1])
                    {
                        newString.Append("1");
                    }
                    else
                    {
                        newString.Append("0");
                    }
                }
                res = newString.ToString();
            }
            while (res.Length % 2 == 0);

            return res;
        }
    }
}

