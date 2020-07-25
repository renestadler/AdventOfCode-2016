using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay25
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "";
            Assert.Equal(-1, Day25.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "\n";
            Assert.Equal("", Day25.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day25.in");
            Assert.Equal(0, Day25.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day25.in");
            Assert.Equal("", Day25.PartTwo(input.Split("\r\n")));
        }
    }
}

