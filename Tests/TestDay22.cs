using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay22
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "";
            Assert.Equal(-1, Day22.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "";
            Assert.Equal(-1, Day22.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day22.in");
            Assert.Equal(892, Day22.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day22.in");
            Assert.Equal(227, Day22.PartTwo(input.Split("\r\n")));
        }
    }
}

