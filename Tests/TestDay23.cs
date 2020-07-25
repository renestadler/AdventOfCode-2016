using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay23
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "cpy 2 a\ntgl a\ntgl a\ntgl a\n" +
                            "cpy 1 a\ndec a\ndec a";
            Assert.Equal(3, Day23.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "\n";
            Assert.Equal(3, Day23.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day23.in");
            Assert.Equal(10440, Day23.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day23.in");
            Assert.Equal(479007000, Day23.PartTwo(input.Split("\r\n")));
        }
    }
}

