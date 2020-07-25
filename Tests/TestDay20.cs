using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay20
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "5-8\n0-2\n4-7";
            Assert.Equal(3, Day20.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "5-8\n0-2\n4-7";
            Assert.Equal(2, Day20.PartTwo(input.Split("\n"), 9));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day20.in");
            Assert.Equal(23923783, Day20.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day20.in");
            Assert.Equal(125, Day20.PartTwo(input.Split("\r\n"), 4294967295L));
        }
    }
}

