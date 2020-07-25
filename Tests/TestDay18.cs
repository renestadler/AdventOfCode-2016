using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay18
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "..^^.";
            Assert.Equal(6, Day18.PartOne(input, 3));
            input = ".^^.^.^^^^";
            Assert.Equal(38, Day18.PartOne(input, 10));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "..^^.";
            Assert.Equal(6, Day18.PartTwo(input, 3));
            input = ".^^.^.^^^^";
            Assert.Equal(38, Day18.PartTwo(input, 10));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day18.in");
            Assert.Equal(2035, Day18.PartOne(input, 40));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day18.in");
            Assert.Equal(20000577, Day18.PartTwo(input, 400000));
        }
    }
}

