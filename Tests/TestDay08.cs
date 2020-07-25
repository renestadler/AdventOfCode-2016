using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay08
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "rect 3x2\nrotate column x=1 by 1\nrotate row y=0 by 4\nrotate column x=1 by 1";
            Assert.Equal(6, Day08.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "\n";
            Assert.Equal("", Day08.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day08.in");
            Assert.Equal(123, Day08.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day08.in");
            Assert.Equal("", Day08.PartTwo(input.Split("\r\n")));
        }
    }
}

