using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay07
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "abba[mnop]qrst\nabcd[bddb]xyyx\naaaa[qwer]tyui\nioxxoj[asdfgh]zxcvbn";
            Assert.Equal(2, Day07.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "aba[bab]xyz\nxyx[xyx]xyx\naaa[kek]eke\nzazbz[bzb]cdb";
            Assert.Equal(3, Day07.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day07.in");
            Assert.Equal(118, Day07.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day07.in");
            Assert.Equal(260, Day07.PartTwo(input.Split("\r\n")));
        }
    }
}

