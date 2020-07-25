using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay21
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "swap position 4 with position 0\nswap letter d with letter b\n" +
                "reverse positions 0 through 4\nrotate left 1 step\nmove position 1 to position 4\n" +
                "move position 3 to position 0\nrotate based on position of letter b\nrotate based on position of letter d";
            Assert.Equal("fbdecgha", Day21.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "swap position 4 with position 0\nswap letter d with letter b\n" +
                "reverse positions 0 through 4\nrotate left 1 step\nmove position 1 to position 4\n" +
                "move position 3 to position 0\nrotate based on position of letter b\nrotate based on position of letter d";
            Assert.Equal("efghdabc", Day21.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day21.in");
            Assert.Equal("bfheacgd", Day21.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day21.in");
            Assert.Equal("gcehdbfa", Day21.PartTwo(input.Split("\r\n")));
        }
    }
}

