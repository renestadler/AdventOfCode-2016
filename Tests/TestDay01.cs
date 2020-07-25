using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay01
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "R2, L3";
            Assert.Equal(5, Day01.PartOne(input.Split(", ")));
            input = "R2, R2, R2";
            Assert.Equal(2, Day01.PartOne(input.Split(", ")));
            input = "R5, L5, R5, R3";
            Assert.Equal(12, Day01.PartOne(input.Split(", ")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "R8, R4, R4, R8";
            Assert.Equal(4, Day01.PartTwo(input.Split(", ")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day01.in");
            Assert.Equal(242, Day01.PartOne(input.Split(", ")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day01.in");
            Assert.Equal(150, Day01.PartTwo(input.Split(", ")));
        }
    }
}
