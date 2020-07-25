using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay11
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "The first floor contains a hydrogen-compatible microchip and a" +
                " lithium-compatible microchip.\nThe second floor contains a hydrogen generator" +
                ".\nThe third floor contains a lithium generator.\nThe fourth floor contains nothing relevant.";
            Assert.Equal(11, Day11.PartOne(input));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "\n";
            Assert.Equal(35, Day11.PartTwo(input));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day11.in");
            Assert.Equal(33, Day11.PartOne(input));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day11.in");
            Assert.Equal(57, Day11.PartTwo(input));
        }
    }
}

