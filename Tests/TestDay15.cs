using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay15
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "Disc #1 has 5 positions; at time=0, it is at position 4.\n" +
                "Disc #2 has 2 positions; at time=0, it is at position 1.";
            Assert.Equal(5, Day15.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "Disc #1 has 5 positions; at time=0, it is at position 4.\n" +
                "Disc #2 has 2 positions; at time=0, it is at position 1.";
            Assert.Equal(85, Day15.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day15.in");
            Assert.Equal(122318, Day15.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day15.in");
            Assert.Equal(3208583, Day15.PartTwo(input.Split("\r\n")));
        }
    }
}

