using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay12
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "cpy 41 a\ninc a\ninc a\ndec a\njnz a 2\ndec a";
            Assert.Equal(42, Day12.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "cpy 41 a\ninc a\ninc a\ndec a\njnz a 2\ndec a";
            Assert.Equal(42, Day12.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day12.in");
            Assert.Equal(318083, Day12.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day12.in");
            Assert.Equal(9227737, Day12.PartTwo(input.Split("\r\n")));
        }
    }
}

