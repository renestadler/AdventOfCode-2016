using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay02
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "ULL\nRRDDD\nLURDL\nUUUUD";
            Assert.Equal(1985, Day02.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "ULL\nRRDDD\nLURDL\nUUUUD";
            Assert.Equal("5DB3", Day02.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day02.in");
            Assert.Equal(61529, Day02.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day02.in");
            Assert.Equal("C2C28", Day02.PartTwo(input.Split("\n")));
        }
    }
}
