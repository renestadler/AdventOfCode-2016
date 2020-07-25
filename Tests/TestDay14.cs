using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay14
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "abc";
            Assert.Equal(22728, Day14.PartOne(input));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "abc";
            Assert.Equal(22551, Day14.PartTwo(input));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day14.in");
            Assert.Equal(16106, Day14.PartOne(input));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day14.in");
            Assert.Equal(22423, Day14.PartTwo(input));
        }
    }
}

