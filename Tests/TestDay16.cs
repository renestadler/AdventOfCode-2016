using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay16
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "10000";
            Assert.Equal("01100", Day16.PartOne(input, 20));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "10000";
            Assert.Equal("01100", Day16.PartTwo(input, 20));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day16.in");
            Assert.Equal("11111000111110000", Day16.PartOne(input, 272));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day16.in");
            Assert.Equal("10111100110110100", Day16.PartTwo(input, 35651584));
        }
    }
}

