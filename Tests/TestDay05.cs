using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay05
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "abc";
            Assert.Equal("18f47a30", Day05.PartOne(input));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "abc";
            Assert.Equal("05ace8e3", Day05.PartTwo(input));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day05.in");
            Assert.Equal("801b56a7", Day05.PartOne(input));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day05.in");
            Assert.Equal("424a0197", Day05.PartTwo(input));
        }
    }
}
