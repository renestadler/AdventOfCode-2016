using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay19
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "5";
            Assert.Equal(3, Day19.PartOne(input));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "5";
            Assert.Equal(2, Day19.PartTwo(input));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day19.in");
            Assert.Equal(1830117, Day19.PartOne(input));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day19.in");
            Assert.Equal(1417887, Day19.PartTwo(input));
        }
    }
}

