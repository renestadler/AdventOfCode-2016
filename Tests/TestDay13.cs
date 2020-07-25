using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay13
    {
        [Fact]
        public void TestPartOneSample()
        {
            int input = 10;
            Assert.Equal(-1, Day13.PartOne(input));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            int input = 10;
            Assert.Equal(-1, Day13.PartTwo(input));
        }

        [Fact]
        public void TestPartOneInput()
        {
            int input = int.Parse(System.IO.File.ReadAllText("./Inputs/Day13.in"));
            Assert.Equal(92, Day13.PartOne(input));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            int input = int.Parse(System.IO.File.ReadAllText("./Inputs/Day13.in"));
            Assert.Equal(124, Day13.PartTwo(input));
        }
    }
}

