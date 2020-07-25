using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay03
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "5 10 25\n9 10 14";
            Assert.Equal(1, Day03.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "101 301 501\n102 302 502\n103 303 503\n201 401 601\n202 402 602\n203 403 603";
            Assert.Equal(6, Day03.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day03.in");
            Assert.Equal(1032, Day03.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day03.in");
            Assert.Equal(1838, Day03.PartTwo(input.Split("\n")));
        }
    }
}
