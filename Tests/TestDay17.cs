using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay17
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "ihgpwlah";
            Assert.Equal("DDRRRD", Day17.PartOne(input));
            input = "kglvqrro";
            Assert.Equal("DDUDRLRRUDRD", Day17.PartOne(input));
            input = "ulqzkmiv";
            Assert.Equal("DRURDRUDDLLDLUURRDULRLDUUDDDRR", Day17.PartOne(input));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "ihgpwlah";
            Assert.Equal(370, Day17.PartTwo(input));
            input = "kglvqrro";
            Assert.Equal(492, Day17.PartTwo(input));
            input = "ulqzkmiv";
            Assert.Equal(830, Day17.PartTwo(input));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day17.in");
            Assert.Equal("RRRLDRDUDD", Day17.PartOne(input));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day17.in");
            Assert.Equal(706, Day17.PartTwo(input));
        }
    }
}

