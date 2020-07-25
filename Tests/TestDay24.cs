using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay24
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "###########\n#0.1.....2#\n#.#######.#\n#4.......3#\n###########";
            Assert.Equal(14, Day24.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "\n";
            Assert.Equal(720, Day24.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day24.in");
            Assert.Equal(470, Day24.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day24.in");
            Assert.Equal(720, Day24.PartTwo(input.Split("\r\n")));
        }
    }
}

